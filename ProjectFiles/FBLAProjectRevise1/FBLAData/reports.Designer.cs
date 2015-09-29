namespace FBLAData
{
    partial class reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reports));
            this.toolPanel = new System.Windows.Forms.Panel();
            this.showDateCheck = new System.Windows.Forms.CheckBox();
            this.showLineNumberCheck = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.applyBtn = new CustomLabelButton();
            this.defaultValues = new CustomLabelButton();
            this.previewBorder = new System.Windows.Forms.Panel();
            this.previewDocument = new System.Windows.Forms.Label();
            this.previewHeader = new System.Windows.Forms.Label();
            this.headerBackcolorBtn = new CustomLabelButton();
            this.borderColorBtn = new CustomLabelButton();
            this.showPageSetup = new CustomLabelButton();
            this.docColorBtn = new CustomLabelButton();
            this.docFontBtn = new CustomLabelButton();
            this.headerColorBtn = new CustomLabelButton();
            this.headerFontBtn = new CustomLabelButton();
            this.headerBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleColorBtn = new CustomLabelButton();
            this.titleFontBtn = new CustomLabelButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ColumnsToPrintLabel = new System.Windows.Forms.Label();
            this.columnsToPrintBox = new System.Windows.Forms.CheckedListBox();
            this.exportToExcel = new CustomLabelButton();
            this.label4 = new System.Windows.Forms.Label();
            this.sortByBox = new System.Windows.Forms.ComboBox();
            this.printPreviewBtn = new CustomLabelButton();
            this.label1 = new System.Windows.Forms.Label();
            this.typeSelector = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetup = new System.Windows.Forms.PageSetupDialog();
            this.printCtrl = new System.Windows.Forms.PrintPreviewControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prePageBtn = new CustomLabelButton();
            this.pgNumberLabel = new System.Windows.Forms.Label();
            this.nextPageBtn = new CustomLabelButton();
            this.viewTypeSelector = new System.Windows.Forms.ComboBox();
            this.zoomOutBtn = new CustomLabelButton();
            this.zoomInBtn = new CustomLabelButton();
            this.leftsmallPanel = new System.Windows.Forms.Panel();
            this.applyBtnLeft = new CustomLabelButton();
            this.decendOrder = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.leftsmallPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolPanel
            // 
            this.toolPanel.AutoScroll = true;
            this.toolPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.toolPanel.Controls.Add(this.showDateCheck);
            this.toolPanel.Controls.Add(this.showLineNumberCheck);
            this.toolPanel.Controls.Add(this.panel3);
            this.toolPanel.Controls.Add(this.label6);
            this.toolPanel.Controls.Add(this.applyBtn);
            this.toolPanel.Controls.Add(this.defaultValues);
            this.toolPanel.Controls.Add(this.previewBorder);
            this.toolPanel.Controls.Add(this.previewDocument);
            this.toolPanel.Controls.Add(this.previewHeader);
            this.toolPanel.Controls.Add(this.headerBackcolorBtn);
            this.toolPanel.Controls.Add(this.borderColorBtn);
            this.toolPanel.Controls.Add(this.showPageSetup);
            this.toolPanel.Controls.Add(this.docColorBtn);
            this.toolPanel.Controls.Add(this.docFontBtn);
            this.toolPanel.Controls.Add(this.headerColorBtn);
            this.toolPanel.Controls.Add(this.headerFontBtn);
            this.toolPanel.Controls.Add(this.headerBox);
            this.toolPanel.Controls.Add(this.label2);
            this.toolPanel.Controls.Add(this.titleColorBtn);
            this.toolPanel.Controls.Add(this.titleFontBtn);
            this.toolPanel.Controls.Add(this.label3);
            this.toolPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolPanel.Location = new System.Drawing.Point(989, 5);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(271, 672);
            this.toolPanel.TabIndex = 112;
            this.toolPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toolPanel_Paint);
            // 
            // showDateCheck
            // 
            this.showDateCheck.AutoSize = true;
            this.showDateCheck.Checked = true;
            this.showDateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDateCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDateCheck.ForeColor = System.Drawing.Color.White;
            this.showDateCheck.Location = new System.Drawing.Point(19, 410);
            this.showDateCheck.Name = "showDateCheck";
            this.showDateCheck.Size = new System.Drawing.Size(143, 21);
            this.showDateCheck.TabIndex = 142;
            this.showDateCheck.Text = "Show date and time";
            this.showDateCheck.UseVisualStyleBackColor = true;
            // 
            // showLineNumberCheck
            // 
            this.showLineNumberCheck.AutoSize = true;
            this.showLineNumberCheck.Checked = true;
            this.showLineNumberCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showLineNumberCheck.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLineNumberCheck.ForeColor = System.Drawing.Color.White;
            this.showLineNumberCheck.Location = new System.Drawing.Point(19, 383);
            this.showLineNumberCheck.Name = "showLineNumberCheck";
            this.showLineNumberCheck.Size = new System.Drawing.Size(99, 21);
            this.showLineNumberCheck.TabIndex = 141;
            this.showLineNumberCheck.Text = "Line number";
            this.showLineNumberCheck.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 672);
            this.panel3.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 135;
            this.label6.Text = "Format";
            // 
            // applyBtn
            // 
            this.applyBtn.AutoSize = true;
            this.applyBtn.BackColor = System.Drawing.Color.Transparent;
            this.applyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtn.DefaultForeColor = System.Drawing.Color.White;
            this.applyBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Location = new System.Drawing.Point(173, 11);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(3);
            this.applyBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.applyBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Padding = new System.Windows.Forms.Padding(3);
            this.applyBtn.Size = new System.Drawing.Size(50, 25);
            this.applyBtn.TabIndex = 129;
            this.applyBtn.Text = "Apply";
            this.applyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // defaultValues
            // 
            this.defaultValues.AutoSize = true;
            this.defaultValues.BackColor = System.Drawing.Color.Transparent;
            this.defaultValues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.defaultValues.DefaultForeColor = System.Drawing.Color.White;
            this.defaultValues.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.defaultValues.ForeColor = System.Drawing.Color.White;
            this.defaultValues.Location = new System.Drawing.Point(15, 437);
            this.defaultValues.Margin = new System.Windows.Forms.Padding(3);
            this.defaultValues.MouseDownColor = System.Drawing.Color.Gray;
            this.defaultValues.MouseOverColor = System.Drawing.Color.Silver;
            this.defaultValues.Name = "defaultValues";
            this.defaultValues.Padding = new System.Windows.Forms.Padding(3);
            this.defaultValues.Size = new System.Drawing.Size(48, 25);
            this.defaultValues.TabIndex = 130;
            this.defaultValues.Text = "Reset";
            this.defaultValues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.defaultValues.Click += new System.EventHandler(this.defaultValues_Click);
            // 
            // previewBorder
            // 
            this.previewBorder.BackColor = System.Drawing.Color.DimGray;
            this.previewBorder.ForeColor = System.Drawing.Color.White;
            this.previewBorder.Location = new System.Drawing.Point(119, 347);
            this.previewBorder.Name = "previewBorder";
            this.previewBorder.Size = new System.Drawing.Size(120, 1);
            this.previewBorder.TabIndex = 134;
            // 
            // previewDocument
            // 
            this.previewDocument.AutoSize = true;
            this.previewDocument.BackColor = System.Drawing.Color.White;
            this.previewDocument.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewDocument.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.previewDocument.ForeColor = System.Drawing.Color.Black;
            this.previewDocument.Location = new System.Drawing.Point(144, 263);
            this.previewDocument.Name = "previewDocument";
            this.previewDocument.Size = new System.Drawing.Size(82, 21);
            this.previewDocument.TabIndex = 133;
            this.previewDocument.Text = "Sample text";
            this.previewDocument.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // previewHeader
            // 
            this.previewHeader.BackColor = System.Drawing.Color.White;
            this.previewHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.previewHeader.ForeColor = System.Drawing.Color.Black;
            this.previewHeader.Location = new System.Drawing.Point(132, 161);
            this.previewHeader.Name = "previewHeader";
            this.previewHeader.Size = new System.Drawing.Size(107, 25);
            this.previewHeader.TabIndex = 132;
            this.previewHeader.Text = "Sample header";
            this.previewHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerBackcolorBtn
            // 
            this.headerBackcolorBtn.AutoSize = true;
            this.headerBackcolorBtn.BackColor = System.Drawing.Color.Transparent;
            this.headerBackcolorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headerBackcolorBtn.DefaultForeColor = System.Drawing.Color.White;
            this.headerBackcolorBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.headerBackcolorBtn.ForeColor = System.Drawing.Color.White;
            this.headerBackcolorBtn.Location = new System.Drawing.Point(14, 195);
            this.headerBackcolorBtn.Margin = new System.Windows.Forms.Padding(3);
            this.headerBackcolorBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.headerBackcolorBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.headerBackcolorBtn.Name = "headerBackcolorBtn";
            this.headerBackcolorBtn.Padding = new System.Windows.Forms.Padding(3);
            this.headerBackcolorBtn.Size = new System.Drawing.Size(125, 25);
            this.headerBackcolorBtn.TabIndex = 128;
            this.headerBackcolorBtn.Text = "Header back color";
            this.headerBackcolorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerBackcolorBtn.Click += new System.EventHandler(this.headerBackcolorBtn_Click);
            // 
            // borderColorBtn
            // 
            this.borderColorBtn.AutoSize = true;
            this.borderColorBtn.BackColor = System.Drawing.Color.Transparent;
            this.borderColorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borderColorBtn.DefaultForeColor = System.Drawing.Color.White;
            this.borderColorBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.borderColorBtn.ForeColor = System.Drawing.Color.White;
            this.borderColorBtn.Location = new System.Drawing.Point(14, 332);
            this.borderColorBtn.Margin = new System.Windows.Forms.Padding(3);
            this.borderColorBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.borderColorBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.borderColorBtn.Name = "borderColorBtn";
            this.borderColorBtn.Padding = new System.Windows.Forms.Padding(3);
            this.borderColorBtn.Size = new System.Drawing.Size(90, 25);
            this.borderColorBtn.TabIndex = 127;
            this.borderColorBtn.Text = "Border color";
            this.borderColorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.borderColorBtn.Click += new System.EventHandler(this.borderColorBtn_Click);
            // 
            // showPageSetup
            // 
            this.showPageSetup.AutoSize = true;
            this.showPageSetup.BackColor = System.Drawing.Color.Transparent;
            this.showPageSetup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPageSetup.DefaultForeColor = System.Drawing.Color.White;
            this.showPageSetup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.showPageSetup.ForeColor = System.Drawing.Color.White;
            this.showPageSetup.Location = new System.Drawing.Point(84, 11);
            this.showPageSetup.Margin = new System.Windows.Forms.Padding(3);
            this.showPageSetup.MouseDownColor = System.Drawing.Color.Gray;
            this.showPageSetup.MouseOverColor = System.Drawing.Color.Silver;
            this.showPageSetup.Name = "showPageSetup";
            this.showPageSetup.Padding = new System.Windows.Forms.Padding(3);
            this.showPageSetup.Size = new System.Drawing.Size(83, 25);
            this.showPageSetup.TabIndex = 120;
            this.showPageSetup.Text = "Page setup";
            this.showPageSetup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showPageSetup.Click += new System.EventHandler(this.showPageSetup_Click);
            // 
            // docColorBtn
            // 
            this.docColorBtn.AutoSize = true;
            this.docColorBtn.BackColor = System.Drawing.Color.Transparent;
            this.docColorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docColorBtn.DefaultForeColor = System.Drawing.Color.White;
            this.docColorBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.docColorBtn.ForeColor = System.Drawing.Color.White;
            this.docColorBtn.Location = new System.Drawing.Point(15, 276);
            this.docColorBtn.Margin = new System.Windows.Forms.Padding(3);
            this.docColorBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.docColorBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.docColorBtn.Name = "docColorBtn";
            this.docColorBtn.Padding = new System.Windows.Forms.Padding(3);
            this.docColorBtn.Size = new System.Drawing.Size(113, 25);
            this.docColorBtn.TabIndex = 125;
            this.docColorBtn.Text = "Document color";
            this.docColorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.docColorBtn.Click += new System.EventHandler(this.docColorBtn_Click);
            // 
            // docFontBtn
            // 
            this.docFontBtn.AutoSize = true;
            this.docFontBtn.BackColor = System.Drawing.Color.Transparent;
            this.docFontBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.docFontBtn.DefaultForeColor = System.Drawing.Color.White;
            this.docFontBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.docFontBtn.ForeColor = System.Drawing.Color.White;
            this.docFontBtn.Location = new System.Drawing.Point(15, 245);
            this.docFontBtn.Margin = new System.Windows.Forms.Padding(3);
            this.docFontBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.docFontBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.docFontBtn.Name = "docFontBtn";
            this.docFontBtn.Padding = new System.Windows.Forms.Padding(3);
            this.docFontBtn.Size = new System.Drawing.Size(108, 25);
            this.docFontBtn.TabIndex = 124;
            this.docFontBtn.Text = "Document font";
            this.docFontBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.docFontBtn.Click += new System.EventHandler(this.docFontBtn_Click);
            // 
            // headerColorBtn
            // 
            this.headerColorBtn.AutoSize = true;
            this.headerColorBtn.BackColor = System.Drawing.Color.Transparent;
            this.headerColorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headerColorBtn.DefaultForeColor = System.Drawing.Color.White;
            this.headerColorBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.headerColorBtn.ForeColor = System.Drawing.Color.White;
            this.headerColorBtn.Location = new System.Drawing.Point(13, 164);
            this.headerColorBtn.Margin = new System.Windows.Forms.Padding(3);
            this.headerColorBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.headerColorBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.headerColorBtn.Name = "headerColorBtn";
            this.headerColorBtn.Padding = new System.Windows.Forms.Padding(3);
            this.headerColorBtn.Size = new System.Drawing.Size(93, 25);
            this.headerColorBtn.TabIndex = 123;
            this.headerColorBtn.Text = "Header color";
            this.headerColorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerColorBtn.Click += new System.EventHandler(this.headerColorBtn_Click);
            // 
            // headerFontBtn
            // 
            this.headerFontBtn.AutoSize = true;
            this.headerFontBtn.BackColor = System.Drawing.Color.Transparent;
            this.headerFontBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.headerFontBtn.DefaultForeColor = System.Drawing.Color.White;
            this.headerFontBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.headerFontBtn.ForeColor = System.Drawing.Color.White;
            this.headerFontBtn.Location = new System.Drawing.Point(14, 131);
            this.headerFontBtn.Margin = new System.Windows.Forms.Padding(3);
            this.headerFontBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.headerFontBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.headerFontBtn.Name = "headerFontBtn";
            this.headerFontBtn.Padding = new System.Windows.Forms.Padding(3);
            this.headerFontBtn.Size = new System.Drawing.Size(88, 25);
            this.headerFontBtn.TabIndex = 122;
            this.headerFontBtn.Text = "Header font";
            this.headerFontBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.headerFontBtn.Click += new System.EventHandler(this.headerFontBtn_Click);
            // 
            // headerBox
            // 
            this.headerBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerBox.Location = new System.Drawing.Point(17, 64);
            this.headerBox.MaxLength = 35;
            this.headerBox.Name = "headerBox";
            this.headerBox.Size = new System.Drawing.Size(222, 25);
            this.headerBox.TabIndex = 116;
            this.headerBox.Text = "Member Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 115;
            this.label2.Text = "Report title";
            // 
            // titleColorBtn
            // 
            this.titleColorBtn.AutoSize = true;
            this.titleColorBtn.BackColor = System.Drawing.Color.Transparent;
            this.titleColorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleColorBtn.DefaultForeColor = System.Drawing.Color.White;
            this.titleColorBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.titleColorBtn.ForeColor = System.Drawing.Color.White;
            this.titleColorBtn.Location = new System.Drawing.Point(170, 38);
            this.titleColorBtn.Margin = new System.Windows.Forms.Padding(3);
            this.titleColorBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.titleColorBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.titleColorBtn.Name = "titleColorBtn";
            this.titleColorBtn.Padding = new System.Windows.Forms.Padding(3);
            this.titleColorBtn.Size = new System.Drawing.Size(74, 25);
            this.titleColorBtn.TabIndex = 121;
            this.titleColorBtn.Text = "Title color";
            this.titleColorBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleColorBtn.Click += new System.EventHandler(this.titleColorBtn_Click);
            // 
            // titleFontBtn
            // 
            this.titleFontBtn.AutoSize = true;
            this.titleFontBtn.BackColor = System.Drawing.Color.Transparent;
            this.titleFontBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titleFontBtn.DefaultForeColor = System.Drawing.Color.White;
            this.titleFontBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.titleFontBtn.ForeColor = System.Drawing.Color.White;
            this.titleFontBtn.Location = new System.Drawing.Point(95, 38);
            this.titleFontBtn.Margin = new System.Windows.Forms.Padding(3);
            this.titleFontBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.titleFontBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.titleFontBtn.Name = "titleFontBtn";
            this.titleFontBtn.Padding = new System.Windows.Forms.Padding(3);
            this.titleFontBtn.Size = new System.Drawing.Size(69, 25);
            this.titleFontBtn.TabIndex = 120;
            this.titleFontBtn.Text = "Title font";
            this.titleFontBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleFontBtn.Click += new System.EventHandler(this.titleFontBtn_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(112, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 136;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnsToPrintLabel
            // 
            this.ColumnsToPrintLabel.AutoSize = true;
            this.ColumnsToPrintLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ColumnsToPrintLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.ColumnsToPrintLabel.Location = new System.Drawing.Point(7, 204);
            this.ColumnsToPrintLabel.Name = "ColumnsToPrintLabel";
            this.ColumnsToPrintLabel.Size = new System.Drawing.Size(113, 19);
            this.ColumnsToPrintLabel.TabIndex = 120;
            this.ColumnsToPrintLabel.Text = "Columns to print";
            this.ColumnsToPrintLabel.Visible = false;
            // 
            // columnsToPrintBox
            // 
            this.columnsToPrintBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.columnsToPrintBox.BackColor = System.Drawing.Color.White;
            this.columnsToPrintBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.columnsToPrintBox.CheckOnClick = true;
            this.columnsToPrintBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsToPrintBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.columnsToPrintBox.FormattingEnabled = true;
            this.columnsToPrintBox.Location = new System.Drawing.Point(11, 226);
            this.columnsToPrintBox.Name = "columnsToPrintBox";
            this.columnsToPrintBox.Size = new System.Drawing.Size(191, 440);
            this.columnsToPrintBox.TabIndex = 117;
            this.columnsToPrintBox.Visible = false;
            this.columnsToPrintBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.viewCheckBox_ItemCheck);
            // 
            // exportToExcel
            // 
            this.exportToExcel.AutoSize = true;
            this.exportToExcel.BackColor = System.Drawing.Color.Transparent;
            this.exportToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportToExcel.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.exportToExcel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.exportToExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.exportToExcel.Location = new System.Drawing.Point(7, 38);
            this.exportToExcel.Margin = new System.Windows.Forms.Padding(3);
            this.exportToExcel.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.exportToExcel.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.exportToExcel.Name = "exportToExcel";
            this.exportToExcel.Padding = new System.Windows.Forms.Padding(3);
            this.exportToExcel.Size = new System.Drawing.Size(54, 25);
            this.exportToExcel.TabIndex = 139;
            this.exportToExcel.Text = "Export";
            this.exportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 136;
            this.label4.Text = "Sort by";
            // 
            // sortByBox
            // 
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
            this.sortByBox.Location = new System.Drawing.Point(9, 150);
            this.sortByBox.Name = "sortByBox";
            this.sortByBox.Size = new System.Drawing.Size(193, 23);
            this.sortByBox.TabIndex = 135;
            this.sortByBox.SelectedIndexChanged += new System.EventHandler(this.sortByBox_SelectedIndexChanged);
            // 
            // printPreviewBtn
            // 
            this.printPreviewBtn.AutoSize = true;
            this.printPreviewBtn.BackColor = System.Drawing.Color.Transparent;
            this.printPreviewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printPreviewBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.printPreviewBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.printPreviewBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.printPreviewBtn.Location = new System.Drawing.Point(67, 38);
            this.printPreviewBtn.Margin = new System.Windows.Forms.Padding(3);
            this.printPreviewBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.printPreviewBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.printPreviewBtn.Name = "printPreviewBtn";
            this.printPreviewBtn.Padding = new System.Windows.Forms.Padding(3);
            this.printPreviewBtn.Size = new System.Drawing.Size(44, 25);
            this.printPreviewBtn.TabIndex = 119;
            this.printPreviewBtn.Text = "Print";
            this.printPreviewBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printPreviewBtn.Click += new System.EventHandler(this.printPreviewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Report type";
            // 
            // typeSelector
            // 
            this.typeSelector.BackColor = System.Drawing.Color.White;
            this.typeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeSelector.FormattingEnabled = true;
            this.typeSelector.Items.AddRange(new object[] {
            "Full report",
            "Members owing",
            "High School Seniors",
            "High School Juniors",
            "High School Sopomores",
            "High School Freshman",
            "Emails",
            "Active",
            "Not active",
            "Custom"});
            this.typeSelector.Location = new System.Drawing.Point(9, 100);
            this.typeSelector.Name = "typeSelector";
            this.typeSelector.Size = new System.Drawing.Size(193, 21);
            this.typeSelector.TabIndex = 0;
            this.typeSelector.SelectedIndexChanged += new System.EventHandler(this.typeSelector_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(12, 9);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 19);
            this.label25.TabIndex = 118;
            this.label25.Text = "View";
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.ShowIcon = false;
            this.printPreviewDialog1.Visible = false;
            // 
            // pageSetup
            // 
            this.pageSetup.AllowPrinter = false;
            // 
            // printCtrl
            // 
            this.printCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.printCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printCtrl.Location = new System.Drawing.Point(216, 41);
            this.printCtrl.Name = "printCtrl";
            this.printCtrl.Size = new System.Drawing.Size(773, 600);
            this.printCtrl.TabIndex = 115;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.prePageBtn);
            this.panel2.Controls.Add(this.pgNumberLabel);
            this.panel2.Controls.Add(this.nextPageBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(216, 641);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(773, 36);
            this.panel2.TabIndex = 116;
            // 
            // prePageBtn
            // 
            this.prePageBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.prePageBtn.AutoSize = true;
            this.prePageBtn.BackColor = System.Drawing.Color.Transparent;
            this.prePageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prePageBtn.DefaultForeColor = System.Drawing.Color.White;
            this.prePageBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prePageBtn.ForeColor = System.Drawing.Color.White;
            this.prePageBtn.Location = new System.Drawing.Point(207, 6);
            this.prePageBtn.Margin = new System.Windows.Forms.Padding(3);
            this.prePageBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.prePageBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.prePageBtn.Name = "prePageBtn";
            this.prePageBtn.Padding = new System.Windows.Forms.Padding(3);
            this.prePageBtn.Size = new System.Drawing.Size(114, 27);
            this.prePageBtn.TabIndex = 117;
            this.prePageBtn.Text = "Previous page";
            this.prePageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prePageBtn.Click += new System.EventHandler(this.prePageBtn_Click);
            // 
            // pgNumberLabel
            // 
            this.pgNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pgNumberLabel.AutoEllipsis = true;
            this.pgNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pgNumberLabel.ForeColor = System.Drawing.Color.White;
            this.pgNumberLabel.Location = new System.Drawing.Point(321, 6);
            this.pgNumberLabel.Name = "pgNumberLabel";
            this.pgNumberLabel.Padding = new System.Windows.Forms.Padding(3);
            this.pgNumberLabel.Size = new System.Drawing.Size(147, 27);
            this.pgNumberLabel.TabIndex = 118;
            this.pgNumberLabel.Text = "Page 1000 of 3000";
            this.pgNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nextPageBtn.AutoSize = true;
            this.nextPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageBtn.DefaultForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nextPageBtn.ForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Location = new System.Drawing.Point(468, 6);
            this.nextPageBtn.Margin = new System.Windows.Forms.Padding(3);
            this.nextPageBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.nextPageBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Padding = new System.Windows.Forms.Padding(3);
            this.nextPageBtn.Size = new System.Drawing.Size(86, 27);
            this.nextPageBtn.TabIndex = 116;
            this.nextPageBtn.Text = "Next page";
            this.nextPageBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextPageBtn.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // viewTypeSelector
            // 
            this.viewTypeSelector.BackColor = System.Drawing.Color.White;
            this.viewTypeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.viewTypeSelector.FormattingEnabled = true;
            this.viewTypeSelector.Items.AddRange(new object[] {
            "One page",
            "Two pages",
            "Three pages",
            "Four pages"});
            this.viewTypeSelector.Location = new System.Drawing.Point(52, 9);
            this.viewTypeSelector.Name = "viewTypeSelector";
            this.viewTypeSelector.Size = new System.Drawing.Size(154, 21);
            this.viewTypeSelector.TabIndex = 119;
            this.viewTypeSelector.SelectedIndexChanged += new System.EventHandler(this.viewTypeSelector_SelectedIndexChanged);
            // 
            // zoomOutBtn
            // 
            this.zoomOutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomOutBtn.AutoSize = true;
            this.zoomOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.zoomOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomOutBtn.DefaultForeColor = System.Drawing.Color.White;
            this.zoomOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.zoomOutBtn.ForeColor = System.Drawing.Color.White;
            this.zoomOutBtn.Location = new System.Drawing.Point(608, 3);
            this.zoomOutBtn.Margin = new System.Windows.Forms.Padding(3);
            this.zoomOutBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.zoomOutBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.zoomOutBtn.Name = "zoomOutBtn";
            this.zoomOutBtn.Padding = new System.Windows.Forms.Padding(3);
            this.zoomOutBtn.Size = new System.Drawing.Size(84, 27);
            this.zoomOutBtn.TabIndex = 117;
            this.zoomOutBtn.Text = "Zoom out";
            this.zoomOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zoomOutBtn.Click += new System.EventHandler(this.zoomOutBtn_Click);
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.zoomInBtn.AutoSize = true;
            this.zoomInBtn.BackColor = System.Drawing.Color.Transparent;
            this.zoomInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomInBtn.DefaultForeColor = System.Drawing.Color.White;
            this.zoomInBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.zoomInBtn.ForeColor = System.Drawing.Color.White;
            this.zoomInBtn.Location = new System.Drawing.Point(692, 3);
            this.zoomInBtn.Margin = new System.Windows.Forms.Padding(3);
            this.zoomInBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.zoomInBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.zoomInBtn.Name = "zoomInBtn";
            this.zoomInBtn.Padding = new System.Windows.Forms.Padding(3);
            this.zoomInBtn.Size = new System.Drawing.Size(74, 27);
            this.zoomInBtn.TabIndex = 116;
            this.zoomInBtn.Text = "Zoom in";
            this.zoomInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.zoomInBtn.Click += new System.EventHandler(this.zoomInBtn_Click);
            // 
            // leftsmallPanel
            // 
            this.leftsmallPanel.Controls.Add(this.applyBtnLeft);
            this.leftsmallPanel.Controls.Add(this.decendOrder);
            this.leftsmallPanel.Controls.Add(this.label7);
            this.leftsmallPanel.Controls.Add(this.ColumnsToPrintLabel);
            this.leftsmallPanel.Controls.Add(this.exportToExcel);
            this.leftsmallPanel.Controls.Add(this.printPreviewBtn);
            this.leftsmallPanel.Controls.Add(this.columnsToPrintBox);
            this.leftsmallPanel.Controls.Add(this.label4);
            this.leftsmallPanel.Controls.Add(this.sortByBox);
            this.leftsmallPanel.Controls.Add(this.label1);
            this.leftsmallPanel.Controls.Add(this.typeSelector);
            this.leftsmallPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftsmallPanel.Location = new System.Drawing.Point(5, 5);
            this.leftsmallPanel.Name = "leftsmallPanel";
            this.leftsmallPanel.Size = new System.Drawing.Size(211, 672);
            this.leftsmallPanel.TabIndex = 117;
            // 
            // applyBtnLeft
            // 
            this.applyBtnLeft.AutoSize = true;
            this.applyBtnLeft.BackColor = System.Drawing.Color.Transparent;
            this.applyBtnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyBtnLeft.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.applyBtnLeft.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.applyBtnLeft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.applyBtnLeft.Location = new System.Drawing.Point(150, 10);
            this.applyBtnLeft.Margin = new System.Windows.Forms.Padding(3);
            this.applyBtnLeft.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.applyBtnLeft.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.applyBtnLeft.Name = "applyBtnLeft";
            this.applyBtnLeft.Padding = new System.Windows.Forms.Padding(3);
            this.applyBtnLeft.Size = new System.Drawing.Size(50, 25);
            this.applyBtnLeft.TabIndex = 141;
            this.applyBtnLeft.Text = "Apply";
            this.applyBtnLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.applyBtnLeft.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // decendOrder
            // 
            this.decendOrder.AutoSize = true;
            this.decendOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decendOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.decendOrder.Location = new System.Drawing.Point(88, 179);
            this.decendOrder.Name = "decendOrder";
            this.decendOrder.Size = new System.Drawing.Size(114, 21);
            this.decendOrder.TabIndex = 140;
            this.decendOrder.Text = "Descend order";
            this.decendOrder.UseVisualStyleBackColor = true;
            this.decendOrder.CheckedChanged += new System.EventHandler(this.decendOrder_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label7.Location = new System.Drawing.Point(2, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 136;
            this.label7.Text = "Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.zoomOutBtn);
            this.panel1.Controls.Add(this.zoomInBtn);
            this.panel1.Controls.Add(this.viewTypeSelector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(216, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(773, 36);
            this.panel1.TabIndex = 118;
            // 
            // reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.printCtrl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftsmallPanel);
            this.Controls.Add(this.toolPanel);
            this.Name = "reports";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1265, 682);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.leftsmallPanel.ResumeLayout(false);
            this.leftsmallPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.ComboBox typeSelector;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headerBox;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private CustomLabelButton printPreviewBtn;
        private CustomLabelButton showPageSetup;
        private System.Windows.Forms.PageSetupDialog pageSetup;
        private System.Windows.Forms.CheckedListBox columnsToPrintBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PrintPreviewControl printCtrl;
        private CustomLabelButton titleColorBtn;
        private CustomLabelButton titleFontBtn;
        private CustomLabelButton docColorBtn;
        private CustomLabelButton docFontBtn;
        private CustomLabelButton headerColorBtn;
        private CustomLabelButton headerFontBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private CustomLabelButton borderColorBtn;
        private CustomLabelButton headerBackcolorBtn;
        private System.Windows.Forms.Panel panel2;
        private CustomLabelButton nextPageBtn;
        private CustomLabelButton zoomOutBtn;
        private CustomLabelButton zoomInBtn;
        private System.Windows.Forms.Label pgNumberLabel;
        private CustomLabelButton prePageBtn;
        private CustomLabelButton applyBtn;
        private CustomLabelButton defaultValues;
        private System.Windows.Forms.Panel previewBorder;
        private System.Windows.Forms.Label previewDocument;
        private System.Windows.Forms.Label previewHeader;
        private System.Windows.Forms.Label ColumnsToPrintLabel;
        private System.Windows.Forms.ComboBox viewTypeSelector;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sortByBox;
        private CustomLabelButton exportToExcel;
        private System.Windows.Forms.Panel leftsmallPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox decendOrder;
        private CustomLabelButton applyBtnLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showDateCheck;
        private System.Windows.Forms.CheckBox showLineNumberCheck;
    }
}
