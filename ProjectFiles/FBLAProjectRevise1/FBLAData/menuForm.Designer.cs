namespace FBLAData
{
    partial class menuForm
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
            this.slideIn = new System.Windows.Forms.Timer(this.components);
            this.slideOut = new System.Windows.Forms.Timer(this.components);
            this.viewAllBtn = new CustomFlatButton();
            this.editChapterBtn = new CustomFlatButton();
            this.bulkBtn = new CustomFlatButton();
            this.reportBtn = new CustomFlatButton();
            this.settingsBtn = new CustomFlatButton();
            this.lockBtn = new CustomFlatButton();
            this.customFlatButton2 = new CustomFlatButton();
            this.setChapterBtn = new CustomFlatButton();
            this.chapterSelectPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchChapterSelectorBox = new System.Windows.Forms.TextBox();
            this.chapterSelector = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.genNumberBtn = new CustomLabelButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.slideoutmore = new System.Windows.Forms.Timer(this.components);
            this.slideinmore = new System.Windows.Forms.Timer(this.components);
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.menuItemsPanel = new System.Windows.Forms.Panel();
            this.helpBtn = new CustomFlatButton();
            this.createChapter = new System.ComponentModel.BackgroundWorker();
            this.generateChapterNumber = new System.ComponentModel.BackgroundWorker();
            this.createChapterBtn = new System.Windows.Forms.Button();
            this.setCurrentChapter = new System.Windows.Forms.Button();
            this.viewAllChaptersBtn = new System.Windows.Forms.Button();
            this.hideExpand = new CustomFlatButton();
            this.hideMenu = new CustomFlatButton();
            this.newChapterNumberBox = new FBLAData.CustomFlatBox();
            this.creatChapterSchoolbox = new FBLAData.CustomFlatBox();
            this.editChapter = new FBLAData.editChapter();
            this.loadingItem1 = new FBLAData.loadingItem();
            this.chapterSelectPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.menuItemsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // slideIn
            // 
            this.slideIn.Interval = 1;
            this.slideIn.Tick += new System.EventHandler(this.slideIn_Tick);
            // 
            // slideOut
            // 
            this.slideOut.Interval = 1;
            this.slideOut.Tick += new System.EventHandler(this.slideOut_Tick);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.viewAllBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.viewAllBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.viewAllBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.viewAllBtn.Check = false;
            this.viewAllBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.viewAllBtn.CheckTextColor = System.Drawing.Color.White;
            this.viewAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllBtn.DefaultForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Location = new System.Drawing.Point(-3, 160);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.viewAllBtn.Size = new System.Drawing.Size(185, 53);
            this.viewAllBtn.TabIndex = 33;
            this.viewAllBtn.Text = "Members";
            this.viewAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // editChapterBtn
            // 
            this.editChapterBtn.BackColor = System.Drawing.Color.Transparent;
            this.editChapterBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.editChapterBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.editChapterBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.editChapterBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.editChapterBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.editChapterBtn.Check = false;
            this.editChapterBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.editChapterBtn.CheckTextColor = System.Drawing.Color.White;
            this.editChapterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editChapterBtn.DefaultForeColor = System.Drawing.Color.White;
            this.editChapterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editChapterBtn.ForeColor = System.Drawing.Color.White;
            this.editChapterBtn.Location = new System.Drawing.Point(-3, 107);
            this.editChapterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editChapterBtn.Name = "editChapterBtn";
            this.editChapterBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.editChapterBtn.Size = new System.Drawing.Size(185, 53);
            this.editChapterBtn.TabIndex = 34;
            this.editChapterBtn.Text = "Edit chapter info";
            this.editChapterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editChapterBtn.Click += new System.EventHandler(this.editChapterBtn_Click);
            // 
            // bulkBtn
            // 
            this.bulkBtn.BackColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.bulkBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.bulkBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.bulkBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.bulkBtn.Check = false;
            this.bulkBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.bulkBtn.CheckTextColor = System.Drawing.Color.White;
            this.bulkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bulkBtn.DefaultForeColor = System.Drawing.Color.White;
            this.bulkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkBtn.ForeColor = System.Drawing.Color.White;
            this.bulkBtn.Location = new System.Drawing.Point(-3, 213);
            this.bulkBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bulkBtn.Name = "bulkBtn";
            this.bulkBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.bulkBtn.Size = new System.Drawing.Size(185, 53);
            this.bulkBtn.TabIndex = 35;
            this.bulkBtn.Text = "Add members";
            this.bulkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bulkBtn.Click += new System.EventHandler(this.bulkBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.reportBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.reportBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.reportBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.reportBtn.Check = false;
            this.reportBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.reportBtn.CheckTextColor = System.Drawing.Color.White;
            this.reportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBtn.DefaultForeColor = System.Drawing.Color.White;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Location = new System.Drawing.Point(-3, 266);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.reportBtn.Size = new System.Drawing.Size(185, 53);
            this.reportBtn.TabIndex = 36;
            this.reportBtn.Text = "Reports";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.settingsBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.settingsBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.settingsBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.settingsBtn.Check = false;
            this.settingsBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.settingsBtn.CheckTextColor = System.Drawing.Color.White;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DefaultForeColor = System.Drawing.Color.White;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(-3, 319);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.settingsBtn.Size = new System.Drawing.Size(185, 53);
            this.settingsBtn.TabIndex = 37;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // lockBtn
            // 
            this.lockBtn.BackColor = System.Drawing.Color.Transparent;
            this.lockBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.lockBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.lockBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.lockBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lockBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.lockBtn.Check = false;
            this.lockBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.lockBtn.CheckTextColor = System.Drawing.Color.White;
            this.lockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lockBtn.DefaultForeColor = System.Drawing.Color.White;
            this.lockBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockBtn.ForeColor = System.Drawing.Color.White;
            this.lockBtn.Location = new System.Drawing.Point(-3, 425);
            this.lockBtn.Margin = new System.Windows.Forms.Padding(0);
            this.lockBtn.Name = "lockBtn";
            this.lockBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.lockBtn.Size = new System.Drawing.Size(185, 53);
            this.lockBtn.TabIndex = 38;
            this.lockBtn.Text = "Lock";
            this.lockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lockBtn.Click += new System.EventHandler(this.lockBtn_Click);
            // 
            // customFlatButton2
            // 
            this.customFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.customFlatButton2.ButtonColor = System.Drawing.Color.Transparent;
            this.customFlatButton2.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.customFlatButton2.ButtonDownTextColor = System.Drawing.Color.White;
            this.customFlatButton2.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.customFlatButton2.ButtonOverTextColor = System.Drawing.Color.White;
            this.customFlatButton2.Check = false;
            this.customFlatButton2.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.customFlatButton2.CheckTextColor = System.Drawing.Color.White;
            this.customFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customFlatButton2.DefaultForeColor = System.Drawing.Color.White;
            this.customFlatButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customFlatButton2.ForeColor = System.Drawing.Color.White;
            this.customFlatButton2.Location = new System.Drawing.Point(-3, 478);
            this.customFlatButton2.Margin = new System.Windows.Forms.Padding(0);
            this.customFlatButton2.Name = "customFlatButton2";
            this.customFlatButton2.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.customFlatButton2.Size = new System.Drawing.Size(185, 53);
            this.customFlatButton2.TabIndex = 39;
            this.customFlatButton2.Text = "Sign out";
            this.customFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customFlatButton2.Click += new System.EventHandler(this.customFlatButton2_Click);
            // 
            // setChapterBtn
            // 
            this.setChapterBtn.BackColor = System.Drawing.Color.Transparent;
            this.setChapterBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.setChapterBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.setChapterBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.setChapterBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.setChapterBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.setChapterBtn.Check = false;
            this.setChapterBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.setChapterBtn.CheckTextColor = System.Drawing.Color.White;
            this.setChapterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setChapterBtn.DefaultForeColor = System.Drawing.Color.White;
            this.setChapterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setChapterBtn.ForeColor = System.Drawing.Color.White;
            this.setChapterBtn.Location = new System.Drawing.Point(-3, 54);
            this.setChapterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.setChapterBtn.Name = "setChapterBtn";
            this.setChapterBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.setChapterBtn.Size = new System.Drawing.Size(185, 53);
            this.setChapterBtn.TabIndex = 49;
            this.setChapterBtn.Text = "Select chapter";
            this.setChapterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setChapterBtn.Click += new System.EventHandler(this.setChapterBtn_Click);
            // 
            // chapterSelectPanel
            // 
            this.chapterSelectPanel.AutoScroll = true;
            this.chapterSelectPanel.Controls.Add(this.newChapterNumberBox);
            this.chapterSelectPanel.Controls.Add(this.creatChapterSchoolbox);
            this.chapterSelectPanel.Controls.Add(this.viewAllChaptersBtn);
            this.chapterSelectPanel.Controls.Add(this.setCurrentChapter);
            this.chapterSelectPanel.Controls.Add(this.createChapterBtn);
            this.chapterSelectPanel.Controls.Add(this.panel3);
            this.chapterSelectPanel.Controls.Add(this.searchChapterSelectorBox);
            this.chapterSelectPanel.Controls.Add(this.chapterSelector);
            this.chapterSelectPanel.Controls.Add(this.label6);
            this.chapterSelectPanel.Controls.Add(this.genNumberBtn);
            this.chapterSelectPanel.Controls.Add(this.label4);
            this.chapterSelectPanel.Controls.Add(this.label2);
            this.chapterSelectPanel.Controls.Add(this.label3);
            this.chapterSelectPanel.Controls.Add(this.label1);
            this.chapterSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chapterSelectPanel.Location = new System.Drawing.Point(5, 59);
            this.chapterSelectPanel.Name = "chapterSelectPanel";
            this.chapterSelectPanel.Size = new System.Drawing.Size(464, 636);
            this.chapterSelectPanel.TabIndex = 50;
            this.chapterSelectPanel.Visible = false;
            this.chapterSelectPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.chapterSelectPanel_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(17, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 1);
            this.panel3.TabIndex = 65;
            this.panel3.Tag = "border";
            // 
            // searchChapterSelectorBox
            // 
            this.searchChapterSelectorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchChapterSelectorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchChapterSelectorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.searchChapterSelectorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchChapterSelectorBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchChapterSelectorBox.ForeColor = System.Drawing.Color.White;
            this.searchChapterSelectorBox.Location = new System.Drawing.Point(17, 104);
            this.searchChapterSelectorBox.Name = "searchChapterSelectorBox";
            this.searchChapterSelectorBox.Size = new System.Drawing.Size(405, 22);
            this.searchChapterSelectorBox.TabIndex = 64;
            this.searchChapterSelectorBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchChapterSelectorBox_KeyUp);
            // 
            // chapterSelector
            // 
            this.chapterSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterSelector.ForeColor = System.Drawing.Color.White;
            this.chapterSelector.FormattingEnabled = true;
            this.chapterSelector.ItemHeight = 21;
            this.chapterSelector.Location = new System.Drawing.Point(17, 154);
            this.chapterSelector.Name = "chapterSelector";
            this.chapterSelector.Size = new System.Drawing.Size(415, 126);
            this.chapterSelector.TabIndex = 63;
            this.chapterSelector.DoubleClick += new System.EventHandler(this.chapterSelector_DoubleClick);
            this.chapterSelector.KeyUp += new System.Windows.Forms.KeyEventHandler(this.chapterSelector_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "School name";
            // 
            // genNumberBtn
            // 
            this.genNumberBtn.AutoSize = true;
            this.genNumberBtn.BackColor = System.Drawing.Color.Transparent;
            this.genNumberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genNumberBtn.DefaultForeColor = System.Drawing.Color.White;
            this.genNumberBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genNumberBtn.ForeColor = System.Drawing.Color.White;
            this.genNumberBtn.Location = new System.Drawing.Point(361, 342);
            this.genNumberBtn.Margin = new System.Windows.Forms.Padding(3);
            this.genNumberBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.genNumberBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.genNumberBtn.Name = "genNumberBtn";
            this.genNumberBtn.Padding = new System.Windows.Forms.Padding(3);
            this.genNumberBtn.Size = new System.Drawing.Size(71, 25);
            this.genNumberBtn.TabIndex = 58;
            this.genNumberBtn.Text = "Generate";
            this.genNumberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.genNumberBtn.Click += new System.EventHandler(this.genNumberBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Chapter number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Create new Chapter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Select Chapter";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Select chapter from list or search in box below and hit enter";
            // 
            // slideoutmore
            // 
            this.slideoutmore.Interval = 1;
            this.slideoutmore.Tick += new System.EventHandler(this.slideoutmore_Tick);
            // 
            // slideinmore
            // 
            this.slideinmore.Interval = 1;
            this.slideinmore.Tick += new System.EventHandler(this.slideinmore_Tick);
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.panel4);
            this.settingsPanel.Controls.Add(this.textBox3);
            this.settingsPanel.Controls.Add(this.panel5);
            this.settingsPanel.Controls.Add(this.textBox2);
            this.settingsPanel.Controls.Add(this.panel6);
            this.settingsPanel.Controls.Add(this.textBox1);
            this.settingsPanel.Controls.Add(this.panel7);
            this.settingsPanel.Controls.Add(this.usernameBox);
            this.settingsPanel.Controls.Add(this.label13);
            this.settingsPanel.Controls.Add(this.label12);
            this.settingsPanel.Controls.Add(this.label11);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(5, 5);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(464, 690);
            this.settingsPanel.TabIndex = 51;
            this.settingsPanel.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(230, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(196, 1);
            this.panel4.TabIndex = 181;
            this.panel4.Tag = "border";
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(230, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(196, 22);
            this.textBox3.TabIndex = 180;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(25, 271);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(196, 1);
            this.panel5.TabIndex = 179;
            this.panel5.Tag = "border";
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(25, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 22);
            this.textBox2.TabIndex = 178;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(230, 150);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(196, 1);
            this.panel6.TabIndex = 177;
            this.panel6.Tag = "border";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(230, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 176;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(26, 150);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(196, 1);
            this.panel7.TabIndex = 175;
            this.panel7.Tag = "border";
            // 
            // usernameBox
            // 
            this.usernameBox.AcceptsReturn = true;
            this.usernameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.usernameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameBox.ForeColor = System.Drawing.Color.White;
            this.usernameBox.Location = new System.Drawing.Point(26, 126);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(196, 22);
            this.usernameBox.TabIndex = 174;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(226, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 173;
            this.label13.Text = "Retype password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 21);
            this.label12.TabIndex = 172;
            this.label12.Text = "Change password";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 19);
            this.label11.TabIndex = 171;
            this.label11.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 169;
            this.label9.Text = "Username";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(226, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 170;
            this.label10.Text = "My password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 25);
            this.label8.TabIndex = 168;
            this.label8.Text = "My info";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.chapterSelectPanel);
            this.contentPanel.Controls.Add(this.titleBar);
            this.contentPanel.Controls.Add(this.settingsPanel);
            this.contentPanel.Controls.Add(this.editChapter);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.contentPanel.Size = new System.Drawing.Size(474, 700);
            this.contentPanel.TabIndex = 52;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.titleBar.Controls.Add(this.hideExpand);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(5, 5);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(464, 54);
            this.titleBar.TabIndex = 64;
            // 
            // menuItemsPanel
            // 
            this.menuItemsPanel.Controls.Add(this.helpBtn);
            this.menuItemsPanel.Controls.Add(this.customFlatButton2);
            this.menuItemsPanel.Controls.Add(this.lockBtn);
            this.menuItemsPanel.Controls.Add(this.settingsBtn);
            this.menuItemsPanel.Controls.Add(this.reportBtn);
            this.menuItemsPanel.Controls.Add(this.bulkBtn);
            this.menuItemsPanel.Controls.Add(this.viewAllBtn);
            this.menuItemsPanel.Controls.Add(this.editChapterBtn);
            this.menuItemsPanel.Controls.Add(this.setChapterBtn);
            this.menuItemsPanel.Controls.Add(this.hideMenu);
            this.menuItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuItemsPanel.Location = new System.Drawing.Point(0, 0);
            this.menuItemsPanel.Name = "menuItemsPanel";
            this.menuItemsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.menuItemsPanel.Size = new System.Drawing.Size(474, 700);
            this.menuItemsPanel.TabIndex = 68;
            // 
            // helpBtn
            // 
            this.helpBtn.BackColor = System.Drawing.Color.Transparent;
            this.helpBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.helpBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.helpBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.helpBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.helpBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.helpBtn.Check = false;
            this.helpBtn.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.helpBtn.CheckTextColor = System.Drawing.Color.White;
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.DefaultForeColor = System.Drawing.Color.White;
            this.helpBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.ForeColor = System.Drawing.Color.White;
            this.helpBtn.Location = new System.Drawing.Point(-2, 372);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.helpBtn.Size = new System.Drawing.Size(185, 53);
            this.helpBtn.TabIndex = 66;
            this.helpBtn.Text = "Help";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createChapter
            // 
            this.createChapter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.createChapter_DoWork);
            this.createChapter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.createChapter_RunWorkerCompleted);
            // 
            // generateChapterNumber
            // 
            this.generateChapterNumber.DoWork += new System.ComponentModel.DoWorkEventHandler(this.generateChapterNumber_DoWork);
            this.generateChapterNumber.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.generateChapterNumber_RunWorkerCompleted);
            // 
            // createChapterBtn
            // 
            this.createChapterBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.createChapterBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createChapterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.createChapterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createChapterBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createChapterBtn.Location = new System.Drawing.Point(323, 467);
            this.createChapterBtn.Name = "createChapterBtn";
            this.createChapterBtn.Size = new System.Drawing.Size(109, 37);
            this.createChapterBtn.TabIndex = 66;
            this.createChapterBtn.Text = "Create chapter";
            this.createChapterBtn.UseVisualStyleBackColor = true;
            this.createChapterBtn.Click += new System.EventHandler(this.createChapterBtn_Click);
            // 
            // setCurrentChapter
            // 
            this.setCurrentChapter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.setCurrentChapter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.setCurrentChapter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.setCurrentChapter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setCurrentChapter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setCurrentChapter.Location = new System.Drawing.Point(375, 265);
            this.setCurrentChapter.Name = "setCurrentChapter";
            this.setCurrentChapter.Size = new System.Drawing.Size(57, 37);
            this.setCurrentChapter.TabIndex = 67;
            this.setCurrentChapter.Text = "Go";
            this.setCurrentChapter.UseVisualStyleBackColor = true;
            this.setCurrentChapter.Click += new System.EventHandler(this.setChapterBtn_Click);
            // 
            // viewAllChaptersBtn
            // 
            this.viewAllChaptersBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.viewAllChaptersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.viewAllChaptersBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.viewAllChaptersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllChaptersBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllChaptersBtn.Location = new System.Drawing.Point(234, 265);
            this.viewAllChaptersBtn.Name = "viewAllChaptersBtn";
            this.viewAllChaptersBtn.Size = new System.Drawing.Size(135, 37);
            this.viewAllChaptersBtn.TabIndex = 68;
            this.viewAllChaptersBtn.Text = "View all chapters";
            this.viewAllChaptersBtn.UseVisualStyleBackColor = true;
            this.viewAllChaptersBtn.Click += new System.EventHandler(this.viewAllChaptersBtn_Click);
            // 
            // hideExpand
            // 
            this.hideExpand.BackColor = System.Drawing.Color.Transparent;
            this.hideExpand.ButtonColor = System.Drawing.Color.Transparent;
            this.hideExpand.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.hideExpand.ButtonDownTextColor = System.Drawing.Color.White;
            this.hideExpand.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.hideExpand.ButtonOverTextColor = System.Drawing.Color.White;
            this.hideExpand.Check = false;
            this.hideExpand.CheckColor = System.Drawing.Color.Empty;
            this.hideExpand.CheckTextColor = System.Drawing.Color.Empty;
            this.hideExpand.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hideExpand.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.hideExpand.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideExpand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideExpand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.hideExpand.Image = global::FBLAData.Properties.Resources.backarrow;
            this.hideExpand.Location = new System.Drawing.Point(0, 0);
            this.hideExpand.Margin = new System.Windows.Forms.Padding(0);
            this.hideExpand.Name = "hideExpand";
            this.hideExpand.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.hideExpand.Size = new System.Drawing.Size(48, 54);
            this.hideExpand.TabIndex = 64;
            this.hideExpand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hideExpand.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // hideMenu
            // 
            this.hideMenu.AllowDrop = true;
            this.hideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.hideMenu.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.hideMenu.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.hideMenu.ButtonDownTextColor = System.Drawing.Color.White;
            this.hideMenu.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.hideMenu.ButtonOverTextColor = System.Drawing.Color.White;
            this.hideMenu.Check = false;
            this.hideMenu.CheckColor = System.Drawing.Color.Empty;
            this.hideMenu.CheckTextColor = System.Drawing.Color.Empty;
            this.hideMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.hideMenu.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.hideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.hideMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.hideMenu.Image = global::FBLAData.Properties.Resources.menuBtn22;
            this.hideMenu.Location = new System.Drawing.Point(5, 5);
            this.hideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.hideMenu.MaximumSize = new System.Drawing.Size(48, 49);
            this.hideMenu.Name = "hideMenu";
            this.hideMenu.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.hideMenu.Size = new System.Drawing.Size(48, 49);
            this.hideMenu.TabIndex = 65;
            this.hideMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hideMenu.Click += new System.EventHandler(this.hideMenu_Click);
            // 
            // newChapterNumberBox
            // 
            this.newChapterNumberBox.associatedButton = null;
            this.newChapterNumberBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.newChapterNumberBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.newChapterNumberBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newChapterNumberBox.Location = new System.Drawing.Point(26, 370);
            this.newChapterNumberBox.Name = "newChapterNumberBox";
            this.newChapterNumberBox.Size = new System.Drawing.Size(406, 28);
            this.newChapterNumberBox.TabIndex = 72;
            this.newChapterNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newChapterNumberBox_KeyPress);
            // 
            // creatChapterSchoolbox
            // 
            this.creatChapterSchoolbox.associatedButton = this.createChapterBtn;
            this.creatChapterSchoolbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.creatChapterSchoolbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(113)))), ((int)(((byte)(129)))));
            this.creatChapterSchoolbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.creatChapterSchoolbox.Location = new System.Drawing.Point(26, 433);
            this.creatChapterSchoolbox.Name = "creatChapterSchoolbox";
            this.creatChapterSchoolbox.Size = new System.Drawing.Size(406, 28);
            this.creatChapterSchoolbox.TabIndex = 71;
            // 
            // editChapter
            // 
            this.editChapter.AutoScroll = true;
            this.editChapter.BackColor = System.Drawing.Color.White;
            this.editChapter.chapterInformation = null;
            this.editChapter.chapterTable = null;
            this.editChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editChapter.Location = new System.Drawing.Point(5, 5);
            this.editChapter.Name = "editChapter";
            this.editChapter.Size = new System.Drawing.Size(464, 690);
            this.editChapter.TabIndex = 52;
            this.editChapter.thisWindow = null;
            this.editChapter.Visible = false;
            this.editChapter.Load += new System.EventHandler(this.editChapter_Load);
            // 
            // loadingItem1
            // 
            this.loadingItem1.BackColor = System.Drawing.Color.Transparent;
            this.loadingItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingItem1.Image = global::FBLAData.Properties.Resources.blueloading;
            this.loadingItem1.Location = new System.Drawing.Point(0, 0);
            this.loadingItem1.Name = "loadingItem1";
            this.loadingItem1.Size = new System.Drawing.Size(474, 700);
            this.loadingItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingItem1.TabIndex = 55;
            this.loadingItem1.TabStop = false;
            this.loadingItem1.TextColor = System.Drawing.Color.White;
            this.loadingItem1.Visible = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(474, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuItemsPanel);
            this.Controls.Add(this.loadingItem1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuForm";
            this.ShowInTaskbar = false;
            this.Text = "menuForm";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.menuForm_Deactivate);
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.VisibleChanged += new System.EventHandler(this.menuForm_VisibleChanged);
            this.chapterSelectPanel.ResumeLayout(false);
            this.chapterSelectPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.menuItemsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer slideOut;
        public System.Windows.Forms.Timer slideIn;
        public CustomFlatButton viewAllBtn;
        public CustomFlatButton editChapterBtn;
        public CustomFlatButton bulkBtn;
        public CustomFlatButton reportBtn;
        public CustomFlatButton settingsBtn;
        public CustomFlatButton lockBtn;
        public CustomFlatButton customFlatButton2;
        public CustomFlatButton setChapterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private CustomLabelButton genNumberBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer slideoutmore;
        private System.Windows.Forms.Timer slideinmore;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel contentPanel;
        public loadingItem loadingItem1;
        public System.Windows.Forms.Panel chapterSelectPanel;
        public editChapter editChapter;
        public System.Windows.Forms.Panel titleBar;
        public CustomFlatButton hideExpand;
        public CustomFlatButton hideMenu;
        public CustomFlatButton helpBtn;
        public System.Windows.Forms.Panel menuItemsPanel;
        private System.ComponentModel.BackgroundWorker createChapter;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TextBox searchChapterSelectorBox;
        public System.Windows.Forms.ListBox chapterSelector;
        private System.ComponentModel.BackgroundWorker generateChapterNumber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createChapterBtn;
        private System.Windows.Forms.Button viewAllChaptersBtn;
        private System.Windows.Forms.Button setCurrentChapter;
        public CustomFlatBox creatChapterSchoolbox;
        public CustomFlatBox newChapterNumberBox;
    }
}