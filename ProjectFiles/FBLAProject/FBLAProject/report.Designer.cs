namespace FBLAProject
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.loadReport = new System.ComponentModel.BackgroundWorker();
            this.membersOwingLabel = new System.Windows.Forms.Label();
            this.totalAmtLabel = new System.Windows.Forms.Label();
            this.activeMembersLabel = new System.Windows.Forms.Label();
            this.nonActiveMembersLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.thisGrid = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sortbyCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sortOrderCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.thisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // loadReport
            // 
            this.loadReport.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadReport_DoWork);
            // 
            // membersOwingLabel
            // 
            this.membersOwingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.membersOwingLabel.AutoEllipsis = true;
            this.membersOwingLabel.AutoSize = true;
            this.membersOwingLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membersOwingLabel.ForeColor = System.Drawing.Color.Black;
            this.membersOwingLabel.Location = new System.Drawing.Point(671, 477);
            this.membersOwingLabel.Name = "membersOwingLabel";
            this.membersOwingLabel.Padding = new System.Windows.Forms.Padding(3);
            this.membersOwingLabel.Size = new System.Drawing.Size(132, 27);
            this.membersOwingLabel.TabIndex = 28;
            this.membersOwingLabel.Text = "Members owing:";
            // 
            // totalAmtLabel
            // 
            this.totalAmtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalAmtLabel.AutoEllipsis = true;
            this.totalAmtLabel.AutoSize = true;
            this.totalAmtLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmtLabel.ForeColor = System.Drawing.Color.Black;
            this.totalAmtLabel.Location = new System.Drawing.Point(445, 477);
            this.totalAmtLabel.Name = "totalAmtLabel";
            this.totalAmtLabel.Padding = new System.Windows.Forms.Padding(3);
            this.totalAmtLabel.Size = new System.Drawing.Size(151, 27);
            this.totalAmtLabel.TabIndex = 29;
            this.totalAmtLabel.Text = "Total amount owed:";
            // 
            // activeMembersLabel
            // 
            this.activeMembersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.activeMembersLabel.AutoEllipsis = true;
            this.activeMembersLabel.AutoSize = true;
            this.activeMembersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeMembersLabel.ForeColor = System.Drawing.Color.Black;
            this.activeMembersLabel.Location = new System.Drawing.Point(12, 477);
            this.activeMembersLabel.Name = "activeMembersLabel";
            this.activeMembersLabel.Padding = new System.Windows.Forms.Padding(3);
            this.activeMembersLabel.Size = new System.Drawing.Size(131, 27);
            this.activeMembersLabel.TabIndex = 30;
            this.activeMembersLabel.Text = "Active members:";
            // 
            // nonActiveMembersLabel
            // 
            this.nonActiveMembersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nonActiveMembersLabel.AutoEllipsis = true;
            this.nonActiveMembersLabel.AutoSize = true;
            this.nonActiveMembersLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonActiveMembersLabel.ForeColor = System.Drawing.Color.Black;
            this.nonActiveMembersLabel.Location = new System.Drawing.Point(215, 477);
            this.nonActiveMembersLabel.Name = "nonActiveMembersLabel";
            this.nonActiveMembersLabel.Padding = new System.Windows.Forms.Padding(3);
            this.nonActiveMembersLabel.Size = new System.Drawing.Size(163, 27);
            this.nonActiveMembersLabel.TabIndex = 31;
            this.nonActiveMembersLabel.Text = "Non active members:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(791, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // thisGrid
            // 
            this.thisGrid.AllowUserToAddRows = false;
            this.thisGrid.AllowUserToResizeRows = false;
            this.thisGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.thisGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.thisGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.thisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thisGrid.EnableHeadersVisualStyles = false;
            this.thisGrid.Location = new System.Drawing.Point(16, 99);
            this.thisGrid.MultiSelect = false;
            this.thisGrid.Name = "thisGrid";
            this.thisGrid.ReadOnly = true;
            this.thisGrid.RowHeadersVisible = false;
            this.thisGrid.Size = new System.Drawing.Size(850, 335);
            this.thisGrid.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(16, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 29);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Member Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Header";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(648, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "You may edit each column width and the header text below. When you are ready, cli" +
    "ck Print.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(243, 437);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(401, 27);
            this.label4.TabIndex = 40;
            this.label4.Text = "*Preview displays as one sheet but will print in multiple.";
            // 
            // sortbyCombo
            // 
            this.sortbyCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sortbyCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortbyCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortbyCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortbyCombo.ForeColor = System.Drawing.Color.White;
            this.sortbyCombo.FormattingEnabled = true;
            this.sortbyCombo.Items.AddRange(new object[] {
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
            this.sortbyCombo.Location = new System.Drawing.Point(472, 66);
            this.sortbyCombo.Name = "sortbyCombo";
            this.sortbyCombo.Size = new System.Drawing.Size(124, 25);
            this.sortbyCombo.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(339, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "List sort order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(473, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Sort list by";
            // 
            // sortOrderCombo
            // 
            this.sortOrderCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sortOrderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortOrderCombo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortOrderCombo.ForeColor = System.Drawing.Color.White;
            this.sortOrderCombo.FormattingEnabled = true;
            this.sortOrderCombo.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderCombo.Location = new System.Drawing.Point(338, 68);
            this.sortOrderCombo.Name = "sortOrderCombo";
            this.sortOrderCombo.Size = new System.Drawing.Size(124, 25);
            this.sortOrderCombo.TabIndex = 42;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 549);
            this.Controls.Add(this.sortbyCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sortOrderCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.thisGrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.membersOwingLabel);
            this.Controls.Add(this.totalAmtLabel);
            this.Controls.Add(this.activeMembersLabel);
            this.Controls.Add(this.nonActiveMembersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thisGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker loadReport;
        private System.Windows.Forms.Label membersOwingLabel;
        private System.Windows.Forms.Label totalAmtLabel;
        private System.Windows.Forms.Label activeMembersLabel;
        private System.Windows.Forms.Label nonActiveMembersLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView thisGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sortbyCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox sortOrderCombo;
    }
}