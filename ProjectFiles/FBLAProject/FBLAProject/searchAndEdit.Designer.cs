namespace FBLAProject
{
    partial class searchAndEdit
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchByCombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.selectedMember = new System.Windows.Forms.Panel();
            this.saveBtn = new CustomLabelButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.oweBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.activeMemberCheck = new System.Windows.Forms.CheckBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stateCombo = new System.Windows.Forms.ComboBox();
            this.gradeBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.schoolBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.memIdBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.invalidEmail = new System.Windows.Forms.Label();
            this.membersList = new System.Windows.Forms.DataGridView();
            this.searchList = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.selectedMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(85, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 1);
            this.panel6.TabIndex = 38;
            this.panel6.Tag = "border";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(368, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Search for";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search";
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(85, 25);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(279, 22);
            this.searchBox.TabIndex = 34;
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // searchByCombo
            // 
            this.searchByCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchByCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.searchByCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByCombo.DropDownWidth = 153;
            this.searchByCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchByCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchByCombo.ForeColor = System.Drawing.Color.White;
            this.searchByCombo.FormattingEnabled = true;
            this.searchByCombo.Items.AddRange(new object[] {
            "Membership Number",
            "First Name",
            "Last Name",
            "School",
            "State",
            "Grade",
            "Email",
            "Year Joined",
            "Active",
            "Amount Owed"});
            this.searchByCombo.Location = new System.Drawing.Point(371, 25);
            this.searchByCombo.Name = "searchByCombo";
            this.searchByCombo.Size = new System.Drawing.Size(174, 25);
            this.searchByCombo.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.searchByCombo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 59);
            this.panel1.TabIndex = 39;
            // 
            // selectedMember
            // 
            this.selectedMember.AutoScroll = true;
            this.selectedMember.Controls.Add(this.saveBtn);
            this.selectedMember.Controls.Add(this.panel10);
            this.selectedMember.Controls.Add(this.panel9);
            this.selectedMember.Controls.Add(this.panel8);
            this.selectedMember.Controls.Add(this.panel2);
            this.selectedMember.Controls.Add(this.panel7);
            this.selectedMember.Controls.Add(this.panel5);
            this.selectedMember.Controls.Add(this.panel4);
            this.selectedMember.Controls.Add(this.panel3);
            this.selectedMember.Controls.Add(this.oweBox);
            this.selectedMember.Controls.Add(this.label9);
            this.selectedMember.Controls.Add(this.emailBox);
            this.selectedMember.Controls.Add(this.label2);
            this.selectedMember.Controls.Add(this.activeMemberCheck);
            this.selectedMember.Controls.Add(this.yearBox);
            this.selectedMember.Controls.Add(this.label7);
            this.selectedMember.Controls.Add(this.stateCombo);
            this.selectedMember.Controls.Add(this.gradeBox);
            this.selectedMember.Controls.Add(this.label6);
            this.selectedMember.Controls.Add(this.label5);
            this.selectedMember.Controls.Add(this.schoolBox);
            this.selectedMember.Controls.Add(this.label4);
            this.selectedMember.Controls.Add(this.lastBox);
            this.selectedMember.Controls.Add(this.label3);
            this.selectedMember.Controls.Add(this.firstBox);
            this.selectedMember.Controls.Add(this.label10);
            this.selectedMember.Controls.Add(this.memIdBox);
            this.selectedMember.Controls.Add(this.label11);
            this.selectedMember.Controls.Add(this.label12);
            this.selectedMember.Controls.Add(this.invalidEmail);
            this.selectedMember.Dock = System.Windows.Forms.DockStyle.Right;
            this.selectedMember.Location = new System.Drawing.Point(283, 59);
            this.selectedMember.Name = "selectedMember";
            this.selectedMember.Size = new System.Drawing.Size(292, 517);
            this.selectedMember.TabIndex = 41;
            // 
            // saveBtn
            // 
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(214, 8);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3);
            this.saveBtn.MouseDownColor = System.Drawing.Color.Black;
            this.saveBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Padding = new System.Windows.Forms.Padding(3);
            this.saveBtn.Size = new System.Drawing.Size(49, 27);
            this.saveBtn.TabIndex = 112;
            this.saveBtn.Text = "Save\r\n";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(10, 495);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(252, 1);
            this.panel10.TabIndex = 149;
            this.panel10.Tag = "border";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(10, 441);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(252, 1);
            this.panel9.TabIndex = 148;
            this.panel9.Tag = "border";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(10, 332);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(252, 1);
            this.panel8.TabIndex = 147;
            this.panel8.Tag = "border";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(10, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 1);
            this.panel2.TabIndex = 146;
            this.panel2.Tag = "border";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(10, 283);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(252, 1);
            this.panel7.TabIndex = 145;
            this.panel7.Tag = "border";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(10, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 1);
            this.panel5.TabIndex = 144;
            this.panel5.Tag = "border";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(10, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 1);
            this.panel4.TabIndex = 143;
            this.panel4.Tag = "border";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(10, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(252, 1);
            this.panel3.TabIndex = 142;
            this.panel3.Tag = "border";
            // 
            // oweBox
            // 
            this.oweBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "D.C.",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.oweBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.oweBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oweBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oweBox.ForeColor = System.Drawing.Color.White;
            this.oweBox.Location = new System.Drawing.Point(22, 474);
            this.oweBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.oweBox.MaxLength = 9;
            this.oweBox.Name = "oweBox";
            this.oweBox.Size = new System.Drawing.Size(235, 18);
            this.oweBox.TabIndex = 125;
            this.oweBox.Text = "0";
            this.oweBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 453);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 136;
            this.label9.Text = "Amount owed";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailBox.ForeColor = System.Drawing.Color.White;
            this.emailBox.Location = new System.Drawing.Point(10, 262);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.emailBox.MaxLength = 255;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(252, 18);
            this.emailBox.TabIndex = 121;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 135;
            this.label2.Text = "Email address";
            // 
            // activeMemberCheck
            // 
            this.activeMemberCheck.AutoSize = true;
            this.activeMemberCheck.Checked = true;
            this.activeMemberCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeMemberCheck.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activeMemberCheck.ForeColor = System.Drawing.Color.White;
            this.activeMemberCheck.Location = new System.Drawing.Point(10, 510);
            this.activeMemberCheck.Name = "activeMemberCheck";
            this.activeMemberCheck.Size = new System.Drawing.Size(141, 25);
            this.activeMemberCheck.TabIndex = 126;
            this.activeMemberCheck.Text = "Active member?";
            this.activeMemberCheck.UseVisualStyleBackColor = true;
            this.activeMemberCheck.CheckedChanged += new System.EventHandler(this.activeMemberCheck_CheckedChanged);
            // 
            // yearBox
            // 
            this.yearBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "D.C.",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.yearBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearBox.ForeColor = System.Drawing.Color.White;
            this.yearBox.Location = new System.Drawing.Point(10, 420);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(253, 18);
            this.yearBox.TabIndex = 124;
            this.yearBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 134;
            this.label7.Text = "Year joining";
            // 
            // stateCombo
            // 
            this.stateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stateCombo.ForeColor = System.Drawing.Color.Black;
            this.stateCombo.FormattingEnabled = true;
            this.stateCombo.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "D.C.",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateCombo.Location = new System.Drawing.Point(10, 367);
            this.stateCombo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(247, 25);
            this.stateCombo.TabIndex = 122;
            this.stateCombo.SelectedIndexChanged += new System.EventHandler(this.stateCombo_SelectedIndexChanged);
            // 
            // gradeBox
            // 
            this.gradeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "D.C.",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.gradeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.gradeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gradeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gradeBox.ForeColor = System.Drawing.Color.White;
            this.gradeBox.Location = new System.Drawing.Point(10, 311);
            this.gradeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.gradeBox.MaxLength = 255;
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(252, 18);
            this.gradeBox.TabIndex = 123;
            this.gradeBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 133;
            this.label6.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 21);
            this.label5.TabIndex = 132;
            this.label5.Text = "State";
            // 
            // schoolBox
            // 
            this.schoolBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.schoolBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.schoolBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.schoolBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.schoolBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.schoolBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.schoolBox.ForeColor = System.Drawing.Color.White;
            this.schoolBox.Location = new System.Drawing.Point(10, 209);
            this.schoolBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(252, 18);
            this.schoolBox.TabIndex = 120;
            this.schoolBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 131;
            this.label4.Text = "School name";
            // 
            // lastBox
            // 
            this.lastBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lastBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastBox.ForeColor = System.Drawing.Color.White;
            this.lastBox.Location = new System.Drawing.Point(10, 152);
            this.lastBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.lastBox.MaxLength = 255;
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(252, 18);
            this.lastBox.TabIndex = 119;
            this.lastBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 130;
            this.label3.Text = "Last name";
            // 
            // firstBox
            // 
            this.firstBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.firstBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstBox.ForeColor = System.Drawing.Color.White;
            this.firstBox.Location = new System.Drawing.Point(10, 95);
            this.firstBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.firstBox.MaxLength = 255;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(252, 18);
            this.firstBox.TabIndex = 118;
            this.firstBox.TextChanged += new System.EventHandler(this.firstBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 129;
            this.label10.Text = "First name";
            // 
            // memIdBox
            // 
            this.memIdBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.memIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.memIdBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memIdBox.ForeColor = System.Drawing.Color.White;
            this.memIdBox.Location = new System.Drawing.Point(10, 38);
            this.memIdBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.memIdBox.Name = "memIdBox";
            this.memIdBox.Size = new System.Drawing.Size(252, 18);
            this.memIdBox.TabIndex = 117;
            this.memIdBox.TextChanged += new System.EventHandler(this.memIdBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(6, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 21);
            this.label11.TabIndex = 128;
            this.label11.Text = "Membership number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 471);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 137;
            this.label12.Text = "$";
            // 
            // invalidEmail
            // 
            this.invalidEmail.AutoSize = true;
            this.invalidEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidEmail.ForeColor = System.Drawing.Color.LightCoral;
            this.invalidEmail.Location = new System.Drawing.Point(207, 238);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(56, 21);
            this.invalidEmail.TabIndex = 139;
            this.invalidEmail.Text = "Invalid";
            this.invalidEmail.Visible = false;
            // 
            // membersList
            // 
            this.membersList.AllowUserToResizeRows = false;
            this.membersList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.membersList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.membersList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.membersList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.membersList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.membersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.membersList.ColumnHeadersHeight = 55;
            this.membersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(207)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.membersList.DefaultCellStyle = dataGridViewCellStyle2;
            this.membersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersList.EnableHeadersVisualStyles = false;
            this.membersList.GridColor = System.Drawing.Color.DimGray;
            this.membersList.Location = new System.Drawing.Point(0, 59);
            this.membersList.MultiSelect = false;
            this.membersList.Name = "membersList";
            this.membersList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.membersList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.membersList.RowHeadersVisible = false;
            this.membersList.RowTemplate.Height = 30;
            this.membersList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.membersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.membersList.ShowEditingIcon = false;
            this.membersList.Size = new System.Drawing.Size(283, 517);
            this.membersList.TabIndex = 42;
            this.membersList.VirtualMode = true;
            this.membersList.SelectionChanged += new System.EventHandler(this.membersList_SelectionChanged);
            this.membersList.DoubleClick += new System.EventHandler(this.membersList_DoubleClick);
            // 
            // searchList
            // 
            this.searchList.WorkerReportsProgress = true;
            this.searchList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searchList_DoWork);
            this.searchList.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searchList_RunWorkerCompleted);
            // 
            // searchAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.membersList);
            this.Controls.Add(this.selectedMember);
            this.Controls.Add(this.panel1);
            this.Name = "searchAndEdit";
            this.Size = new System.Drawing.Size(575, 576);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.selectedMember.ResumeLayout(false);
            this.selectedMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox searchByCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel selectedMember;
        public System.Windows.Forms.DataGridView membersList;
        private System.ComponentModel.BackgroundWorker searchList;
        private System.Windows.Forms.TextBox oweBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox activeMemberCheck;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox stateCombo;
        private System.Windows.Forms.TextBox gradeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox schoolBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox memIdBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label invalidEmail;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private CustomLabelButton saveBtn;
    }
}
