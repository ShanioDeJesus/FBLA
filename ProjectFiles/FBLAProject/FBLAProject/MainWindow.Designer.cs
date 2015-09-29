namespace FBLAProject
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
            this.components = new System.ComponentModel.Container();
            this.menuBar = new System.Windows.Forms.Panel();
            this.selectChapter = new CustomFlatButton.CustomFlatButton();
            this.selectedBar = new System.Windows.Forms.Panel();
            this.settingsBtn = new CustomFlatButton.CustomFlatButton();
            this.reportBtn = new CustomFlatButton.CustomFlatButton();
            this.exportBtn = new CustomFlatButton.CustomFlatButton();
            this.importBtn = new CustomFlatButton.CustomFlatButton();
            this.bulkBtn = new CustomFlatButton.CustomFlatButton();
            this.addNewMember = new CustomFlatButton.CustomFlatButton();
            this.viewAllBtn = new CustomFlatButton.CustomFlatButton();
            this.searchBtn = new CustomFlatButton.CustomFlatButton();
            this.chapterView = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuSlideOut = new System.Windows.Forms.Timer(this.components);
            this.menuSlideIn = new System.Windows.Forms.Timer(this.components);
            this.coverpanel = new System.Windows.Forms.Panel();
            this.homeScreen1 = new FBLAProject.HomeScreen();
            this.startScreen1 = new FBLAProject.startScreen();
            this.searchAndEdit1 = new FBLAProject.searchAndEdit();
            this.menuBar.SuspendLayout();
            this.chapterView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.menuBar.Controls.Add(this.selectedBar);
            this.menuBar.Controls.Add(this.settingsBtn);
            this.menuBar.Controls.Add(this.reportBtn);
            this.menuBar.Controls.Add(this.exportBtn);
            this.menuBar.Controls.Add(this.importBtn);
            this.menuBar.Controls.Add(this.bulkBtn);
            this.menuBar.Controls.Add(this.addNewMember);
            this.menuBar.Controls.Add(this.viewAllBtn);
            this.menuBar.Controls.Add(this.searchBtn);
            this.menuBar.Controls.Add(this.chapterView);
            this.menuBar.Location = new System.Drawing.Point(1, -1);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(3);
            this.menuBar.Size = new System.Drawing.Size(265, 656);
            this.menuBar.TabIndex = 0;
            this.menuBar.Visible = false;
            this.menuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.menuBar.Resize += new System.EventHandler(this.menuBar_Resize);
            // 
            // selectChapter
            // 
            this.selectChapter.BackColor = System.Drawing.Color.Transparent;
            this.selectChapter.ButtonColor = System.Drawing.Color.Transparent;
            this.selectChapter.ButtonDownColor = System.Drawing.Color.Gray;
            this.selectChapter.ButtonDownTextColor = System.Drawing.Color.White;
            this.selectChapter.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.selectChapter.ButtonOverTextColor = System.Drawing.Color.White;
            this.selectChapter.Check = false;
            this.selectChapter.CheckColor = System.Drawing.Color.Empty;
            this.selectChapter.DefaultForeColor = System.Drawing.Color.White;
            this.selectChapter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectChapter.ForeColor = System.Drawing.Color.White;
            this.selectChapter.Image = global::FBLAProject.Properties.Resources.searchsmall;
            this.selectChapter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectChapter.Location = new System.Drawing.Point(96, 84);
            this.selectChapter.Margin = new System.Windows.Forms.Padding(0);
            this.selectChapter.Name = "selectChapter";
            this.selectChapter.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.selectChapter.Size = new System.Drawing.Size(269, 73);
            this.selectChapter.TabIndex = 62;
            this.selectChapter.Text = "Select chapter\r\nCurrent chapter:";
            this.selectChapter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selectedBar
            // 
            this.selectedBar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectedBar.BackColor = System.Drawing.Color.White;
            this.selectedBar.ForeColor = System.Drawing.Color.White;
            this.selectedBar.Location = new System.Drawing.Point(260, 130);
            this.selectedBar.Name = "selectedBar";
            this.selectedBar.Size = new System.Drawing.Size(10, 73);
            this.selectedBar.TabIndex = 32;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.settingsBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.settingsBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.settingsBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.settingsBtn.Check = false;
            this.settingsBtn.CheckColor = System.Drawing.Color.Empty;
            this.settingsBtn.DefaultForeColor = System.Drawing.Color.White;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = global::FBLAProject.Properties.Resources.settingssmall;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Location = new System.Drawing.Point(2, 581);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.settingsBtn.Size = new System.Drawing.Size(269, 73);
            this.settingsBtn.TabIndex = 30;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.reportBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.reportBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.reportBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.reportBtn.Check = false;
            this.reportBtn.CheckColor = System.Drawing.Color.Empty;
            this.reportBtn.DefaultForeColor = System.Drawing.Color.White;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Image = global::FBLAProject.Properties.Resources.printsmall;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Location = new System.Drawing.Point(2, 508);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.reportBtn.Size = new System.Drawing.Size(269, 73);
            this.reportBtn.TabIndex = 26;
            this.reportBtn.Text = "Print reports";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.Transparent;
            this.exportBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.exportBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.exportBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.exportBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.exportBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.exportBtn.Check = false;
            this.exportBtn.CheckColor = System.Drawing.Color.Empty;
            this.exportBtn.DefaultForeColor = System.Drawing.Color.White;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Image = global::FBLAProject.Properties.Resources.exportsmall;
            this.exportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportBtn.Location = new System.Drawing.Point(2, 435);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.exportBtn.Size = new System.Drawing.Size(269, 73);
            this.exportBtn.TabIndex = 28;
            this.exportBtn.Text = "Export";
            this.exportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.BackColor = System.Drawing.Color.Transparent;
            this.importBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.importBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.importBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.importBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.importBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.importBtn.Check = false;
            this.importBtn.CheckColor = System.Drawing.Color.Empty;
            this.importBtn.DefaultForeColor = System.Drawing.Color.White;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.Color.White;
            this.importBtn.Image = global::FBLAProject.Properties.Resources.importsmall;
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importBtn.Location = new System.Drawing.Point(2, 362);
            this.importBtn.Margin = new System.Windows.Forms.Padding(0);
            this.importBtn.Name = "importBtn";
            this.importBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.importBtn.Size = new System.Drawing.Size(269, 73);
            this.importBtn.TabIndex = 27;
            this.importBtn.Text = "Import";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // bulkBtn
            // 
            this.bulkBtn.BackColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.bulkBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.bulkBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.bulkBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.bulkBtn.Check = false;
            this.bulkBtn.CheckColor = System.Drawing.Color.Empty;
            this.bulkBtn.DefaultForeColor = System.Drawing.Color.White;
            this.bulkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkBtn.ForeColor = System.Drawing.Color.White;
            this.bulkBtn.Image = global::FBLAProject.Properties.Resources.bulkaddsmall;
            this.bulkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bulkBtn.Location = new System.Drawing.Point(5, 289);
            this.bulkBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bulkBtn.Name = "bulkBtn";
            this.bulkBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.bulkBtn.Size = new System.Drawing.Size(269, 73);
            this.bulkBtn.TabIndex = 29;
            this.bulkBtn.Text = "Bulk add new members";
            this.bulkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bulkBtn.Click += new System.EventHandler(this.bulkBtn_Click);
            // 
            // addNewMember
            // 
            this.addNewMember.BackColor = System.Drawing.Color.Transparent;
            this.addNewMember.ButtonColor = System.Drawing.Color.Transparent;
            this.addNewMember.ButtonDownColor = System.Drawing.Color.Gray;
            this.addNewMember.ButtonDownTextColor = System.Drawing.Color.White;
            this.addNewMember.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.addNewMember.ButtonOverTextColor = System.Drawing.Color.White;
            this.addNewMember.Check = false;
            this.addNewMember.CheckColor = System.Drawing.Color.Empty;
            this.addNewMember.DefaultForeColor = System.Drawing.Color.White;
            this.addNewMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMember.ForeColor = System.Drawing.Color.White;
            this.addNewMember.Image = global::FBLAProject.Properties.Resources.newsmall1;
            this.addNewMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addNewMember.Location = new System.Drawing.Point(5, 216);
            this.addNewMember.Margin = new System.Windows.Forms.Padding(0);
            this.addNewMember.Name = "addNewMember";
            this.addNewMember.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.addNewMember.Size = new System.Drawing.Size(269, 73);
            this.addNewMember.TabIndex = 31;
            this.addNewMember.Text = "New member";
            this.addNewMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.viewAllBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.viewAllBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.viewAllBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.viewAllBtn.Check = false;
            this.viewAllBtn.CheckColor = System.Drawing.Color.Empty;
            this.viewAllBtn.DefaultForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Image = global::FBLAProject.Properties.Resources.searchandviewSmall;
            this.viewAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAllBtn.Location = new System.Drawing.Point(5, 143);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.viewAllBtn.Size = new System.Drawing.Size(269, 73);
            this.viewAllBtn.TabIndex = 25;
            this.viewAllBtn.Text = "View all members";
            this.viewAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.searchBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.searchBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.searchBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.searchBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.searchBtn.Check = false;
            this.searchBtn.CheckColor = System.Drawing.Color.Empty;
            this.searchBtn.DefaultForeColor = System.Drawing.Color.White;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::FBLAProject.Properties.Resources.searchsmall;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(5, 70);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.searchBtn.Size = new System.Drawing.Size(269, 73);
            this.searchBtn.TabIndex = 24;
            this.searchBtn.Text = "Search/Edit member";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // chapterView
            // 
            this.chapterView.Controls.Add(this.selectChapter);
            this.chapterView.Controls.Add(this.label1);
            this.chapterView.Controls.Add(this.comboBox1);
            this.chapterView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chapterView.Location = new System.Drawing.Point(3, 3);
            this.chapterView.Name = "chapterView";
            this.chapterView.Size = new System.Drawing.Size(259, 650);
            this.chapterView.TabIndex = 61;
            this.chapterView.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 21);
            this.label1.TabIndex = 59;
            this.label1.Text = "Select a Chapter to view";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "wooster",
            "damonte ranch 212",
            "123"});
            this.comboBox1.Location = new System.Drawing.Point(7, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 601);
            this.comboBox1.TabIndex = 60;
            // 
            // menuSlideOut
            // 
            this.menuSlideOut.Interval = 1;
            this.menuSlideOut.Tick += new System.EventHandler(this.menuBarAnimation_Tick);
            // 
            // menuSlideIn
            // 
            this.menuSlideIn.Interval = 1;
            this.menuSlideIn.Tick += new System.EventHandler(this.menuSlideIn_Tick);
            // 
            // coverpanel
            // 
            this.coverpanel.Location = new System.Drawing.Point(1, 0);
            this.coverpanel.Name = "coverpanel";
            this.coverpanel.Size = new System.Drawing.Size(915, 677);
            this.coverpanel.TabIndex = 35;
            // 
            // homeScreen1
            // 
            this.homeScreen1.BackColor = System.Drawing.Color.White;
            this.homeScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeScreen1.Location = new System.Drawing.Point(88, 0);
            this.homeScreen1.Name = "homeScreen1";
            this.homeScreen1.parform = null;
            this.homeScreen1.Size = new System.Drawing.Size(828, 676);
            this.homeScreen1.TabIndex = 4;
            // 
            // startScreen1
            // 
            this.startScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.startScreen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startScreen1.Location = new System.Drawing.Point(88, 0);
            this.startScreen1.Name = "startScreen1";
            this.startScreen1.parform = null;
            this.startScreen1.Size = new System.Drawing.Size(828, 676);
            this.startScreen1.TabIndex = 3;
            this.startScreen1.Load += new System.EventHandler(this.startScreen1_Load);
            // 
            // searchAndEdit1
            // 
            this.searchAndEdit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.searchAndEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAndEdit1.Location = new System.Drawing.Point(88, 0);
            this.searchAndEdit1.Name = "searchAndEdit1";
            this.searchAndEdit1.parform = null;
            this.searchAndEdit1.Size = new System.Drawing.Size(828, 676);
            this.searchAndEdit1.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(916, 676);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.coverpanel);
            this.Controls.Add(this.homeScreen1);
            this.Controls.Add(this.startScreen1);
            this.Controls.Add(this.searchAndEdit1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(16, 580);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(88, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResizeBegin += new System.EventHandler(this.MainWindow_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainWindow_ResizeEnd);
            this.Move += new System.EventHandler(this.MainWindow_Move);
            this.menuBar.ResumeLayout(false);
            this.chapterView.ResumeLayout(false);
            this.chapterView.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer menuSlideOut;
        private System.Windows.Forms.Timer menuSlideIn;
        public searchAndEdit searchAndEdit1;
        public startScreen startScreen1;
        public System.Windows.Forms.Panel menuBar;
        public CustomFlatButton.CustomFlatButton viewAllBtn;
        public CustomFlatButton.CustomFlatButton reportBtn;
        public CustomFlatButton.CustomFlatButton importBtn;
        public CustomFlatButton.CustomFlatButton exportBtn;
        public CustomFlatButton.CustomFlatButton bulkBtn;
        public CustomFlatButton.CustomFlatButton settingsBtn;
        public CustomFlatButton.CustomFlatButton searchBtn;
        public CustomFlatButton.CustomFlatButton addNewMember;
        public System.Windows.Forms.Panel selectedBar;
        private HomeScreen homeScreen1;
        private System.Windows.Forms.Panel coverpanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel chapterView;
        public CustomFlatButton.CustomFlatButton selectChapter;
    }
}

