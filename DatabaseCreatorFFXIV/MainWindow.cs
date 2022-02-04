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
                chbRecipies,
                chbGathering,
                chbAchivements,
                chbShops,
                chbTextCommands
            };
        }

        #region Form Buttons
        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        
        private void btnRun_Click(object sender, EventArgs e)
        {
            lblErrors.Text = "";

            var checks = CheckCheckboxes();
            if (checks == null) return;
            
            ShowScrapUi();
            scrapper = new Scrapper(lblCurrentlyScraping, lbSteps, lblPageView, progBarPageProgess, checks);
        }
        
        #endregion

        #region Form Border
        private void pnlFormBorder_MouseDown(object sender, MouseEventArgs e)
        {
            movX = e.X;
            movY = e.Y;
        }
        
        private void pnlFormBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            Location = new Point(MousePosition.X - movX, MousePosition.Y - movY);
        }
        #endregion

        private Queue<string> CheckCheckboxes()
        {
            var temp = new Queue<string>();

            foreach (var checkBox in checkBoxes)
            {
                if(checkBox.Checked)
                    temp.Enqueue(checkBox.Text);
            }

            if (temp.Count != 0) return temp;
            
            lblErrors.Text = @"Please check a box";
            return null;
        }

        private void ShowScrapUi()
        {
            progBarPageProgess.Visible = true;
            lbSteps.Visible = true;
        }
    }
}