using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseCreatorFFXIV.Managers;

namespace DatabaseCreatorFFXIV
{
    public partial class MainWindow : Form
    {
        private Scrapper scrapper;
        
        private List<CheckBox> checkBoxes;
        private int movX;
        private int movY;
        
        public MainWindow()
        {
            InitializeComponent();
            checkBoxes = new List<CheckBox>()
            {
                chbItems,
                chbDutys,
                chbQuests,
                chbCrafting,
                chbGathering,
                chbAchivements,
                chbShops,
                chbCommands
            };
        }
        

        #region Title Bar

        private new void MouseDown(object sender, MouseEventArgs e)
        {
            movX = e.X;
            movY = e.Y;
        }

        private new void MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Location = new Point(MousePosition.X - movX, MousePosition.Y - movY);
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        
        #endregion

        private void btnRun_Click(object sender, EventArgs e)
        {
            var scrapingItems = CheckSelection();

            if (scrapingItems == null) return;

            foreach (var checkBox in checkBoxes)
                checkBox.Enabled = false;
            btnRun.Enabled = false;
            
            scrapper = new Scrapper(scrapingItems);
            scrapper.OnProgressUpdate += UpdateProgress;
            scrapper.OnViewUpdate += UpdateLbSteps;
            scrapper.OnScrapUpdate += UpdateLblCurrentScrap;
            
            scrapper.Run();
        }
        private List<string> CheckSelection()
        {
            lblErrors.Text = "";
            
            var scrappingItems = new List<string>();
            
            foreach (var checkBox in checkBoxes)
            {
                if(checkBox.Checked)
                    scrappingItems.Add(checkBox.Text);
            }

            if (scrappingItems.Count != 0) return scrappingItems;
            
            lblErrors.Text = "Please select at least on of the boxes";
            return null;
        }
        
        #region Update Methods

        private void UpdateProgress(string text, float progress)
        {
            if (!progBar.Visible)
            {
                progBar.Visible = true;
                lblPageProg.Visible = true;
            }
            
            lblPageProg.Text = text;
            progBar.Value = (int) progress;
        }

        private void UpdateLbSteps(string text)
        {
            lbSteps.Items.Add(text);
            lbSteps.TopIndex = lbSteps.Items.Count - 1;
        }

        private void UpdateLblCurrentScrap(string text)
        {
            if (!lblCurrentScrap.Visible)
                lblCurrentScrap.Visible = true;
            
            if (text == "")
            {
                lblCurrentScrap.Text = "";
                return;
            }
            lblCurrentScrap.Text = $"Currently Scrapping: {text}";
        }

        #endregion
    }
}