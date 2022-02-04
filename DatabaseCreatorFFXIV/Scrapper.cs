using System.Collections.Generic;
using System.Windows.Forms;
using DatabaseCreatorFFXIV.Managers;

namespace DatabaseCreatorFFXIV
{
    public class Scrapper
    {
        #region UI Elements
        private Label currentScrapping;
        private ListBox stepsView;
        private Label pageCount;
        private ProgressBar progressBar;
        #endregion
        
        private Queue<string> scrapItems;
        private DatabaseManager databaseManager;

        public Scrapper(Label currentScrapping, ListBox stepsView, Label pageCount, ProgressBar progressBar, Queue<string> scrapItems)
        {
            this.currentScrapping = currentScrapping;
            this.stepsView = stepsView;
            this.pageCount = pageCount;
            this.progressBar = progressBar;
            this.scrapItems = scrapItems;
            databaseManager = new DatabaseManager();
        }
    }
}