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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.chbCommands = new System.Windows.Forms.CheckBox();
            this.chbShops = new System.Windows.Forms.CheckBox();
            this.chbAchivements = new System.Windows.Forms.CheckBox();
            this.chbGathering = new System.Windows.Forms.CheckBox();
            this.chbCrafting = new System.Windows.Forms.CheckBox();
            this.chbQuests = new System.Windows.Forms.CheckBox();
            this.chbDutys = new System.Windows.Forms.CheckBox();
            this.chbItems = new System.Windows.Forms.CheckBox();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblCurrentScrap = new System.Windows.Forms.Label();
            this.lbSteps = new System.Windows.Forms.ListBox();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lblPageProg = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.pnlTitleBar.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (123)))), ((int) (((byte) (116)))), ((int) (((byte) (166)))));
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(718, 22);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(246, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "FFXIV Database Creator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(630, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(44, 22);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (123)))), ((int) (((byte) (116)))), ((int) (((byte) (166)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (2)))), ((int) (((byte) (40)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (148)))), ((int) (((byte) (1)))), ((int) (((byte) (33)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(674, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (104)))), ((int) (((byte) (98)))), ((int) (((byte) (140)))));
            this.pnlSettings.Controls.Add(this.btnRun);
            this.pnlSettings.Controls.Add(this.chbCommands);
            this.pnlSettings.Controls.Add(this.chbShops);
            this.pnlSettings.Controls.Add(this.chbAchivements);
            this.pnlSettings.Controls.Add(this.chbGathering);
            this.pnlSettings.Controls.Add(this.chbCrafting);
            this.pnlSettings.Controls.Add(this.chbQuests);
            this.pnlSettings.Controls.Add(this.chbDutys);
            this.pnlSettings.Controls.Add(this.chbItems);
            this.pnlSettings.Controls.Add(this.lblSettings);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSettings.Location = new System.Drawing.Point(0, 22);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(170, 362);
            this.pnlSettings.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.Location = new System.Drawing.Point(12, 322);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(155, 32);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // chbCommands
            // 
            this.chbCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbCommands.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbCommands.Location = new System.Drawing.Point(12, 288);
            this.chbCommands.Name = "chbCommands";
            this.chbCommands.Size = new System.Drawing.Size(155, 28);
            this.chbCommands.TabIndex = 6;
            this.chbCommands.Text = "Text Commands";
            this.chbCommands.UseVisualStyleBackColor = true;
            // 
            // chbShops
            // 
            this.chbShops.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbShops.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbShops.Location = new System.Drawing.Point(12, 254);
            this.chbShops.Name = "chbShops";
            this.chbShops.Size = new System.Drawing.Size(155, 28);
            this.chbShops.TabIndex = 11;
            this.chbShops.Text = "Shops";
            this.chbShops.UseVisualStyleBackColor = true;
            // 
            // chbAchivements
            // 
            this.chbAchivements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbAchivements.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbAchivements.Location = new System.Drawing.Point(12, 223);
            this.chbAchivements.Name = "chbAchivements";
            this.chbAchivements.Size = new System.Drawing.Size(155, 28);
            this.chbAchivements.TabIndex = 10;
            this.chbAchivements.Text = "Achivements";
            this.chbAchivements.UseVisualStyleBackColor = true;
            // 
            // chbGathering
            // 
            this.chbGathering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbGathering.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbGathering.Location = new System.Drawing.Point(12, 189);
            this.chbGathering.Name = "chbGathering";
            this.chbGathering.Size = new System.Drawing.Size(155, 28);
            this.chbGathering.TabIndex = 9;
            this.chbGathering.Text = "Gathering";
            this.chbGathering.UseVisualStyleBackColor = true;
            // 
            // chbCrafting
            // 
            this.chbCrafting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbCrafting.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbCrafting.Location = new System.Drawing.Point(12, 155);
            this.chbCrafting.Name = "chbCrafting";
            this.chbCrafting.Size = new System.Drawing.Size(155, 28);
            this.chbCrafting.TabIndex = 8;
            this.chbCrafting.Text = "Crafting";
            this.chbCrafting.UseVisualStyleBackColor = true;
            // 
            // chbQuests
            // 
            this.chbQuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbQuests.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbQuests.Location = new System.Drawing.Point(12, 121);
            this.chbQuests.Name = "chbQuests";
            this.chbQuests.Size = new System.Drawing.Size(155, 28);
            this.chbQuests.TabIndex = 7;
            this.chbQuests.Text = "Quests";
            this.chbQuests.UseVisualStyleBackColor = true;
            // 
            // chbDutys
            // 
            this.chbDutys.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbDutys.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbDutys.Location = new System.Drawing.Point(12, 87);
            this.chbDutys.Name = "chbDutys";
            this.chbDutys.Size = new System.Drawing.Size(155, 28);
            this.chbDutys.TabIndex = 6;
            this.chbDutys.Text = "Dutys";
            this.chbDutys.UseVisualStyleBackColor = true;
            // 
            // chbItems
            // 
            this.chbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.chbItems.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (179)))), ((int) (((byte) (179)))));
            this.chbItems.Location = new System.Drawing.Point(12, 53);
            this.chbItems.Name = "chbItems";
            this.chbItems.Size = new System.Drawing.Size(155, 28);
            this.chbItems.TabIndex = 5;
            this.chbItems.Text = "Items";
            this.chbItems.UseVisualStyleBackColor = true;
            // 
            // lblSettings
            // 
            this.lblSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSettings.ForeColor = System.Drawing.Color.Black;
            this.lblSettings.Location = new System.Drawing.Point(0, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(170, 50);
            this.lblSettings.TabIndex = 4;
            this.lblSettings.Text = "Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentScrap
            // 
            this.lblCurrentScrap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentScrap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblCurrentScrap.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (153)))), ((int) (((byte) (153)))));
            this.lblCurrentScrap.Location = new System.Drawing.Point(170, 22);
            this.lblCurrentScrap.Name = "lblCurrentScrap";
            this.lblCurrentScrap.Size = new System.Drawing.Size(548, 50);
            this.lblCurrentScrap.TabIndex = 2;
            this.lblCurrentScrap.Text = "Currently Scrapping: Text Commands";
            this.lblCurrentScrap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSteps
            // 
            this.lbSteps.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (57)))), ((int) (((byte) (54)))), ((int) (((byte) (77)))));
            this.lbSteps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSteps.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (147)))), ((int) (((byte) (179)))), ((int) (((byte) (255)))));
            this.lbSteps.FormattingEnabled = true;
            this.lbSteps.Location = new System.Drawing.Point(176, 76);
            this.lbSteps.Name = "lbSteps";
            this.lbSteps.Size = new System.Drawing.Size(533, 197);
            this.lbSteps.TabIndex = 3;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(176, 294);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(532, 27);
            this.progBar.TabIndex = 4;
            // 
            // lblPageProg
            // 
            this.lblPageProg.AutoSize = true;
            this.lblPageProg.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (153)))), ((int) (((byte) (153)))));
            this.lblPageProg.Location = new System.Drawing.Point(176, 278);
            this.lblPageProg.Name = "lblPageProg";
            this.lblPageProg.Size = new System.Drawing.Size(76, 13);
            this.lblPageProg.TabIndex = 5;
            this.lblPageProg.Text = "Page 999/999";
            // 
            // lblErrors
            // 
            this.lblErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblErrors.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (153)))), ((int) (((byte) (153)))), ((int) (((byte) (153)))));
            this.lblErrors.Location = new System.Drawing.Point(173, 337);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(532, 38);
            this.lblErrors.TabIndex = 6;
            this.lblErrors.Text = "Errors";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (57)))), ((int) (((byte) (54)))), ((int) (((byte) (77)))));
            this.ClientSize = new System.Drawing.Size(718, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lblErrors);
            this.Controls.Add(this.lblPageProg);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.lbSteps);
            this.Controls.Add(this.lblCurrentScrap);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblErrors;

        private System.Windows.Forms.Label lblPageProg;

        private System.Windows.Forms.ProgressBar progBar;

        private System.Windows.Forms.ListBox lbSteps;

        private System.Windows.Forms.Label lblCurrentScrap;

        private System.Windows.Forms.Button btnRun;

        private System.Windows.Forms.CheckBox chbItems;
        private System.Windows.Forms.CheckBox chbDutys;
        private System.Windows.Forms.CheckBox chbQuests;
        private System.Windows.Forms.CheckBox chbCrafting;
        private System.Windows.Forms.CheckBox chbGathering;
        private System.Windows.Forms.CheckBox chbAchivements;
        private System.Windows.Forms.CheckBox chbShops;
        private System.Windows.Forms.CheckBox chbCommands;

        private System.Windows.Forms.Label lblSettings;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Button btnMinimize;

        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel pnlSettings;

        private System.Windows.Forms.Panel pnlTitleBar;

        #endregion
    }
}