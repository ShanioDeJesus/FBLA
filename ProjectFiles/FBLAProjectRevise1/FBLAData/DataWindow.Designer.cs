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
            this.moveSelectedBar = new System.Windows.Forms.Timer(this.components);
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
            this.leftBorder = new System.Windows.Forms.Panel();
            this.topleftresize = new System.Windows.Forms.Panel();
            this.bottomleftresize = new System.Windows.Forms.Panel();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.toprightresize = new System.Windows.Forms.Panel();
            this.bottomrightresize = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.menuBtn = new CustomFlatButton();
            this.minBtn = new CustomFlatButton();
            this.maxrestoreBtn = new CustomFlatButton();
            this.closeBtn = new CustomFlatButton();
            this.topBorder = new System.Windows.Forms.Panel();
            this.viewChapterLabel = new System.Windows.Forms.Label();
            this.windowfooter = new System.Windows.Forms.Panel();
            this.loadingItem1 = new FBLAData.loadingItem();
            this.settingsTab = new FBLAData.settings();
            this.reportsTab = new FBLAData.reports();
            this.viewAllMembers = new FBLAData.viewAll();
            this.addMem = new FBLAData.addMembers();
            this.lockScreen.SuspendLayout();
            this.leftBorder.SuspendLayout();
            this.rightBorder.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.windowfooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // moveSelectedBar
            // 
            this.moveSelectedBar.Interval = 1;
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
            this.lockScreen.Controls.Add(this.userNameLabel);
            this.lockScreen.Controls.Add(this.label8);
            this.lockScreen.Controls.Add(this.customLabelButton1);
            this.lockScreen.Controls.Add(this.label7);
            this.lockScreen.Controls.Add(this.panel3);
            this.lockScreen.Controls.Add(this.passBox);
            this.lockScreen.Controls.Add(this.loginBtn);
            this.lockScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockScreen.Location = new System.Drawing.Point(0, 0);
            this.lockScreen.Name = "lockScreen";
            this.lockScreen.Size = new System.Drawing.Size(953, 615);
            this.lockScreen.TabIndex = 56;
            this.lockScreen.Visible = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel.AutoEllipsis = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.userNameLabel.ForeColor = System.Drawing.Color.DimGray;
            this.userNameLabel.Location = new System.Drawing.Point(28, 200);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(902, 49);
            this.userNameLabel.TabIndex = 46;
            this.userNameLabel.Text = "[Name] is signed in";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label8.Location = new System.Drawing.Point(28, 11);
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
            this.customLabelButton1.ForeColor = System.Drawing.Color.DimGray;
            this.customLabelButton1.Location = new System.Drawing.Point(738, 565);
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
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(261, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 43;
            this.label7.Text = "Password";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel3.Location = new System.Drawing.Point(265, 314);
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
            this.passBox.ForeColor = System.Drawing.Color.DimGray;
            this.passBox.Location = new System.Drawing.Point(265, 290);
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
            this.loginBtn.ForeColor = System.Drawing.Color.DimGray;
            this.loginBtn.Location = new System.Drawing.Point(622, 318);
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
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.leftBorder.Controls.Add(this.topleftresize);
            this.leftBorder.Controls.Add(this.bottomleftresize);
            this.leftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.leftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorder.Location = new System.Drawing.Point(0, 0);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(5, 615);
            this.leftBorder.TabIndex = 58;
            // 
            // topleftresize
            // 
            this.topleftresize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.topleftresize.Location = new System.Drawing.Point(-2, -1);
            this.topleftresize.Name = "topleftresize";
            this.topleftresize.Size = new System.Drawing.Size(10, 16);
            this.topleftresize.TabIndex = 56;
            // 
            // bottomleftresize
            // 
            this.bottomleftresize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bottomleftresize.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.bottomleftresize.Location = new System.Drawing.Point(-2, 602);
            this.bottomleftresize.Name = "bottomleftresize";
            this.bottomleftresize.Size = new System.Drawing.Size(10, 16);
            this.bottomleftresize.TabIndex = 0;
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.rightBorder.Controls.Add(this.toprightresize);
            this.rightBorder.Controls.Add(this.bottomrightresize);
            this.rightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(948, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(5, 615);
            this.rightBorder.TabIndex = 59;
            // 
            // toprightresize
            // 
            this.toprightresize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toprightresize.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.toprightresize.Location = new System.Drawing.Point(-3, -3);
            this.toprightresize.Name = "toprightresize";
            this.toprightresize.Size = new System.Drawing.Size(10, 16);
            this.toprightresize.TabIndex = 58;
            // 
            // bottomrightresize
            // 
            this.bottomrightresize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomrightresize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.bottomrightresize.Location = new System.Drawing.Point(-3, 602);
            this.bottomrightresize.Name = "bottomrightresize";
            this.bottomrightresize.Size = new System.Drawing.Size(10, 16);
            this.bottomrightresize.TabIndex = 57;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.bottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(5, 610);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(943, 5);
            this.bottomBorder.TabIndex = 60;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.titleBar.Controls.Add(this.menuBtn);
            this.titleBar.Controls.Add(this.minBtn);
            this.titleBar.Controls.Add(this.maxrestoreBtn);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.topBorder);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(5, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(943, 54);
            this.titleBar.TabIndex = 62;
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.Transparent;
            this.menuBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.menuBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.menuBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.menuBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.menuBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.menuBtn.Check = false;
            this.menuBtn.CheckColor = System.Drawing.Color.Empty;
            this.menuBtn.CheckTextColor = System.Drawing.Color.Empty;
            this.menuBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.menuBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.menuBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.menuBtn.Image = global::FBLAData.Properties.Resources.menuBtn22;
            this.menuBtn.Location = new System.Drawing.Point(0, 5);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(0);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.menuBtn.Size = new System.Drawing.Size(48, 49);
            this.menuBtn.TabIndex = 64;
            this.menuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minBtn.BackColor = System.Drawing.Color.Transparent;
            this.minBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.minBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.minBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.minBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.minBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.minBtn.Check = false;
            this.minBtn.CheckColor = System.Drawing.Color.Empty;
            this.minBtn.CheckTextColor = System.Drawing.Color.Empty;
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.minBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.minBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.minBtn.Image = global::FBLAData.Properties.Resources.minimize;
            this.minBtn.Location = new System.Drawing.Point(799, 5);
            this.minBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.minBtn.Size = new System.Drawing.Size(48, 49);
            this.minBtn.TabIndex = 55;
            this.minBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // maxrestoreBtn
            // 
            this.maxrestoreBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxrestoreBtn.BackColor = System.Drawing.Color.Transparent;
            this.maxrestoreBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.maxrestoreBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.maxrestoreBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.maxrestoreBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.maxrestoreBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.maxrestoreBtn.Check = false;
            this.maxrestoreBtn.CheckColor = System.Drawing.Color.Empty;
            this.maxrestoreBtn.CheckTextColor = System.Drawing.Color.Empty;
            this.maxrestoreBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.maxrestoreBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.maxrestoreBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxrestoreBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.maxrestoreBtn.Image = global::FBLAData.Properties.Resources.max1;
            this.maxrestoreBtn.Location = new System.Drawing.Point(847, 5);
            this.maxrestoreBtn.Margin = new System.Windows.Forms.Padding(0);
            this.maxrestoreBtn.Name = "maxrestoreBtn";
            this.maxrestoreBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.maxrestoreBtn.Size = new System.Drawing.Size(48, 49);
            this.maxrestoreBtn.TabIndex = 53;
            this.maxrestoreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.closeBtn.ButtonDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(103)))), ((int)(((byte)(119)))));
            this.closeBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.closeBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.closeBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.closeBtn.Check = false;
            this.closeBtn.CheckColor = System.Drawing.Color.Empty;
            this.closeBtn.CheckTextColor = System.Drawing.Color.Empty;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.closeBtn.Image = global::FBLAData.Properties.Resources.close;
            this.closeBtn.Location = new System.Drawing.Point(895, 5);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.closeBtn.Size = new System.Drawing.Size(48, 49);
            this.closeBtn.TabIndex = 54;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.topBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.topBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorder.Location = new System.Drawing.Point(0, 0);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(943, 5);
            this.topBorder.TabIndex = 63;
            // 
            // viewChapterLabel
            // 
            this.viewChapterLabel.AutoEllipsis = true;
            this.viewChapterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewChapterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewChapterLabel.ForeColor = System.Drawing.Color.White;
            this.viewChapterLabel.Location = new System.Drawing.Point(0, 0);
            this.viewChapterLabel.Name = "viewChapterLabel";
            this.viewChapterLabel.Size = new System.Drawing.Size(943, 30);
            this.viewChapterLabel.TabIndex = 65;
            this.viewChapterLabel.Text = "Your currently viewing all members";
            this.viewChapterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windowfooter
            // 
            this.windowfooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.windowfooter.Controls.Add(this.viewChapterLabel);
            this.windowfooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowfooter.Location = new System.Drawing.Point(5, 580);
            this.windowfooter.Name = "windowfooter";
            this.windowfooter.Size = new System.Drawing.Size(943, 30);
            this.windowfooter.TabIndex = 63;
            // 
            // loadingItem1
            // 
            this.loadingItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingItem1.Image = ((System.Drawing.Image)(resources.GetObject("loadingItem1.Image")));
            this.loadingItem1.Location = new System.Drawing.Point(5, 54);
            this.loadingItem1.Name = "loadingItem1";
            this.loadingItem1.Size = new System.Drawing.Size(943, 526);
            this.loadingItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingItem1.TabIndex = 54;
            this.loadingItem1.TabStop = false;
            this.loadingItem1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loadingItem1.Visible = false;
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.White;
            this.settingsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTab.Location = new System.Drawing.Point(5, 54);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(5);
            this.settingsTab.Size = new System.Drawing.Size(943, 526);
            this.settingsTab.TabIndex = 65;
            // 
            // reportsTab
            // 
            this.reportsTab.BackColor = System.Drawing.Color.White;
            this.reportsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsTab.Location = new System.Drawing.Point(5, 54);
            this.reportsTab.Name = "reportsTab";
            this.reportsTab.Padding = new System.Windows.Forms.Padding(5);
            this.reportsTab.reportCurrentChapter = 0;
            this.reportsTab.Size = new System.Drawing.Size(943, 526);
            this.reportsTab.TabIndex = 64;
            this.reportsTab.thisWindow = null;
            // 
            // viewAllMembers
            // 
            this.viewAllMembers.BackColor = System.Drawing.Color.White;
            this.viewAllMembers.dataSet = null;
            this.viewAllMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllMembers.Location = new System.Drawing.Point(0, 0);
            this.viewAllMembers.Name = "viewAllMembers";
            this.viewAllMembers.Padding = new System.Windows.Forms.Padding(5);
            this.viewAllMembers.Size = new System.Drawing.Size(953, 615);
            this.viewAllMembers.TabIndex = 52;
            this.viewAllMembers.thisWindow = null;
            this.viewAllMembers.Visible = false;
            // 
            // addMem
            // 
            this.addMem.AutoScroll = true;
            this.addMem.BackColor = System.Drawing.Color.White;
            this.addMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addMem.Location = new System.Drawing.Point(0, 0);
            this.addMem.Name = "addMem";
            this.addMem.Size = new System.Drawing.Size(953, 615);
            this.addMem.TabIndex = 55;
            this.addMem.thisWindow = null;
            // 
            // DataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 615);
            this.Controls.Add(this.loadingItem1);
            this.Controls.Add(this.settingsTab);
            this.Controls.Add(this.reportsTab);
            this.Controls.Add(this.windowfooter);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.viewAllMembers);
            this.Controls.Add(this.addMem);
            this.Controls.Add(this.lockScreen);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(680, 413);
            this.Name = "DataWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataWindow_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataWindow_FormClosed);
            this.Load += new System.EventHandler(this.DataWindow_Load);
            this.ResizeBegin += new System.EventHandler(this.DataWindow_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.DataWindow_ResizeEnd);
            this.VisibleChanged += new System.EventHandler(this.DataWindow_VisibleChanged);
            this.Move += new System.EventHandler(this.DataWindow_Move);
            this.lockScreen.ResumeLayout(false);
            this.lockScreen.PerformLayout();
            this.leftBorder.ResumeLayout(false);
            this.rightBorder.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.windowfooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer moveSelectedBar;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Timer checkForCompletedSaved;
        private CustomLabelButton customLabelButton1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private CustomLabelButton loginBtn;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker checkLogin;
        public loadingItem loadingItem1;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel bottomBorder;
        public viewAll viewAllMembers;
        public CustomFlatButton maxrestoreBtn;
        public CustomFlatButton closeBtn;
        public CustomFlatButton minBtn;
        private System.Windows.Forms.Panel topleftresize;
        private System.Windows.Forms.Panel bottomleftresize;
        private System.Windows.Forms.Panel toprightresize;
        private System.Windows.Forms.Panel bottomrightresize;
        private System.Windows.Forms.Panel topBorder;
        public CustomFlatButton menuBtn;
        public addMembers addMem;
        public System.Windows.Forms.TextBox passBox;
        public System.Windows.Forms.Panel lockScreen;
        public System.Windows.Forms.Label userNameLabel;
        public System.Windows.Forms.Panel titleBar;
        public System.Windows.Forms.Panel windowfooter;
        public System.Windows.Forms.Label viewChapterLabel;
        public reports reportsTab;
        public settings settingsTab;
    }
}