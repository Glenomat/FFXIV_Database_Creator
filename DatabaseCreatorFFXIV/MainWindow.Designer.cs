namespace DatabaseCreatorFFXIV
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlFormBorder = new System.Windows.Forms.Panel();
            this.chbTextCommands = new System.Windows.Forms.CheckBox();
            this.chbGathering = new System.Windows.Forms.CheckBox();
            this.chbRecipies = new System.Windows.Forms.CheckBox();
            this.chbQuests = new System.Windows.Forms.CheckBox();
            this.chbShops = new System.Windows.Forms.CheckBox();
            this.chbAchivements = new System.Windows.Forms.CheckBox();
            this.chbDutys = new System.Windows.Forms.CheckBox();
            this.chbItems = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblErrors = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCurrentlyScraping = new System.Windows.Forms.Label();
            this.progBarPageProgess = new System.Windows.Forms.ProgressBar();
            this.lblPageView = new System.Windows.Forms.Label();
            this.lbSteps = new System.Windows.Forms.ListBox();
            this.pnlFormBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAppName.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.lblAppName.Location = new System.Drawing.Point(7, 5);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(187, 20);
            this.lblAppName.TabIndex = 9;
            this.lblAppName.Text = "FFXIV Database Creator";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (5)))), ((int) (((byte) (0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (107)))), ((int) (((byte) (4)))), ((int) (((byte) (0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(552, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.AutoSize = true;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(503, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 23);
            this.btnMinimize.TabIndex = 11;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlFormBorder
            // 
            this.pnlFormBorder.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (34)))), ((int) (((byte) (32)))), ((int) (((byte) (46)))));
            this.pnlFormBorder.Controls.Add(this.btnMinimize);
            this.pnlFormBorder.Controls.Add(this.btnClose);
            this.pnlFormBorder.Controls.Add(this.lblAppName);
            this.pnlFormBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlFormBorder.Name = "pnlFormBorder";
            this.pnlFormBorder.Size = new System.Drawing.Size(601, 29);
            this.pnlFormBorder.TabIndex = 8;
            this.pnlFormBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseDown);
            this.pnlFormBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlFormBorder_MouseMove);
            // 
            // chbTextCommands
            // 
            this.chbTextCommands.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbTextCommands.Location = new System.Drawing.Point(7, 271);
            this.chbTextCommands.Name = "chbTextCommands";
            this.chbTextCommands.Size = new System.Drawing.Size(140, 27);
            this.chbTextCommands.TabIndex = 7;
            this.chbTextCommands.Text = "Text Commands";
            this.chbTextCommands.UseVisualStyleBackColor = true;
            // 
            // chbGathering
            // 
            this.chbGathering.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbGathering.Location = new System.Drawing.Point(7, 172);
            this.chbGathering.Name = "chbGathering";
            this.chbGathering.Size = new System.Drawing.Size(140, 27);
            this.chbGathering.TabIndex = 4;
            this.chbGathering.Text = "Gathering";
            this.chbGathering.UseVisualStyleBackColor = true;
            // 
            // chbRecipies
            // 
            this.chbRecipies.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbRecipies.Location = new System.Drawing.Point(7, 139);
            this.chbRecipies.Name = "chbRecipies";
            this.chbRecipies.Size = new System.Drawing.Size(140, 27);
            this.chbRecipies.TabIndex = 3;
            this.chbRecipies.Text = "Recipies";
            this.chbRecipies.UseVisualStyleBackColor = true;
            // 
            // chbQuests
            // 
            this.chbQuests.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbQuests.Location = new System.Drawing.Point(7, 106);
            this.chbQuests.Name = "chbQuests";
            this.chbQuests.Size = new System.Drawing.Size(140, 27);
            this.chbQuests.TabIndex = 2;
            this.chbQuests.Text = "Quests";
            this.chbQuests.UseVisualStyleBackColor = true;
            // 
            // chbShops
            // 
            this.chbShops.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbShops.Location = new System.Drawing.Point(7, 238);
            this.chbShops.Name = "chbShops";
            this.chbShops.Size = new System.Drawing.Size(140, 27);
            this.chbShops.TabIndex = 6;
            this.chbShops.Text = "Shops";
            this.chbShops.UseVisualStyleBackColor = true;
            // 
            // chbAchivements
            // 
            this.chbAchivements.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbAchivements.Location = new System.Drawing.Point(7, 205);
            this.chbAchivements.Name = "chbAchivements";
            this.chbAchivements.Size = new System.Drawing.Size(140, 27);
            this.chbAchivements.TabIndex = 5;
            this.chbAchivements.Text = "Achivements";
            this.chbAchivements.UseVisualStyleBackColor = true;
            // 
            // chbDutys
            // 
            this.chbDutys.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (202)))), ((int) (((byte) (209)))), ((int) (((byte) (255)))));
            this.chbDutys.Location = new System.Drawing.Point(7, 73);
            this.chbDutys.Name = "chbDutys";
            this.chbDutys.Size = new System.Drawing.Size(140, 27);
            this.chbDutys.TabIndex = 1;
            this.chbDutys.Text = "Dutys";
            this.chbDutys.UseVisualStyleBackColor = true;
            // 
            // chbItems
            // 
            this.chbItems.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (233)))), ((int) (((byte) (255)))));
            this.chbItems.Location = new System.Drawing.Point(7, 40);
            this.chbItems.Name = "chbItems";
            this.chbItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbItems.Size = new System.Drawing.Size(140, 27);
            this.chbItems.TabIndex = 0;
            this.chbItems.Text = "Items";
            this.chbItems.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (211)))), ((int) (((byte) (233)))), ((int) (((byte) (255)))));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Scrapping";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))), ((int) (((byte) (80)))), ((int) (((byte) (115)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chbItems);
            this.panel1.Controls.Add(this.chbDutys);
            this.panel1.Controls.Add(this.chbAchivements);
            this.panel1.Controls.Add(this.chbShops);
            this.panel1.Controls.Add(this.chbQuests);
            this.panel1.Controls.Add(this.chbRecipies);
            this.panel1.Controls.Add(this.chbGathering);
            this.panel1.Controls.Add(this.chbTextCommands);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 311);
            this.panel1.TabIndex = 9;
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(3, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(86, 31);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (5)))), ((int) (((byte) (0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (107)))), ((int) (((byte) (4)))), ((int) (((byte) (0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(552, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 23);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblErrors.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (173)))), ((int) (((byte) (17)))), ((int) (((byte) (20)))));
            this.lblErrors.Location = new System.Drawing.Point(95, 7);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(0, 24);
            this.lblErrors.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(503, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 23);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (85)))), ((int) (((byte) (80)))), ((int) (((byte) (115)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblErrors);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Location = new System.Drawing.Point(161, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 40);
            this.panel2.TabIndex = 12;
            // 
            // lblCurrentlyScraping
            // 
            this.lblCurrentlyScraping.AutoSize = true;
            this.lblCurrentlyScraping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCurrentlyScraping.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (195)))), ((int) (((byte) (145)))), ((int) (((byte) (255)))));
            this.lblCurrentlyScraping.Location = new System.Drawing.Point(167, 36);
            this.lblCurrentlyScraping.Name = "lblCurrentlyScraping";
            this.lblCurrentlyScraping.Size = new System.Drawing.Size(0, 25);
            this.lblCurrentlyScraping.TabIndex = 13;
            // 
            // progBarPageProgess
            // 
            this.progBarPageProgess.Location = new System.Drawing.Point(167, 271);
            this.progBarPageProgess.Name = "progBarPageProgess";
            this.progBarPageProgess.Size = new System.Drawing.Size(421, 23);
            this.progBarPageProgess.TabIndex = 15;
            this.progBarPageProgess.Visible = false;
            // 
            // lblPageView
            // 
            this.lblPageView.AutoSize = true;
            this.lblPageView.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (195)))), ((int) (((byte) (145)))), ((int) (((byte) (255)))));
            this.lblPageView.Location = new System.Drawing.Point(167, 255);
            this.lblPageView.Name = "lblPageView";
            this.lblPageView.Size = new System.Drawing.Size(0, 13);
            this.lblPageView.TabIndex = 16;
            // 
            // lbSteps
            // 
            this.lbSteps.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (47)))), ((int) (((byte) (45)))), ((int) (((byte) (64)))));
            this.lbSteps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbSteps.Enabled = false;
            this.lbSteps.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (195)))), ((int) (((byte) (145)))), ((int) (((byte) (255)))));
            this.lbSteps.FormattingEnabled = true;
            this.lbSteps.Location = new System.Drawing.Point(167, 69);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(421, 169);
            this.lbSteps.TabIndex = 17;
            this.lbSteps.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (57)))), ((int) (((byte) (54)))), ((int) (((byte) (77)))));
            this.ClientSize = new System.Drawing.Size(600, 341);
            this.ControlBox = false;
            this.Controls.Add(this.lbSteps);
            this.Controls.Add(this.lblPageView);
            this.Controls.Add(this.progBarPageProgess);
            this.Controls.Add(this.lblCurrentlyScraping);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlFormBorder.ResumeLayout(false);
            this.pnlFormBorder.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlFormBorder;
        private System.Windows.Forms.CheckBox chbTextCommands;
        private System.Windows.Forms.CheckBox chbGathering;
        private System.Windows.Forms.CheckBox chbRecipies;
        private System.Windows.Forms.CheckBox chbQuests;
        private System.Windows.Forms.CheckBox chbShops;
        private System.Windows.Forms.CheckBox chbAchivements;
        private System.Windows.Forms.CheckBox chbDutys;
        private System.Windows.Forms.CheckBox chbItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCurrentlyScraping;
        private System.Windows.Forms.ProgressBar progBarPageProgess;
        private System.Windows.Forms.Label lblPageView;
        private System.Windows.Forms.ListBox lbSteps;

        #endregion
    }
}