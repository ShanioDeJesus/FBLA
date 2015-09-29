namespace FBLAProject
{
    partial class singleAddMember
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
            this.label11 = new System.Windows.Forms.Label();
            this.genBtn = new CustomLabelButton();
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
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(22, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 30);
            this.label11.TabIndex = 117;
            this.label11.Text = "New member";
            // 
            // genBtn
            // 
            this.genBtn.AutoSize = true;
            this.genBtn.BackColor = System.Drawing.Color.Transparent;
            this.genBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.genBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genBtn.ForeColor = System.Drawing.Color.White;
            this.genBtn.Location = new System.Drawing.Point(344, 66);
            this.genBtn.Margin = new System.Windows.Forms.Padding(3);
            this.genBtn.MouseDownColor = System.Drawing.Color.Black;
            this.genBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.genBtn.Name = "genBtn";
            this.genBtn.Padding = new System.Windows.Forms.Padding(3);
            this.genBtn.Size = new System.Drawing.Size(193, 27);
            this.genBtn.TabIndex = 116;
            this.genBtn.Text = "Generate unused number";
            this.genBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.AutoSize = true;
            this.addMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.addMemberBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addMemberBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.addMemberBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberBtn.ForeColor = System.Drawing.Color.White;
            this.addMemberBtn.Location = new System.Drawing.Point(430, 397);
            this.addMemberBtn.Margin = new System.Windows.Forms.Padding(3);
            this.addMemberBtn.MouseDownColor = System.Drawing.Color.Black;
            this.addMemberBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Padding = new System.Windows.Forms.Padding(3);
            this.addMemberBtn.Size = new System.Drawing.Size(107, 27);
            this.addMemberBtn.TabIndex = 114;
            this.addMemberBtn.Text = "Add member";
            this.addMemberBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.oweBox.Location = new System.Drawing.Point(302, 360);
            this.oweBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.oweBox.MaxLength = 9;
            this.oweBox.Name = "oweBox";
            this.oweBox.Size = new System.Drawing.Size(235, 25);
            this.oweBox.TabIndex = 101;
            this.oweBox.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(286, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 21);
            this.label9.TabIndex = 112;
            this.label9.Text = "Amount owed";
            // 
            // emailBox
            // 
            this.emailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.emailBox.Location = new System.Drawing.Point(27, 252);
            this.emailBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.emailBox.MaxLength = 255;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(510, 25);
            this.emailBox.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 21);
            this.label8.TabIndex = 111;
            this.label8.Text = "Email address";
            // 
            // activeMemberCheck
            // 
            this.activeMemberCheck.AutoSize = true;
            this.activeMemberCheck.Checked = true;
            this.activeMemberCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activeMemberCheck.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.activeMemberCheck.ForeColor = System.Drawing.Color.White;
            this.activeMemberCheck.Location = new System.Drawing.Point(27, 399);
            this.activeMemberCheck.Name = "activeMemberCheck";
            this.activeMemberCheck.Size = new System.Drawing.Size(141, 25);
            this.activeMemberCheck.TabIndex = 102;
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
            this.yearBox.Location = new System.Drawing.Point(27, 360);
            this.yearBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.yearBox.MaxLength = 4;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(247, 25);
            this.yearBox.TabIndex = 100;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 110;
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
            this.stateCombo.Location = new System.Drawing.Point(27, 306);
            this.stateCombo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.stateCombo.Name = "stateCombo";
            this.stateCombo.Size = new System.Drawing.Size(247, 25);
            this.stateCombo.TabIndex = 98;
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
            this.gradeBox.Location = new System.Drawing.Point(290, 306);
            this.gradeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.gradeBox.MaxLength = 255;
            this.gradeBox.Name = "gradeBox";
            this.gradeBox.Size = new System.Drawing.Size(247, 25);
            this.gradeBox.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(286, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 109;
            this.label6.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 108;
            this.label5.Text = "State";
            // 
            // schoolBox
            // 
            this.schoolBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.schoolBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.schoolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.schoolBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.schoolBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.schoolBox.Location = new System.Drawing.Point(27, 199);
            this.schoolBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(510, 25);
            this.schoolBox.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 107;
            this.label4.Text = "School name";
            // 
            // lastBox
            // 
            this.lastBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lastBox.Location = new System.Drawing.Point(285, 146);
            this.lastBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.lastBox.MaxLength = 255;
            this.lastBox.Name = "lastBox";
            this.lastBox.Size = new System.Drawing.Size(252, 25);
            this.lastBox.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(281, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 106;
            this.label3.Text = "Last name";
            // 
            // firstBox
            // 
            this.firstBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.firstBox.Location = new System.Drawing.Point(27, 146);
            this.firstBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.firstBox.MaxLength = 255;
            this.firstBox.Name = "firstBox";
            this.firstBox.Size = new System.Drawing.Size(252, 25);
            this.firstBox.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 105;
            this.label1.Text = "First name";
            // 
            // memIdBox
            // 
            this.memIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.memIdBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memIdBox.Location = new System.Drawing.Point(27, 93);
            this.memIdBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.memIdBox.Name = "memIdBox";
            this.memIdBox.Size = new System.Drawing.Size(510, 25);
            this.memIdBox.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 104;
            this.label2.Text = "Membership number";
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DefaultForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(362, 397);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3);
            this.cancelBtn.MouseDownColor = System.Drawing.Color.Black;
            this.cancelBtn.MouseOverColor = System.Drawing.Color.SteelBlue;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(3);
            this.cancelBtn.Size = new System.Drawing.Size(62, 27);
            this.cancelBtn.TabIndex = 103;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(286, 361);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 113;
            this.label10.Text = "$";
            // 
            // invalidEmail
            // 
            this.invalidEmail.AutoSize = true;
            this.invalidEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidEmail.ForeColor = System.Drawing.Color.White;
            this.invalidEmail.Location = new System.Drawing.Point(366, 233);
            this.invalidEmail.Name = "invalidEmail";
            this.invalidEmail.Size = new System.Drawing.Size(171, 21);
            this.invalidEmail.TabIndex = 115;
            this.invalidEmail.Text = "Email address is invalid";
            this.invalidEmail.Visible = false;
            // 
            // singleAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
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
            this.Name = "singleAddMember";
            this.Size = new System.Drawing.Size(561, 446);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private CustomLabelButton genBtn;
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
    }
}
