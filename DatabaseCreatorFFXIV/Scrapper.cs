using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCreatorFFXIV.Managers;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace DatabaseCreatorFFXIV
{
    public class Scrapper
    {
        #region UI Elements
        private Label lblCurrentScrapping;
        private ListBox lbStepsView;
        private Label lblPageCount;
        private ProgressBar progressBar;
        #endregion
        
        private Queue<string> scrapItems;
        private DatabaseManager databaseManager;

        #region Scrapper Variables
        
        private int currentPage;
        private int maxPage;
        private HtmlDocument doc;
        private HtmlWeb web;
        
        #endregion

        public Scrapper(Label lblCurrentScrapping, ListBox lbStepsView, Label lblPageCount, ProgressBar progressBar, Queue<string> scrapItems)
        {
            databaseManager = new DatabaseManager();
            
            this.lblCurrentScrapping = lblCurrentScrapping;
            this.lbStepsView = lbStepsView;
            this.lblPageCount = lblPageCount;
            this.progressBar = progressBar;
            this.scrapItems = scrapItems;

            currentPage = 1;
            doc = null;
            SetupPage();
        }

        // private List<HtmlDocument> test = new List<HtmlDocument>();
        // private void Test()
        // {
        //     for (int i = 0; i < 2; i++)
        //     {
        //         var temp = web.Load($"https://eu.finalfantasyxiv.com/lodestone/playguide/db/item/?page={i}");
        //         test.Add(temp);
        //     }
        //
        //     lblCurrentScrapping.Text = "DONE";
        // }

        private void SetupPage()
        {
            web = new HtmlWeb();

            // Loads the first page
            doc = web.Load($"https://eu.finalfantasyxiv.com/lodestone/playguide/db/item/?page={currentPage}");
            GetMaxPage();
            
            // Sets first basic values
            progressBar.Maximum = maxPage;
            progressBar.Value = currentPage;
            lblPageCount.Text = $@"{currentPage} / {maxPage}";

            progressBar.Visible = true;
            lbStepsView.Visible = true;
            
            // Starts running the actual scrapping
            Run();
        }
        
        private void Run()
        {
            while (currentPage < maxPage)
            {
                var maxCount = doc.DocumentNode
                    .SelectNodes("/html/body/div[3]/div[2]/div[1]/div/div[2]/div[2]/div[5]/div/table/tbody/tr").Count;
            
                for (int i = 1; i < maxCount; i++)
                {
                    var itemLink = doc.DocumentNode.SelectSingleNode(
                            $"/html/body/div[3]/div[2]/div[1]/div/div[2]/div[2]/div[5]/div/table/tbody/tr[{i}]/td[1]/div[2]/a")
                        .Attributes["href"].Value;
                    lbStepsView.Items.Add(itemLink);
                }
                RefreshPage();
            }
        }

        private void RefreshPage()
        {
            // Increments the current page and loads the site with the new current page
            currentPage++;
            doc = web.Load($"https://eu.finalfantasyxiv.com/lodestone/playguide/db/item/?page={currentPage}");
            
            // Updates the Progressbar and the label for the page count
            progressBar.Value = currentPage;
            lblPageCount.Text = $@"{currentPage} / {maxPage}";
        }

        private void GetMaxPage()
        {
            // Gets the Node of the Max Page and gets the Href attribute value
            var temp = doc.DocumentNode
                .SelectSingleNode("/html/body/div[3]/div[2]/div[1]/div/div[2]/div[2]/div[3]/div[2]/div/ul/li[9]/a")
                .Attributes["href"].Value;
            
            // Removes everything to the '=' character
            temp = temp.Remove(0, temp.IndexOf("=") + 1);
            
            //Tries to parse the temporary string to an int
            Int32.TryParse(temp, out maxPage);
        }
    }
}