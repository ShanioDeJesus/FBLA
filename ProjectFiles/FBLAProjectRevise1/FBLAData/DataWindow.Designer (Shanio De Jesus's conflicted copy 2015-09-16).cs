namespace FBLAData
{
    partial class DataWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataWindow));
            this.menuBar = new System.Windows.Forms.Panel();
            this.lockBtn = new CustomLabelButton();
            this.chapter = new CustomLabelButton();
            this.selectedBar = new System.Windows.Forms.Panel();
            this.signOutBtn = new CustomLabelButton();
            this.selectChapterBtn = new CustomFlatButton.CustomFlatButton();
            this.editChapterBtn = new CustomFlatButton.CustomFlatButton();
            this.settingsBtn = new CustomFlatButton.CustomFlatButton();
            this.reportBtn = new CustomFlatButton.CustomFlatButton();
            this.bulkBtn = new CustomFlatButton.CustomFlatButton();
            this.viewAllBtn = new CustomFlatButton.CustomFlatButton();
            this.startPanel = new System.Windows.Forms.Panel();
            this.startChapterPick = new CustomFlatButton.CustomFlatButton();
            this.startEditChapterInfo = new CustomFlatButton.CustomFlatButton();
            this.startSignout = new CustomLabelButton();
            this.label5 = new System.Windows.Forms.Label();
            this.startSettings = new CustomFlatButton.CustomFlatButton();
            this.startReports = new CustomFlatButton.CustomFlatButton();
            this.startAddMember = new CustomFlatButton.CustomFlatButton();
            this.startSearchMember = new CustomFlatButton.CustomFlatButton();
            this.moveSelectedBar = new System.Windows.Forms.Timer(this.components);
            this.chapterSelectPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.creatChapterSchoolbox = new System.Windows.Forms.TextBox();
            this.createChapterBtn = new CustomLabelButton();
            this.customLabelButton2 = new CustomLabelButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newChapterNumberBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.viewAllChaptersBtn = new CustomLabelButton();
            this.setCurrentChapter = new CustomLabelButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chapterSelectBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkForCompletedSaved = new System.Windows.Forms.Timer(this.components);
            this.lockScreen = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.customLabelButton1 = new CustomLabelButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new CustomLabelButton();
            this.checkLogin = new System.ComponentModel.BackgroundWorker();
            this.createChapter = new System.ComponentModel.BackgroundWorker();
            this.viewAllMembers = new FBLAData.viewAll();
            this.loadingItem1 = new FBLAData.loadingItem();
            this.editChapter = new FBLAData.editChapter();
            this.addMem = new FBLAData.addMembers();
            this.menuBar.SuspendLayout();
            this.startPanel.SuspendLayout();
            this.chapterSelectPanel.SuspendLayout();
            this.lockScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.White;
            this.menuBar.Controls.Add(this.lockBtn);
            this.menuBar.Controls.Add(this.chapter);
            this.menuBar.Controls.Add(this.selectedBar);
            this.menuBar.Controls.Add(this.signOutBtn);
            this.menuBar.Controls.Add(this.selectChapterBtn);
            this.menuBar.Controls.Add(this.editChapterBtn);
            this.menuBar.Controls.Add(this.settingsBtn);
            this.menuBar.Controls.Add(this.reportBtn);
            this.menuBar.Controls.Add(this.bulkBtn);
            this.menuBar.Controls.Add(this.viewAllBtn);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar.Location = new System.Drawing.Point(10, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.menuBar.Size = new System.Drawing.Size(788, 109);
            this.menuBar.TabIndex = 1;
            this.menuBar.Paint += new System.Windows.Forms.PaintEventHandler(this.menuBar_Paint);
            // 
            // lockBtn
            // 
            this.lockBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lockBtn.AutoSize = true;
            this.lockBtn.BackColor = System.Drawing.Color.Transparent;
            this.lockBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lockBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.lockBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lockBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.lockBtn.Location = new System.Drawing.Point(666, 7);
            this.lockBtn.Margin = new System.Windows.Forms.Padding(3);
            this.lockBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.lockBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.lockBtn.Name = "lockBtn";
            this.lockBtn.Padding = new System.Windows.Forms.Padding(3);
            this.lockBtn.Size = new System.Drawing.Size(43, 25);
            this.lockBtn.TabIndex = 48;
            this.lockBtn.Text = "Lock";
            this.lockBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lockBtn.Click += new System.EventHandler(this.lockBtn_Click);
            // 
            // chapter
            // 
            this.chapter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapter.AutoEllipsis = true;
            this.chapter.BackColor = System.Drawing.Color.Transparent;
            this.chapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chapter.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapter.Location = new System.Drawing.Point(7, 7);
            this.chapter.Margin = new System.Windows.Forms.Padding(3);
            this.chapter.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.chapter.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.chapter.Name = "chapter";
            this.chapter.Padding = new System.Windows.Forms.Padding(3);
            this.chapter.Size = new System.Drawing.Size(702, 25);
            this.chapter.TabIndex = 47;
            this.chapter.Text = "Current chapter: ";
            this.chapter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chapter.Click += new System.EventHandler(this.chapter_Click);
            // 
            // selectedBar
            // 
            this.selectedBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.selectedBar.ForeColor = System.Drawing.Color.White;
            this.selectedBar.Location = new System.Drawing.Point(217, 96);
            this.selectedBar.Name = "selectedBar";
            this.selectedBar.Size = new System.Drawing.Size(75, 3);
            this.selectedBar.TabIndex = 44;
            // 
            // signOutBtn
            // 
            this.signOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.signOutBtn.AutoSize = true;
            this.signOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.signOutBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.signOutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.signOutBtn.Location = new System.Drawing.Point(715, 7);
            this.signOutBtn.Margin = new System.Windows.Forms.Padding(3);
            this.signOutBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.signOutBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Padding = new System.Windows.Forms.Padding(3);
            this.signOutBtn.Size = new System.Drawing.Size(66, 25);
            this.signOutBtn.TabIndex = 41;
            this.signOutBtn.Text = "Sign out";
            this.signOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signOutBtn.Click += new System.EventHandler(this.signOutBtn_Click);
            // 
            // selectChapterBtn
            // 
            this.selectChapterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectChapterBtn.BackColor = System.Drawing.Color.Transparent;
            this.selectChapterBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.selectChapterBtn.ButtonDownColor = System.Drawing.Color.Transparent;
            this.selectChapterBtn.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.selectChapterBtn.ButtonOverColor = System.Drawing.Color.Transparent;
            this.selectChapterBtn.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.selectChapterBtn.Check = false;
            this.selectChapterBtn.CheckColor = System.Drawing.Color.Empty;
            this.selectChapterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectChapterBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.selectChapterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectChapterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.selectChapterBtn.Image = global::FBLAData.Properties.Resources.selectChapter1;
            this.selectChapterBtn.Location = new System.Drawing.Point(155, 33);
            this.selectChapterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.selectChapterBtn.Name = "selectChapterBtn";
            this.selectChapterBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.selectChapterBtn.Size = new System.Drawing.Size(75, 75);
            this.selectChapterBtn.TabIndex = 46;
            this.selectChapterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tTip.SetToolTip(this.selectChapterBtn, "Select active chapter or view all chapters");
            this.selectChapterBtn.Click += new System.EventHandler(this.selectChapterBtn_Click);
            // 
            // editChapterBtn
            // 
            this.editChapterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editChapterBtn.BackColor = System.Drawing.Color.Transparent;
            this.editChapterBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.editChapterBtn.ButtonDownColor = System.Drawing.Color.Transparent;
            this.editChapterBtn.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.editChapterBtn.ButtonOverColor = System.Drawing.Color.Transparent;
            this.editChapterBtn.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.editChapterBtn.Check = false;
            this.editChapterBtn.CheckColor = System.Drawing.Color.Empty;
            this.editChapterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editChapterBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.editChapterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editChapterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.editChapterBtn.Image = global::FBLAData.Properties.Resources.editChapter2;
            this.editChapterBtn.Location = new System.Drawing.Point(235, 33);
            this.editChapterBtn.Margin = new System.Windows.Forms.Padding(0);
            this.editChapterBtn.Name = "editChapterBtn";
            this.editChapterBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.editChapterBtn.Size = new System.Drawing.Size(75, 75);
            this.editChapterBtn.TabIndex = 45;
            this.editChapterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tTip.SetToolTip(this.editChapterBtn, "Edit chapter information");
            this.editChapterBtn.Click += new System.EventHandler(this.editChapterBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonDownColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.settingsBtn.ButtonOverColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.settingsBtn.Check = false;
            this.settingsBtn.CheckColor = System.Drawing.Color.Empty;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.settingsBtn.Image = global::FBLAData.Properties.Resources.settings;
            this.settingsBtn.Location = new System.Drawing.Point(555, 33);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.settingsBtn.Size = new System.Drawing.Size(75, 75);
            this.settingsBtn.TabIndex = 37;
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tTip.SetToolTip(this.settingsBtn, "View settings");
            // 
            // reportBtn
            // 
            this.reportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonDownColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.reportBtn.ButtonOverColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.reportBtn.Check = false;
            this.reportBtn.CheckColor = System.Drawing.Color.Empty;
            this.reportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.reportBtn.Image = global::FBLAData.Properties.Resources.report2;
            this.reportBtn.Location = new System.Drawing.Point(475, 33);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(0);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.reportBtn.Size = new System.Drawing.Size(75, 75);
            this.reportBtn.TabIndex = 33;
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tTip.SetToolTip(this.reportBtn, "Print or export reports");
            // 
            // bulkBtn
            // 
            this.bulkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bulkBtn.BackColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonDownColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.bulkBtn.ButtonOverColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.bulkBtn.Check = false;
            this.bulkBtn.CheckColor = System.Drawing.Color.Empty;
            this.bulkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bulkBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.bulkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.bulkBtn.Image = global::FBLAData.Properties.Resources.NewMembersSmall3;
            this.bulkBtn.Location = new System.Drawing.Point(395, 33);
            this.bulkBtn.Margin = new System.Windows.Forms.Padding(0);
            this.bulkBtn.Name = "bulkBtn";
            this.bulkBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.bulkBtn.Size = new System.Drawing.Size(75, 75);
            this.bulkBtn.TabIndex = 36;
            this.bulkBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tTip.SetToolTip(this.bulkBtn, "Add members by importing, bulk add, or single add");
            this.bulkBtn.Click += new System.EventHandler(this.bulkBtn_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonDownColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.viewAllBtn.ButtonOverColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.viewAllBtn.Check = false;
            this.viewAllBtn.CheckColor = System.Drawing.Color.Empty;
            this.viewAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.viewAllBtn.Image = global::FBLAData.Properties.Resources.SearchEditSmall3;
            this.viewAllBtn.Location = new System.Drawing.Point(315, 33);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(0);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.viewAllBtn.Size = new System.Drawing.Size(75, 75);
            this.viewAllBtn.TabIndex = 32;
            this.viewAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tTip.SetToolTip(this.viewAllBtn, "View all members for this chapter");
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // startPanel
            // 
            this.startPanel.AutoScroll = true;
            this.startPanel.Controls.Add(this.startChapterPick);
            this.startPanel.Controls.Add(this.startEditChapterInfo);
            this.startPanel.Controls.Add(this.startSignout);
            this.startPanel.Controls.Add(this.label5);
            this.startPanel.Controls.Add(this.startSettings);
            this.startPanel.Controls.Add(this.startReports);
            this.startPanel.Controls.Add(this.startAddMember);
            this.startPanel.Controls.Add(this.startSearchMember);
            this.startPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startPanel.Location = new System.Drawing.Point(10, 109);
            this.startPanel.Name = "startPanel";
            this.startPanel.Size = new System.Drawing.Size(788, 417);
            this.startPanel.TabIndex = 49;
            this.startPanel.VisibleChanged += new System.EventHandler(this.startPanel_VisibleChanged);
            this.startPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.startPanel_Paint);
            // 
            // startChapterPick
            // 
            this.startChapterPick.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startChapterPick.BackColor = System.Drawing.Color.Transparent;
            this.startChapterPick.ButtonColor = System.Drawing.Color.Transparent;
            this.startChapterPick.ButtonDownColor = System.Drawing.Color.Transparent;
            this.startChapterPick.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startChapterPick.ButtonOverColor = System.Drawing.Color.Transparent;
            this.startChapterPick.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startChapterPick.Check = false;
            this.startChapterPick.CheckColor = System.Drawing.Color.Empty;
            this.startChapterPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startChapterPick.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startChapterPick.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startChapterPick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startChapterPick.Image = global::FBLAData.Properties.Resources.selectChapter1;
            this.startChapterPick.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startChapterPick.Location = new System.Drawing.Point(78, 93);
            this.startChapterPick.Margin = new System.Windows.Forms.Padding(4);
            this.startChapterPick.Name = "startChapterPick";
            this.startChapterPick.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.startChapterPick.Size = new System.Drawing.Size(204, 116);
            this.startChapterPick.TabIndex = 54;
            this.startChapterPick.Text = "Select chapter";
            this.startChapterPick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startChapterPick.Click += new System.EventHandler(this.startChapterPick_Click);
            // 
            // startEditChapterInfo
            // 
            this.startEditChapterInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startEditChapterInfo.BackColor = System.Drawing.Color.Transparent;
            this.startEditChapterInfo.ButtonColor = System.Drawing.Color.Transparent;
            this.startEditChapterInfo.ButtonDownColor = System.Drawing.Color.Transparent;
            this.startEditChapterInfo.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startEditChapterInfo.ButtonOverColor = System.Drawing.Color.Transparent;
            this.startEditChapterInfo.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startEditChapterInfo.Check = false;
            this.startEditChapterInfo.CheckColor = System.Drawing.Color.Empty;
            this.startEditChapterInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startEditChapterInfo.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startEditChapterInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startEditChapterInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startEditChapterInfo.Image = global::FBLAData.Properties.Resources.editChapter2;
            this.startEditChapterInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startEditChapterInfo.Location = new System.Drawing.Point(290, 93);
            this.startEditChapterInfo.Margin = new System.Windows.Forms.Padding(4);
            this.startEditChapterInfo.Name = "startEditChapterInfo";
            this.startEditChapterInfo.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.startEditChapterInfo.Size = new System.Drawing.Size(204, 116);
            this.startEditChapterInfo.TabIndex = 53;
            this.startEditChapterInfo.Text = "Edit chapter info";
            this.startEditChapterInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startEditChapterInfo.Click += new System.EventHandler(this.startEditChapterInfo_Click);
            // 
            // startSignout
            // 
            this.startSignout.AutoSize = true;
            this.startSignout.BackColor = System.Drawing.Color.Transparent;
            this.startSignout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startSignout.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startSignout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startSignout.Location = new System.Drawing.Point(169, 39);
            this.startSignout.Margin = new System.Windows.Forms.Padding(3);
            this.startSignout.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startSignout.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startSignout.Name = "startSignout";
            this.startSignout.Padding = new System.Windows.Forms.Padding(3);
            this.startSignout.Size = new System.Drawing.Size(74, 27);
            this.startSignout.TabIndex = 51;
            this.startSignout.Text = "Sign out";
            this.startSignout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startSignout.Click += new System.EventHandler(this.startSignout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(48, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 50;
            this.label5.Text = "Welcome";
            // 
            // startSettings
            // 
            this.startSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startSettings.BackColor = System.Drawing.Color.Transparent;
            this.startSettings.ButtonColor = System.Drawing.Color.Transparent;
            this.startSettings.ButtonDownColor = System.Drawing.Color.Transparent;
            this.startSettings.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startSettings.ButtonOverColor = System.Drawing.Color.Transparent;
            this.startSettings.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startSettings.Check = false;
            this.startSettings.CheckColor = System.Drawing.Color.Empty;
            this.startSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startSettings.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startSettings.Image = global::FBLAData.Properties.Resources.settings;
            this.startSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startSettings.Location = new System.Drawing.Point(502, 241);
            this.startSettings.Margin = new System.Windows.Forms.Padding(4);
            this.startSettings.Name = "startSettings";
            this.startSettings.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.startSettings.Size = new System.Drawing.Size(204, 116);
            this.startSettings.TabIndex = 49;
            this.startSettings.Text = "Settings";
            this.startSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startSettings.Click += new System.EventHandler(this.startSettings_Click);
            // 
            // startReports
            // 
            this.startReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startReports.BackColor = System.Drawing.Color.Transparent;
            this.startReports.ButtonColor = System.Drawing.Color.Transparent;
            this.startReports.ButtonDownColor = System.Drawing.Color.Transparent;
            this.startReports.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startReports.ButtonOverColor = System.Drawing.Color.Transparent;
            this.startReports.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startReports.Check = false;
            this.startReports.CheckColor = System.Drawing.Color.Empty;
            this.startReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startReports.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startReports.Image = global::FBLAData.Properties.Resources.report2;
            this.startReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startReports.Location = new System.Drawing.Point(290, 241);
            this.startReports.Margin = new System.Windows.Forms.Padding(4);
            this.startReports.Name = "startReports";
            this.startReports.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.startReports.Size = new System.Drawing.Size(204, 116);
            this.startReports.TabIndex = 45;
            this.startReports.Text = "Print reports";
            this.startReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startReports.Click += new System.EventHandler(this.startReports_Click);
            // 
            // startAddMember
            // 
            this.startAddMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startAddMember.BackColor = System.Drawing.Color.Transparent;
            this.startAddMember.ButtonColor = System.Drawing.Color.Transparent;
            this.startAddMember.ButtonDownColor = System.Drawing.Color.Transparent;
            this.startAddMember.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startAddMember.ButtonOverColor = System.Drawing.Color.Transparent;
            this.startAddMember.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startAddMember.Check = false;
            this.startAddMember.CheckColor = System.Drawing.Color.Empty;
            this.startAddMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startAddMember.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startAddMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAddMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startAddMember.Image = global::FBLAData.Properties.Resources.NewMembersSmall3;
            this.startAddMember.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startAddMember.Location = new System.Drawing.Point(78, 241);
            this.startAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.startAddMember.Name = "startAddMember";
            this.startAddMember.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.startAddMember.Size = new System.Drawing.Size(204, 116);
            this.startAddMember.TabIndex = 48;
            this.startAddMember.Text = "Add members";
            this.startAddMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startAddMember.Click += new System.EventHandler(this.startAddMember_Click);
            // 
            // startSearchMember
            // 
            this.startSearchMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startSearchMember.BackColor = System.Drawing.Color.Transparent;
            this.startSearchMember.ButtonColor = System.Drawing.Color.Transparent;
            this.startSearchMember.ButtonDownColor = System.Drawing.Color.Transparent;
            this.startSearchMember.ButtonDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.startSearchMember.ButtonOverColor = System.Drawing.Color.Transparent;
            this.startSearchMember.ButtonOverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.startSearchMember.Check = false;
            this.startSearchMember.CheckColor = System.Drawing.Color.Empty;
            this.startSearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startSearchMember.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startSearchMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSearchMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.startSearchMember.Image = global::FBLAData.Properties.Resources.SearchEditSmall3;
            this.startSearchMember.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startSearchMember.Location = new System.Drawing.Point(502, 93);
            this.startSearchMember.Margin = new System.Windows.Forms.Padding(4);
            this.startSearchMember.Name = "startSearchMember";
            this.startSearchMember.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.startSearchMember.Size = new System.Drawing.Size(204, 116);
            this.startSearchMember.TabIndex = 44;
            this.startSearchMember.Text = "View, search and edit members";
            this.startSearchMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startSearchMember.Click += new System.EventHandler(this.startSearchMember_Click);
            // 
            // moveSelectedBar
            // 
            this.moveSelectedBar.Interval = 1;
            this.moveSelectedBar.Tick += new System.EventHandler(this.moveSelectedBar_Tick);
            // 
            // chapterSelectPanel
            // 
            this.chapterSelectPanel.AutoScroll = true;
            this.chapterSelectPanel.Controls.Add(this.label6);
            this.chapterSelectPanel.Controls.Add(this.panel2);
            this.chapterSelectPanel.Controls.Add(this.creatChapterSchoolbox);
            this.chapterSelectPanel.Controls.Add(this.createChapterBtn);
            this.chapterSelectPanel.Controls.Add(this.customLabelButton2);
            this.chapterSelectPanel.Controls.Add(this.label4);
            this.chapterSelectPanel.Controls.Add(this.panel1);
            this.chapterSelectPanel.Controls.Add(this.newChapterNumberBox);
            this.chapterSelectPanel.Controls.Add(this.label2);
            this.chapterSelectPanel.Controls.Add(this.label3);
            this.chapterSelectPanel.Controls.Add(this.viewAllChaptersBtn);
            this.chapterSelectPanel.Controls.Add(this.setCurrentChapter);
            this.chapterSelectPanel.Controls.Add(this.panel6);
            this.chapterSelectPanel.Controls.Add(this.chapterSelectBox);
            this.chapterSelectPanel.Controls.Add(this.label1);
            this.chapterSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chapterSelectPanel.Location = new System.Drawing.Point(10, 0);
            this.chapterSelectPanel.Name = "chapterSelectPanel";
            this.chapterSelectPanel.Size = new System.Drawing.Size(788, 526);
            this.chapterSelectPanel.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label6.Location = new System.Drawing.Point(181, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "School name";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel2.Location = new System.Drawing.Point(185, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 1);
            this.panel2.TabIndex = 52;
            this.panel2.Tag = "border";
            // 
            // creatChapterSchoolbox
            // 
            this.creatChapterSchoolbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creatChapterSchoolbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.creatChapterSchoolbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.creatChapterSchoolbox.BackColor = System.Drawing.Color.White;
            this.creatChapterSchoolbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.creatChapterSchoolbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.creatChapterSchoolbox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.creatChapterSchoolbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.creatChapterSchoolbox.Location = new System.Drawing.Point(185, 388);
            this.creatChapterSchoolbox.Name = "creatChapterSchoolbox";
            this.creatChapterSchoolbox.Size = new System.Drawing.Size(411, 22);
            this.creatChapterSchoolbox.TabIndex = 51;
            // 
            // createChapterBtn
            // 
            this.createChapterBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createChapterBtn.AutoSize = true;
            this.createChapterBtn.BackColor = System.Drawing.Color.Transparent;
            this.createChapterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createChapterBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.createChapterBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.createChapterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.createChapterBtn.Location = new System.Drawing.Point(599, 387);
            this.createChapterBtn.Margin = new System.Windows.Forms.Padding(3);
            this.createChapterBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.createChapterBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.createChapterBtn.Name = "createChapterBtn";
            this.createChapterBtn.Padding = new System.Windows.Forms.Padding(3);
            this.createChapterBtn.Size = new System.Drawing.Size(55, 25);
            this.createChapterBtn.TabIndex = 50;
            this.createChapterBtn.Text = "Create";
            this.createChapterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createChapterBtn.Click += new System.EventHandler(this.createChapterBtn_Click);
            // 
            // customLabelButton2
            // 
            this.customLabelButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customLabelButton2.AutoSize = true;
            this.customLabelButton2.BackColor = System.Drawing.Color.Transparent;
            this.customLabelButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customLabelButton2.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.customLabelButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customLabelButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.customLabelButton2.Location = new System.Drawing.Point(525, 300);
            this.customLabelButton2.Margin = new System.Windows.Forms.Padding(3);
            this.customLabelButton2.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.customLabelButton2.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.customLabelButton2.Name = "customLabelButton2";
            this.customLabelButton2.Padding = new System.Windows.Forms.Padding(3);
            this.customLabelButton2.Size = new System.Drawing.Size(71, 25);
            this.customLabelButton2.TabIndex = 49;
            this.customLabelButton2.Text = "Generate";
            this.customLabelButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(180, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "New chapter number";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(184, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 1);
            this.panel1.TabIndex = 47;
            this.panel1.Tag = "border";
            // 
            // newChapterNumberBox
            // 
            this.newChapterNumberBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newChapterNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.newChapterNumberBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.newChapterNumberBox.BackColor = System.Drawing.Color.White;
            this.newChapterNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newChapterNumberBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.newChapterNumberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.newChapterNumberBox.Location = new System.Drawing.Point(184, 325);
            this.newChapterNumberBox.Name = "newChapterNumberBox";
            this.newChapterNumberBox.Size = new System.Drawing.Size(411, 22);
            this.newChapterNumberBox.TabIndex = 46;
            this.newChapterNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newChapterNumberBox_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(179, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "Create new Chapter";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(179, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 44;
            this.label3.Text = "Select Chapter";
            // 
            // viewAllChaptersBtn
            // 
            this.viewAllChaptersBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAllChaptersBtn.AutoSize = true;
            this.viewAllChaptersBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewAllChaptersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewAllChaptersBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.viewAllChaptersBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.viewAllChaptersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.viewAllChaptersBtn.Location = new System.Drawing.Point(339, 105);
            this.viewAllChaptersBtn.Margin = new System.Windows.Forms.Padding(3);
            this.viewAllChaptersBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.viewAllChaptersBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.viewAllChaptersBtn.Name = "viewAllChaptersBtn";
            this.viewAllChaptersBtn.Padding = new System.Windows.Forms.Padding(3);
            this.viewAllChaptersBtn.Size = new System.Drawing.Size(61, 25);
            this.viewAllChaptersBtn.TabIndex = 43;
            this.viewAllChaptersBtn.Text = "View all";
            this.viewAllChaptersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewAllChaptersBtn.Click += new System.EventHandler(this.viewAllChaptersBtn_Click);
            // 
            // setCurrentChapter
            // 
            this.setCurrentChapter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setCurrentChapter.AutoSize = true;
            this.setCurrentChapter.BackColor = System.Drawing.Color.Transparent;
            this.setCurrentChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.setCurrentChapter.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.setCurrentChapter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.setCurrentChapter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.setCurrentChapter.Location = new System.Drawing.Point(599, 172);
            this.setCurrentChapter.Margin = new System.Windows.Forms.Padding(3);
            this.setCurrentChapter.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.setCurrentChapter.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.setCurrentChapter.Name = "setCurrentChapter";
            this.setCurrentChapter.Padding = new System.Windows.Forms.Padding(3);
            this.setCurrentChapter.Size = new System.Drawing.Size(33, 25);
            this.setCurrentChapter.TabIndex = 42;
            this.setCurrentChapter.Text = "Go";
            this.setCurrentChapter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.setCurrentChapter.Click += new System.EventHandler(this.setCurrentChapter_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel6.Location = new System.Drawing.Point(184, 196);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(411, 1);
            this.panel6.TabIndex = 38;
            this.panel6.Tag = "border";
            // 
            // chapterSelectBox
            // 
            this.chapterSelectBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chapterSelectBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterSelectBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterSelectBox.BackColor = System.Drawing.Color.White;
            this.chapterSelectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterSelectBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chapterSelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.chapterSelectBox.Location = new System.Drawing.Point(184, 172);
            this.chapterSelectBox.Name = "chapterSelectBox";
            this.chapterSelectBox.Size = new System.Drawing.Size(411, 22);
            this.chapterSelectBox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(181, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Start typing chapter number or school name";
            // 
            // tTip
            // 
            this.tTip.AutoPopDelay = 5000;
            this.tTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.tTip.ForeColor = System.Drawing.Color.White;
            this.tTip.InitialDelay = 0;
            this.tTip.IsBalloon = true;
            this.tTip.ReshowDelay = 0;
            // 
            // checkForCompletedSaved
            // 
            this.checkForCompletedSaved.Interval = 1;
            this.checkForCompletedSaved.Tick += new System.EventHandler(this.checkForCompletedSaved_Tick);
            // 
            // lockScreen
            // 
            this.lockScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lockScreen.Controls.Add(this.userNameLabel);
            this.lockScreen.Controls.Add(this.label8);
            this.lockScreen.Controls.Add(this.customLabelButton1);
            this.lockScreen.Controls.Add(this.label7);
            this.lockScreen.Controls.Add(this.panel3);
            this.lockScreen.Controls.Add(this.passBox);
            this.lockScreen.Controls.Add(this.loginBtn);
            this.lockScreen.Location = new System.Drawing.Point(-7, -25);
            this.lockScreen.Name = "lockScreen";
            this.lockScreen.Size = new System.Drawing.Size(821, 560);
            this.lockScreen.TabIndex = 56;
            this.lockScreen.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoEllipsis = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.userNameLabel.Location = new System.Drawing.Point(28, 173);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(770, 49);
            this.userNameLabel.TabIndex = 46;
            this.userNameLabel.Text = "[Name] is signed in";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label8.Location = new System.Drawing.Point(39, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 30);
            this.label8.TabIndex = 45;
            this.label8.Text = "Locked";
            // 
            // customLabelButton1
            // 
            this.customLabelButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customLabelButton1.AutoSize = true;
            this.customLabelButton1.BackColor = System.Drawing.Color.Transparent;
            this.customLabelButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customLabelButton1.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.customLabelButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabelButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.customLabelButton1.Location = new System.Drawing.Point(606, 510);
            this.customLabelButton1.Margin = new System.Windows.Forms.Padding(3);
            this.customLabelButton1.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.customLabelButton1.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.customLabelButton1.Name = "customLabelButton1";
            this.customLabelButton1.Padding = new System.Windows.Forms.Padding(3);
            this.customLabelButton1.Size = new System.Drawing.Size(192, 27);
            this.customLabelButton1.TabIndex = 44;
            this.customLabelButton1.Text = "Sign in as a different user";
            this.customLabelButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabelButton1.Click += new System.EventHandler(this.customLabelButton1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(195, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel3.Location = new System.Drawing.Point(199, 287);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 1);
            this.panel3.TabIndex = 42;
            this.panel3.Tag = "border";
            // 
            // passBox
            // 
            this.passBox.AcceptsReturn = true;
            this.passBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.passBox.Location = new System.Drawing.Point(199, 263);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(411, 22);
            this.passBox.TabIndex = 41;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBtn.AutoSize = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loginBtn.Location = new System.Drawing.Point(556, 291);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3);
            this.loginBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.loginBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Padding = new System.Windows.Forms.Padding(3);
            this.loginBtn.Size = new System.Drawing.Size(64, 27);
            this.loginBtn.TabIndex = 40;
            this.loginBtn.Text = "Unlock";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkLogin
            // 
            this.checkLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkLogin_DoWork);
            this.checkLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkLogin_RunWorkerCompleted);
            // 
            // createChapter
            // 
            this.createChapter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.createChapter_DoWork);
            this.createChapter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.createChapter_RunWorkerCompleted);
            // 
            // viewAllMembers
            // 
            this.viewAllMembers.BackColor = System.Drawing.Color.White;
            this.viewAllMembers.dataSet = null;
            this.viewAllMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllMembers.Location = new System.Drawing.Point(10, 0);
            this.viewAllMembers.Name = "viewAllMembers";
            this.viewAllMembers.Size = new System.Drawing.Size(788, 526);
            this.viewAllMembers.TabIndex = 52;
            this.viewAllMembers.thisWindow = null;
            this.viewAllMembers.Visible = false;
            // 
            // loadingItem1
            // 
            this.loadingItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingItem1.Image = ((System.Drawing.Image)(resources.GetObject("loadingItem1.Image")));
            this.loadingItem1.Location = new System.Drawing.Point(10, 109);
            this.loadingItem1.Name = "loadingItem1";
            this.loadingItem1.Size = new System.Drawing.Size(788, 417);
            this.loadingItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingItem1.TabIndex = 54;
            this.loadingItem1.TabStop = false;
            this.loadingItem1.Visible = false;
            // 
            // editChapter
            // 
            this.editChapter.AutoScroll = true;
            this.editChapter.BackColor = System.Drawing.Color.White;
            this.editChapter.chapterTable = null;
            this.editChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editChapter.Location = new System.Drawing.Point(10, 0);
            this.editChapter.Name = "editChapter";
            this.editChapter.Size = new System.Drawing.Size(788, 526);
            this.editChapter.TabIndex = 50;
            this.editChapter.thisWindow = null;
            // 
            // addMem
            // 
            this.addMem.AutoScroll = true;
            this.addMem.BackColor = System.Drawing.Color.White;
            this.addMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMem.Location = new System.Drawing.Point(10, 0);
            this.addMem.Name = "addMem";
            this.addMem.Size = new System.Drawing.Size(788, 526);
            this.addMem.TabIndex = 55;
            this.addMem.thisWindow = null;
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 526);
            this.Controls.Add(this.loadingItem1);
            this.Controls.Add(this.lockScreen);
            this.Controls.Add(this.startPanel);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.viewAllMembers);
            this.Controls.Add(this.chapterSelectPanel);
            this.Controls.Add(this.editChapter);
            this.Controls.Add(this.addMem);
            this.Name = "DataWindow";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataWindow_FormClosed);
            this.Load += new System.EventHandler(this.DataWindow_Load);
            this.ResizeBegin += new System.EventHandler(this.DataWindow_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.DataWindow_ResizeEnd);
            this.VisibleChanged += new System.EventHandler(this.DataWindow_VisibleChanged);
            this.Move += new System.EventHandler(this.DataWindow_Move);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.startPanel.ResumeLayout(false);
            this.startPanel.PerformLayout();
            this.chapterSelectPanel.ResumeLayout(false);
            this.chapterSelectPanel.PerformLayout();
            this.lockScreen.ResumeLayout(false);
            this.lockScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public CustomFlatButton.CustomFlatButton settingsBtn;
        public CustomFlatButton.CustomFlatButton reportBtn;
        public CustomFlatButton.CustomFlatButton bulkBtn;
        public CustomFlatButton.CustomFlatButton viewAllBtn;
        private CustomLabelButton signOutBtn;
        public System.Windows.Forms.Panel selectedBar;
        private System.Windows.Forms.Panel startPanel;
        public CustomFlatButton.CustomFlatButton startSettings;
        public CustomFlatButton.CustomFlatButton startReports;
        public CustomFlatButton.CustomFlatButton startAddMember;
        public CustomFlatButton.CustomFlatButton startSearchMember;
        private CustomLabelButton startSignout;
        private System.Windows.Forms.Label label5;
        private editChapter editChapter;
        private System.Windows.Forms.Timer moveSelectedBar;
        public CustomFlatButton.CustomFlatButton editChapterBtn;
        public CustomFlatButton.CustomFlatButton selectChapterBtn;
        private CustomLabelButton chapter;
        private System.Windows.Forms.Panel chapterSelectPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox chapterSelectBox;
        private System.Windows.Forms.Label label1;
        private CustomLabelButton setCurrentChapter;
        private CustomLabelButton viewAllChaptersBtn;
        private CustomLabelButton createChapterBtn;
        private CustomLabelButton customLabelButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox newChapterNumberBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox creatChapterSchoolbox;
        public CustomFlatButton.CustomFlatButton startChapterPick;
        public CustomFlatButton.CustomFlatButton startEditChapterInfo;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Timer checkForCompletedSaved;
        public viewAll viewAllMembers;
        private addMembers addMem;
        private System.Windows.Forms.Panel lockScreen;
        private CustomLabelButton customLabelButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox passBox;
        private CustomLabelButton loginBtn;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker checkLogin;
        private System.ComponentModel.BackgroundWorker createChapter;
        public loadingItem loadingItem1;
        private CustomLabelButton lockBtn;
    }
}