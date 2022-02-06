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
        }
        

        #region Title Bar
        // private void pnlFormBorder_MouseDown(object sender, MouseEventArgs e)
        // {
        //     movX = e.X;
        //     movY = e.Y;
        // }
        //
        // private void pnlFormBorder_MouseMove(object sender, MouseEventArgs e)
        // {
        //     if (e.Button != MouseButtons.Left) return;
        //     Location = new Point(MousePosition.X - movX, MousePosition.Y - movY);
        // }
        
        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        
        #endregion

       

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Do Code Stuff
            return;
        }
    }
}