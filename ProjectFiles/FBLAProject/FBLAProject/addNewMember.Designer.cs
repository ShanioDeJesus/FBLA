namespace FBLAProject
{
    partial class addNewMember
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
            this.addMemberBtn = new CustomLabelButton();
            this.oweBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.memIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelBtn = new CustomLabelButton();
            this.label10 = new System.Windows.Forms.Label();
            this.invalidEmail = new System.Windows.Forms.Label();
            this.genBtn = new CustomLabelButton();
            this.genNumber = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.AutoSize = true;
            this.addMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.addMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.addMemberBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBtn.ForeColor = System.Drawing.Color.Black;
            this.addMemberBtn.Location = new System.Drawing.Point(420, 375);
            this.addMemberBtn.Margin = new System.Windows.Forms.Padding(3);
            this.addMemberBtn.MouseDownColor = System.Drawing.Color.Black;
            this.addMemberBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Padding = new System.Windows.Forms.Padding(3);
            this.addMemberBtn.Size = new System.Drawing.Size(107, 27);
            this.addMemberBtn.TabIndex = 66;
            this.addMemberBtn.Text = "Add member";
            this.addMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addMemberBtn.Click += new System.EventHandler(this.addMemberBtn_Click);
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
            this.oweBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oweBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.oweBox.Location = new System.Drawing.Point(292, 338);
            this.oweBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.oweBox.MaxLength = 9;
            this.oweBox.Name = "oweBox";
            this.oweBox.Size = new System.Drawing.Size(235, 25);
            this.oweBox.TabIndex = 8;
            this.oweBox.Text = "0";
            this.oweBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oweBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "Amount owed";
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailBox.Location = new System.Drawing.Point(17, 230);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.emailBox.MaxLength = 255;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(510, 25);
            this.emailBox.TabIndex = 4;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            this.emailBox.Leave += new System.EventHandler(this.emailBox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Email address";
            // 
            // activeMemberCheck
            // 
            this.activeMemberCheck.AutoSize = true;
            this.activeMemberCheck.Checked = true;
            this.activeMemberCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeMemberCheck.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activeMemberCheck.Location = new System.Drawing.Point(17, 377);
            this.activeMemberCheck.Name = "activeMemberCheck";
            this.activeMemberCheck.Size = new System.Drawing.Size(141, 25);
            this.activeMemberCheck.TabIndex = 9;
            this.activeMemberCheck.Text = "Active member?";
            this.activeMemberCheck.UseVisualStyleBackColor = true;
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
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yearBox.Location = new System.Drawing.Point(17, 338);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(247, 25);
            this.yearBox.TabIndex = 7;
            this.yearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Year joining";
            // 
            // stateCombo
            // 
            this.stateCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
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
            this.stateCombo.Location = new System.Drawing.Point(17, 284);
            this.stateCombo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(247, 25);
            this.stateCombo.TabIndex = 5;
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
            this.gradeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gradeBox.Location = new System.Drawing.Point(280, 284);
            this.gradeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.gradeBox.MaxLength = 255;
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(247, 25);
            this.gradeBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(276, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "State";
            // 
            // schoolBox
            // 
            this.schoolBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.schoolBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.schoolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.schoolBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.schoolBox.Location = new System.Drawing.Point(17, 177);
            this.schoolBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(510, 25);
            this.schoolBox.TabIndex = 3;
            this.schoolBox.TextChanged += new System.EventHandler(this.schoolBox_TextChanged);
            this.schoolBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.schoolBox_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "School name";
            // 
            // lastBox
            // 
            this.lastBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastBox.Location = new System.Drawing.Point(275, 124);
            this.lastBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.lastBox.MaxLength = 255;
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(252, 25);
            this.lastBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Last name";
            // 
            // firstBox
            // 
            this.firstBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstBox.Location = new System.Drawing.Point(17, 124);
            this.firstBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.firstBox.MaxLength = 255;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(252, 25);
            this.firstBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "First name";
            // 
            // memIdBox
            // 
            this.memIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memIdBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memIdBox.Location = new System.Drawing.Point(17, 71);
            this.memIdBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.memIdBox.Name = "memIdBox";
            this.memIdBox.Size = new System.Drawing.Size(510, 25);
            this.memIdBox.TabIndex = 0;
            this.memIdBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.memIdBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Membership number";
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(352, 375);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3);
            this.cancelBtn.MouseDownColor = System.Drawing.Color.Black;
            this.cancelBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(3);
            this.cancelBtn.Size = new System.Drawing.Size(62, 27);
            this.cancelBtn.TabIndex = 45;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "$";
            // 
            // invalidEmail
            // 
            this.invalidEmail.AutoSize = true;
            this.invalidEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidEmail.ForeColor = System.Drawing.Color.Maroon;
            this.invalidEmail.Location = new System.Drawing.Point(356, 211);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(171, 21);
            this.invalidEmail.TabIndex = 67;
            this.invalidEmail.Text = "Email address is invalid";
            this.invalidEmail.Visible = false;
            // 
            // genBtn
            // 
            this.genBtn.AutoSize = true;
            this.genBtn.BackColor = System.Drawing.Color.Transparent;
            this.genBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.genBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBtn.ForeColor = System.Drawing.Color.Black;
            this.genBtn.Location = new System.Drawing.Point(334, 44);
            this.genBtn.Margin = new System.Windows.Forms.Padding(3);
            this.genBtn.MouseDownColor = System.Drawing.Color.Black;
            this.genBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.genBtn.Name = "genBtn";
            this.genBtn.Padding = new System.Windows.Forms.Padding(3);
            this.genBtn.Size = new System.Drawing.Size(193, 27);
            this.genBtn.TabIndex = 68;
            this.genBtn.Text = "Generate unused number";
            this.genBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // genNumber
            // 
            this.genNumber.DoWork += new System.ComponentModel.DoWorkEventHandler(this.genNumber_DoWork);
            this.genNumber.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.genNumber_RunWorkerCompleted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 92;
            this.label11.Text = "New member";
            // 
            // addNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 414);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.oweBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.activeMemberCheck);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stateCombo);
            this.Controls.Add(this.gradeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.schoolBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.invalidEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addNewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create new member";
            this.Load += new System.EventHandler(this.addNewMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabelButton addMemberBtn;
        private System.Windows.Forms.TextBox oweBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memIdBox;
        private System.Windows.Forms.Label label2;
        private CustomLabelButton cancelBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label invalidEmail;
        private CustomLabelButton genBtn;
        private System.ComponentModel.BackgroundWorker genNumber;
        private System.Windows.Forms.Label label11;
    }
}