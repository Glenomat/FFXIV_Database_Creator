using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace DatabaseCreatorFFXIV
{
    public class Scrapper
    {
        // Events to update the UI-Elements
        public Action<string, float> OnProgressUpdate;
        public Action<string> OnScrapUpdate;
        public Action<string> OnViewUpdate;

        private int maxSites = 0;

        private Dictionary<string, Queue<HtmlDocument>> siteQueue = new Dictionary<string, Queue<HtmlDocument>>();
        private List<string> scraps = new List<string>();
        private List<string> selectedItems;
        
        private Queue<string> tasksToRun = new Queue<string>();
        private Task itemsOnSite;

        public Scrapper(List<string> selectedItems)
        {
            GetScraps(selectedItems);
        }

        public void Run()
        {
            foreach (var scrap in scraps)
                Task.Run(() => LoadSites(scrap));
        }

        /// <summary>
        /// Takes a list of strings and tries to get the corresponding string for the url
        /// </summary>
        /// <param name="selectedScraps">List of strings filled with the CheckBox names</param>
        private void GetScraps(List<string> selectedScraps)
        {
            // Goes through all the selected Items 
            foreach (var scrap in selectedScraps)
            {
                // Gets the link name for the selected Item
                switch (scrap.ToLower())
                {
                    case "items":
                        scraps.Add("item");
                        break;
                    case "dutys":
                        scraps.Add("duty");
                        break;
                    case "quests":
                        scraps.Add("quest");
                        break;
                    case "crafting":
                        scraps.Add("recipe");
                        break;
                    case "gathering":
                        scraps.Add("gathering");
                        break;
                    case "achievements":
                        scraps.Add("achievement");
                        break;
                    case "shops":
                        scraps.Add("shop");
                        break;
                    case "text commands":
                        scraps.Add("text_command");
                        break;
                    default:
                        continue;
                }

                // Creates a new Dictionary entry with an empty queue
                siteQueue.Add(scraps[scraps.Count - 1], new Queue<HtmlDocument>());
            }
        }

        private void LoadSites(string scrapName)
        {
            var index = scraps.IndexOf(scrapName);
            scrapName = scrapName.ToUpper();
            UpdateView($"Started Loading: {scrapName}");

            var url = $"https://eu.finalfantasyxiv.com/lodestone/playguide/db/{scraps[index]}/?page=1";

            var web = new HtmlWeb();
            var document = web.Load(url);

            var currentMaxSites = GetMaxSite(document);

            var tempQueue = new Queue<HtmlDocument>();

            for (var currentSite = 1; currentSite < currentMaxSites; currentSite++)
            {
                UpdateView($"{scrapName} at page: {currentSite}/{currentMaxSites}");
                url = $"https://eu.finalfantasyxiv.com/lodestone/playguide/db/{scraps[index]}/?page={currentSite}";
                document = web.Load(url);
                tempQueue.Enqueue(document);
            }

            siteQueue[scraps[index]] = tempQueue;

            UpdateView($"Finished: {scrapName}");

            if (itemsOnSite != null && !itemsOnSite.IsCompleted)
            {
                tasksToRun?.Enqueue(scraps[index]);
                UpdateView($"Queued: {scrapName}");
                return;
            }
            itemsOnSite = Task.Run(() => GetItemsInDocument(tempQueue, scraps[index]));
        }

        private void GetItemsInDocument(Queue<HtmlDocument> documents, string name = "",bool inQueue = false)
        {
            if (inQueue)
                name = tasksToRun.Peek();
            
            OnScrapUpdate?.Invoke(name);
            OnViewUpdate?.Invoke($"Started Scrapping: {name}");

            // Actual scrapping
            var documentCount = documents.Count;

            for (var i = 0; i < documentCount; i++)
            {
                var currentDocument = documents.Dequeue();
                
                // Gets all the tr elements in the document
                var tbodyElements = currentDocument.DocumentNode.SelectNodes(".//div[@class='db-table__wrapper']/table/tbody/tr");
                
                OnProgressUpdate?.Invoke($"Page {i + 1} / {documentCount}", (i + 1) / documentCount * 100);
                
                foreach (var tr in tbodyElements)
                {
                    // In the tr element it gets the a element to have access to the href value
                    var link = tr.SelectSingleNode(".//a[@class='db_popup db-table__txt--detail_link']").Attributes["href"]
                        .Value;
                    UpdateView(link);
                }
            }
            
            // Checks if any other tasks are queued and runs the next task if there is a queue
            if (tasksToRun?.Count > 0)
                itemsOnSite = Task.Run(() => GetItemsInDocument(siteQueue[tasksToRun.Dequeue()], null , true));
        }

        private int GetMaxSite(HtmlDocument document)
        {
            var link = document.DocumentNode.SelectSingleNode(".//a[@rel='last']").Attributes["href"].Value;

            //Removes everything to the '=' character
            link = link.Remove(0, link.IndexOf("=") + 1);

            //Tries to parse the temporary string to an int
            if (int.TryParse(link, out var maxPage))
                return maxPage;
            return -1;
        }

        private void UpdateView(string text)
        {
            var sendingText = $"{DateTime.Now:hh:mm:ss}: {text}";
            OnViewUpdate?.Invoke(sendingText);
        }
    }
}