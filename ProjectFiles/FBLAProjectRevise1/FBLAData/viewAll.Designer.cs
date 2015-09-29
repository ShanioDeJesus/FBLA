namespace FBLAData
{
    partial class viewAll
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAll));
            this.exactMatchCheck = new System.Windows.Forms.CheckBox();
            this.searchByBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.totalMembersLabel = new System.Windows.Forms.Label();
            this.membersOwingLabel = new System.Windows.Forms.Label();
            this.totalAmtLabel = new System.Windows.Forms.Label();
            this.activeMembersLabel = new System.Windows.Forms.Label();
            this.nonActiveMembersLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewCheckBox = new System.Windows.Forms.CheckedListBox();
            this.orderByBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sortByBox = new System.Windows.Forms.ComboBox();
            this.editMemberPanel = new System.Windows.Forms.Panel();
            this.customLabelButton1 = new CustomLabelButton();
            this.deleteBtn = new CustomLabelButton();
            this.resizeMmberInfoLine = new System.Windows.Forms.Panel();
            this.resizeMemberInfo = new System.Windows.Forms.Panel();
            this.refreshDBBtn = new CustomLabelButton();
            this.saveChangesBtn = new CustomLabelButton();
            this.searchList = new System.ComponentModel.BackgroundWorker();
            this.loaddatainfo = new System.ComponentModel.BackgroundWorker();
            this.loadDataTable = new System.ComponentModel.BackgroundWorker();
            this.membersList = new System.Windows.Forms.DataGridView();
            this.saveChanges = new System.ComponentModel.BackgroundWorker();
            this.contentHolder = new System.Windows.Forms.Panel();
            this.loadingItem1 = new FBLAData.loadingItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.editMemberPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersList)).BeginInit();
            this.contentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // exactMatchCheck
            // 
            this.exactMatchCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exactMatchCheck.AutoSize = true;
            this.exactMatchCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exactMatchCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.exactMatchCheck.Location = new System.Drawing.Point(134, 156);
            this.exactMatchCheck.Name = "exactMatchCheck";
            this.exactMatchCheck.Size = new System.Drawing.Size(96, 21);
            this.exactMatchCheck.TabIndex = 43;
            this.exactMatchCheck.Text = "Exact match";
            this.exactMatchCheck.UseVisualStyleBackColor = true;
            // 
            // searchByBox
            // 
            this.searchByBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchByBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.searchByBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.searchByBox.FormattingEnabled = true;
            this.searchByBox.Items.AddRange(new object[] {
            "Membership ID",
            "First Name",
            "Last Name",
            "School",
            "Grade",
            "State",
            "Email",
            "Year Joined",
            "Active",
            "Amount Owed"});
            this.searchByBox.Location = new System.Drawing.Point(12, 156);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(116, 21);
            this.searchByBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchBox.BackColor = System.Drawing.Color.White;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.searchBox.Location = new System.Drawing.Point(12, 130);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(218, 18);
            this.searchBox.TabIndex = 37;
            this.searchBox.Text = "Type search and hit Enter";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 1);
            this.panel1.TabIndex = 38;
            this.panel1.Tag = "border";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.totalMembersLabel);
            this.flowLayoutPanel1.Controls.Add(this.membersOwingLabel);
            this.flowLayoutPanel1.Controls.Add(this.totalAmtLabel);
            this.flowLayoutPanel1.Controls.Add(this.activeMembersLabel);
            this.flowLayoutPanel1.Controls.Add(this.nonActiveMembersLabel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(248, 590);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 72);
            this.flowLayoutPanel1.TabIndex = 25;
            // 
            // totalMembersLabel
            // 
            this.totalMembersLabel.AutoEllipsis = true;
            this.totalMembersLabel.AutoSize = true;
            this.totalMembersLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalMembersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.totalMembersLabel.Location = new System.Drawing.Point(3, 0);
            this.totalMembersLabel.Name = "totalMembersLabel";
            this.totalMembersLabel.Padding = new System.Windows.Forms.Padding(6, 5, 0, 10);
            this.totalMembersLabel.Size = new System.Drawing.Size(85, 36);
            this.totalMembersLabel.TabIndex = 22;
            this.totalMembersLabel.Text = "Members:";
            // 
            // membersOwingLabel
            // 
            this.membersOwingLabel.AutoEllipsis = true;
            this.membersOwingLabel.AutoSize = true;
            this.membersOwingLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.membersOwingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersOwingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.membersOwingLabel.Location = new System.Drawing.Point(94, 0);
            this.membersOwingLabel.Name = "membersOwingLabel";
            this.membersOwingLabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 10);
            this.membersOwingLabel.Size = new System.Drawing.Size(136, 36);
            this.membersOwingLabel.TabIndex = 23;
            this.membersOwingLabel.Text = "Members owing:";
            // 
            // totalAmtLabel
            // 
            this.totalAmtLabel.AutoEllipsis = true;
            this.totalAmtLabel.AutoSize = true;
            this.totalAmtLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.totalAmtLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.totalAmtLabel.Location = new System.Drawing.Point(236, 0);
            this.totalAmtLabel.Name = "totalAmtLabel";
            this.totalAmtLabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 10);
            this.totalAmtLabel.Size = new System.Drawing.Size(155, 36);
            this.totalAmtLabel.TabIndex = 24;
            this.totalAmtLabel.Text = "Total amount owed:";
            // 
            // activeMembersLabel
            // 
            this.activeMembersLabel.AutoEllipsis = true;
            this.activeMembersLabel.AutoSize = true;
            this.activeMembersLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.activeMembersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeMembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.activeMembersLabel.Location = new System.Drawing.Point(397, 0);
            this.activeMembersLabel.Name = "activeMembersLabel";
            this.activeMembersLabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 10);
            this.activeMembersLabel.Size = new System.Drawing.Size(135, 36);
            this.activeMembersLabel.TabIndex = 25;
            this.activeMembersLabel.Text = "Active members:";
            // 
            // nonActiveMembersLabel
            // 
            this.nonActiveMembersLabel.AutoEllipsis = true;
            this.nonActiveMembersLabel.AutoSize = true;
            this.nonActiveMembersLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nonActiveMembersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonActiveMembersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.nonActiveMembersLabel.Location = new System.Drawing.Point(3, 36);
            this.nonActiveMembersLabel.Name = "nonActiveMembersLabel";
            this.nonActiveMembersLabel.Padding = new System.Windows.Forms.Padding(10, 5, 0, 10);
            this.nonActiveMembersLabel.Size = new System.Drawing.Size(167, 36);
            this.nonActiveMembersLabel.TabIndex = 26;
            this.nonActiveMembersLabel.Text = "Non active members:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(5, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "in";
            // 
            // viewCheckBox
            // 
            this.viewCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewCheckBox.BackColor = System.Drawing.Color.White;
            this.viewCheckBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.viewCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.viewCheckBox.FormattingEnabled = true;
            this.viewCheckBox.Location = new System.Drawing.Point(12, 223);
            this.viewCheckBox.Name = "viewCheckBox";
            this.viewCheckBox.Size = new System.Drawing.Size(218, 340);
            this.viewCheckBox.TabIndex = 66;
            this.viewCheckBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.viewCheckBox_ItemCheck);
            // 
            // orderByBox
            // 
            this.orderByBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderByBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.orderByBox.FormattingEnabled = true;
            this.orderByBox.Items.AddRange(new object[] {
            "Ascending order",
            "Descending order"});
            this.orderByBox.Location = new System.Drawing.Point(9, 632);
            this.orderByBox.Name = "orderByBox";
            this.orderByBox.Size = new System.Drawing.Size(221, 23);
            this.orderByBox.TabIndex = 42;
            this.orderByBox.SelectedIndexChanged += new System.EventHandler(this.orderByBox_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label25.Location = new System.Drawing.Point(9, 201);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 19);
            this.label25.TabIndex = 67;
            this.label25.Text = "View";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(7, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Sort by";
            // 
            // sortByBox
            // 
            this.sortByBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortByBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortByBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.sortByBox.FormattingEnabled = true;
            this.sortByBox.Items.AddRange(new object[] {
            "Membership ID",
            "First Name",
            "Last Name",
            "School",
            "Grade",
            "State",
            "Email",
            "Year Joined",
            "Active",
            "Amount Owed"});
            this.sortByBox.Location = new System.Drawing.Point(9, 589);
            this.sortByBox.Name = "sortByBox";
            this.sortByBox.Size = new System.Drawing.Size(221, 23);
            this.sortByBox.TabIndex = 40;
            this.sortByBox.SelectedIndexChanged += new System.EventHandler(this.sortByBox_SelectedIndexChanged);
            // 
            // editMemberPanel
            // 
            this.editMemberPanel.AutoScroll = true;
            this.editMemberPanel.Controls.Add(this.customLabelButton1);
            this.editMemberPanel.Controls.Add(this.deleteBtn);
            this.editMemberPanel.Controls.Add(this.resizeMmberInfoLine);
            this.editMemberPanel.Controls.Add(this.resizeMemberInfo);
            this.editMemberPanel.Controls.Add(this.refreshDBBtn);
            this.editMemberPanel.Controls.Add(this.saveChangesBtn);
            this.editMemberPanel.Controls.Add(this.viewCheckBox);
            this.editMemberPanel.Controls.Add(this.exactMatchCheck);
            this.editMemberPanel.Controls.Add(this.orderByBox);
            this.editMemberPanel.Controls.Add(this.searchByBox);
            this.editMemberPanel.Controls.Add(this.panel1);
            this.editMemberPanel.Controls.Add(this.label2);
            this.editMemberPanel.Controls.Add(this.searchBox);
            this.editMemberPanel.Controls.Add(this.label25);
            this.editMemberPanel.Controls.Add(this.label3);
            this.editMemberPanel.Controls.Add(this.sortByBox);
            this.editMemberPanel.Controls.Add(this.label4);
            this.editMemberPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.editMemberPanel.Location = new System.Drawing.Point(0, 0);
            this.editMemberPanel.MinimumSize = new System.Drawing.Size(200, 0);
            this.editMemberPanel.Name = "editMemberPanel";
            this.editMemberPanel.Size = new System.Drawing.Size(248, 662);
            this.editMemberPanel.TabIndex = 24;
            this.editMemberPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editMemberPanel_Paint);
            // 
            // customLabelButton1
            // 
            this.customLabelButton1.AutoSize = true;
            this.customLabelButton1.BackColor = System.Drawing.Color.Transparent;
            this.customLabelButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customLabelButton1.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.customLabelButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customLabelButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.customLabelButton1.Location = new System.Drawing.Point(9, 70);
            this.customLabelButton1.Margin = new System.Windows.Forms.Padding(3);
            this.customLabelButton1.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.customLabelButton1.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.customLabelButton1.Name = "customLabelButton1";
            this.customLabelButton1.Padding = new System.Windows.Forms.Padding(3);
            this.customLabelButton1.Size = new System.Drawing.Size(63, 25);
            this.customLabelButton1.TabIndex = 71;
            this.customLabelButton1.Text = "Clear all";
            this.customLabelButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = true;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.deleteBtn.Location = new System.Drawing.Point(9, 39);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(3);
            this.deleteBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.deleteBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(3);
            this.deleteBtn.Size = new System.Drawing.Size(54, 25);
            this.deleteBtn.TabIndex = 70;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // resizeMmberInfoLine
            // 
            this.resizeMmberInfoLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.resizeMmberInfoLine.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizeMmberInfoLine.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeMmberInfoLine.Location = new System.Drawing.Point(237, 0);
            this.resizeMmberInfoLine.Name = "resizeMmberInfoLine";
            this.resizeMmberInfoLine.Size = new System.Drawing.Size(1, 662);
            this.resizeMmberInfoLine.TabIndex = 64;
            this.resizeMmberInfoLine.Tag = "border";
            // 
            // resizeMemberInfo
            // 
            this.resizeMemberInfo.BackColor = System.Drawing.Color.Transparent;
            this.resizeMemberInfo.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizeMemberInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeMemberInfo.Location = new System.Drawing.Point(238, 0);
            this.resizeMemberInfo.Name = "resizeMemberInfo";
            this.resizeMemberInfo.Size = new System.Drawing.Size(10, 662);
            this.resizeMemberInfo.TabIndex = 63;
            this.resizeMemberInfo.Tag = "border";
            this.resizeMemberInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizeMemberInfo_MouseDown);
            this.resizeMemberInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizeMemberInfo_MouseMove);
            this.resizeMemberInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizeMemberInfo_MouseUp);
            // 
            // refreshDBBtn
            // 
            this.refreshDBBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshDBBtn.AutoSize = true;
            this.refreshDBBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshDBBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshDBBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.refreshDBBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.refreshDBBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.refreshDBBtn.Location = new System.Drawing.Point(170, 8);
            this.refreshDBBtn.Margin = new System.Windows.Forms.Padding(3);
            this.refreshDBBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.refreshDBBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.refreshDBBtn.Name = "refreshDBBtn";
            this.refreshDBBtn.Padding = new System.Windows.Forms.Padding(3);
            this.refreshDBBtn.Size = new System.Drawing.Size(60, 25);
            this.refreshDBBtn.TabIndex = 69;
            this.refreshDBBtn.Text = "Refresh";
            this.refreshDBBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshDBBtn.Click += new System.EventHandler(this.refreshDBBtn_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.AutoSize = true;
            this.saveChangesBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveChangesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChangesBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.saveChangesBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.saveChangesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.saveChangesBtn.Location = new System.Drawing.Point(8, 8);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(3);
            this.saveChangesBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.saveChangesBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Padding = new System.Windows.Forms.Padding(3);
            this.saveChangesBtn.Size = new System.Drawing.Size(97, 25);
            this.saveChangesBtn.TabIndex = 68;
            this.saveChangesBtn.Text = "Save changes";
            this.saveChangesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // searchList
            // 
            this.searchList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchList_DoWork);
            this.searchList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchList_RunWorkerCompleted);
            // 
            // loaddatainfo
            // 
            this.loaddatainfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loaddatainfo_DoWork);
            this.loaddatainfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loaddatainfo_RunWorkerCompleted);
            // 
            // loadDataTable
            // 
            this.loadDataTable.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadDataTable_DoWork);
            this.loadDataTable.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadDataTable_RunWorkerCompleted);
            // 
            // membersList
            // 
            this.membersList.AllowUserToAddRows = false;
            this.membersList.AllowUserToDeleteRows = false;
            this.membersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersList.BackgroundColor = System.Drawing.Color.White;
            this.membersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.membersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.membersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.membersList.ColumnHeadersHeight = 55;
            this.membersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.membersList.DefaultCellStyle = dataGridViewCellStyle8;
            this.membersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.membersList.EnableHeadersVisualStyles = false;
            this.membersList.GridColor = System.Drawing.Color.DimGray;
            this.membersList.Location = new System.Drawing.Point(248, 0);
            this.membersList.MultiSelect = false;
            this.membersList.Name = "membersList";
            this.membersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.membersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.membersList.RowHeadersVisible = false;
            this.membersList.RowTemplate.Height = 30;
            this.membersList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.membersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersList.Size = new System.Drawing.Size(535, 590);
            this.membersList.TabIndex = 28;
            this.membersList.VirtualMode = true;
            this.membersList.Sorted += new System.EventHandler(this.membersList_Sorted);
            // 
            // saveChanges
            // 
            this.saveChanges.DoWork += new System.ComponentModel.DoWorkEventHandler(this.saveChanges_DoWork);
            this.saveChanges.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.saveChanges_RunWorkerCompleted);
            // 
            // contentHolder
            // 
            this.contentHolder.Controls.Add(this.membersList);
            this.contentHolder.Controls.Add(this.flowLayoutPanel1);
            this.contentHolder.Controls.Add(this.editMemberPanel);
            this.contentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentHolder.Location = new System.Drawing.Point(5, 5);
            this.contentHolder.Name = "contentHolder";
            this.contentHolder.Size = new System.Drawing.Size(783, 662);
            this.contentHolder.TabIndex = 29;
            // 
            // loadingItem1
            // 
            this.loadingItem1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingItem1.Image = ((System.Drawing.Image)(resources.GetObject("loadingItem1.Image")));
            this.loadingItem1.Location = new System.Drawing.Point(5, 5);
            this.loadingItem1.Name = "loadingItem1";
            this.loadingItem1.Size = new System.Drawing.Size(783, 662);
            this.loadingItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingItem1.TabIndex = 27;
            this.loadingItem1.TabStop = false;
            this.loadingItem1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loadingItem1.Visible = false;
            // 
            // viewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentHolder);
            this.Controls.Add(this.loadingItem1);
            this.Name = "viewAll";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(793, 672);
            this.Load += new System.EventHandler(this.viewAll_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.editMemberPanel.ResumeLayout(false);
            this.editMemberPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersList)).EndInit();
            this.contentHolder.ResumeLayout(false);
            this.contentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox exactMatchCheck;
        private System.Windows.Forms.ComboBox searchByBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox viewCheckBox;
        private System.Windows.Forms.ComboBox orderByBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sortByBox;
        private System.Windows.Forms.Panel editMemberPanel;
        private System.ComponentModel.BackgroundWorker searchList;
        private System.ComponentModel.BackgroundWorker loaddatainfo;
        private System.ComponentModel.BackgroundWorker loadDataTable;
        private loadingItem loadingItem1;
        public System.Windows.Forms.DataGridView membersList;
        private CustomLabelButton saveChangesBtn;
        private CustomLabelButton refreshDBBtn;
        private System.Windows.Forms.Panel contentHolder;
        public System.ComponentModel.BackgroundWorker saveChanges;
        private System.Windows.Forms.Panel resizeMmberInfoLine;
        private System.Windows.Forms.Panel resizeMemberInfo;
        private CustomLabelButton deleteBtn;
        private CustomLabelButton customLabelButton1;
        public System.Windows.Forms.Label totalMembersLabel;
        public System.Windows.Forms.Label membersOwingLabel;
        public System.Windows.Forms.Label totalAmtLabel;
        public System.Windows.Forms.Label activeMembersLabel;
        public System.Windows.Forms.Label nonActiveMembersLabel;
    }
}
