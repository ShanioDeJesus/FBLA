namespace FBLAData
{
    partial class customPrintPreview
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
            this.toolBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.viewTypeSelector = new System.Windows.Forms.ComboBox();
            this.printBtn = new CustomLabelButton();
            this.titleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.maxrestoreBtn = new CustomFlatButton();
            this.closeBtn = new CustomFlatButton();
            this.topBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.toprightresize = new System.Windows.Forms.Panel();
            this.bottomrightresize = new System.Windows.Forms.Panel();
            this.leftBorder = new System.Windows.Forms.Panel();
            this.topleftresize = new System.Windows.Forms.Panel();
            this.bottomleftresize = new System.Windows.Forms.Panel();
            this.printCtrl = new System.Windows.Forms.PrintPreviewControl();
            this.zoomInBtn = new CustomLabelButton();
            this.zoomOutBtn = new CustomLabelButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nextPageBtn = new CustomLabelButton();
            this.pgNumberLabel = new System.Windows.Forms.Label();
            this.prePageBtn = new CustomLabelButton();
            this.toolBar.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.rightBorder.SuspendLayout();
            this.leftBorder.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.toolBar.Controls.Add(this.label2);
            this.toolBar.Controls.Add(this.viewTypeSelector);
            this.toolBar.Controls.Add(this.printBtn);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(5, 54);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(792, 38);
            this.toolBar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 115;
            this.label2.Text = "View";
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
            this.viewTypeSelector.Location = new System.Drawing.Point(57, 9);
            this.viewTypeSelector.Name = "viewTypeSelector";
            this.viewTypeSelector.Size = new System.Drawing.Size(188, 21);
            this.viewTypeSelector.TabIndex = 114;
            this.viewTypeSelector.SelectedIndexChanged += new System.EventHandler(this.viewTypeSelector_SelectedIndexChanged);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.AutoSize = true;
            this.printBtn.BackColor = System.Drawing.Color.Transparent;
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.DefaultForeColor = System.Drawing.Color.White;
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(736, 5);
            this.printBtn.Margin = new System.Windows.Forms.Padding(3);
            this.printBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.printBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.printBtn.Name = "printBtn";
            this.printBtn.Padding = new System.Windows.Forms.Padding(3);
            this.printBtn.Size = new System.Drawing.Size(49, 27);
            this.printBtn.TabIndex = 49;
            this.printBtn.Text = "Print";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Controls.Add(this.maxrestoreBtn);
            this.titleBar.Controls.Add(this.closeBtn);
            this.titleBar.Controls.Add(this.topBorder);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(5, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(792, 54);
            this.titleBar.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "Print Preview";
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
            this.maxrestoreBtn.Location = new System.Drawing.Point(696, 5);
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
            this.closeBtn.Location = new System.Drawing.Point(744, 5);
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
            this.topBorder.Size = new System.Drawing.Size(792, 5);
            this.topBorder.TabIndex = 63;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.bottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(5, 573);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(792, 5);
            this.bottomBorder.TabIndex = 65;
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.rightBorder.Controls.Add(this.toprightresize);
            this.rightBorder.Controls.Add(this.bottomrightresize);
            this.rightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(797, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(5, 578);
            this.rightBorder.TabIndex = 64;
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
            this.bottomrightresize.Location = new System.Drawing.Point(-3, 565);
            this.bottomrightresize.Name = "bottomrightresize";
            this.bottomrightresize.Size = new System.Drawing.Size(10, 16);
            this.bottomrightresize.TabIndex = 57;
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
            this.leftBorder.Size = new System.Drawing.Size(5, 578);
            this.leftBorder.TabIndex = 63;
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
            this.bottomleftresize.Location = new System.Drawing.Point(-2, 565);
            this.bottomleftresize.Name = "bottomleftresize";
            this.bottomleftresize.Size = new System.Drawing.Size(10, 16);
            this.bottomleftresize.TabIndex = 0;
            // 
            // printCtrl
            // 
            this.printCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.printCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printCtrl.Location = new System.Drawing.Point(5, 92);
            this.printCtrl.Name = "printCtrl";
            this.printCtrl.Size = new System.Drawing.Size(792, 481);
            this.printCtrl.TabIndex = 67;
            // 
            // zoomInBtn
            // 
            this.zoomInBtn.AutoSize = true;
            this.zoomInBtn.BackColor = System.Drawing.Color.Transparent;
            this.zoomInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomInBtn.DefaultForeColor = System.Drawing.Color.White;
            this.zoomInBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.zoomInBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.zoomInBtn.ForeColor = System.Drawing.Color.White;
            this.zoomInBtn.Location = new System.Drawing.Point(715, 3);
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
            // zoomOutBtn
            // 
            this.zoomOutBtn.AutoSize = true;
            this.zoomOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.zoomOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zoomOutBtn.DefaultForeColor = System.Drawing.Color.White;
            this.zoomOutBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.zoomOutBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.zoomOutBtn.ForeColor = System.Drawing.Color.White;
            this.zoomOutBtn.Location = new System.Drawing.Point(631, 3);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.nextPageBtn);
            this.panel1.Controls.Add(this.zoomOutBtn);
            this.panel1.Controls.Add(this.zoomInBtn);
            this.panel1.Controls.Add(this.pgNumberLabel);
            this.panel1.Controls.Add(this.prePageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 537);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(792, 36);
            this.panel1.TabIndex = 68;
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.AutoSize = true;
            this.nextPageBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextPageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextPageBtn.DefaultForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.nextPageBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nextPageBtn.ForeColor = System.Drawing.Color.White;
            this.nextPageBtn.Location = new System.Drawing.Point(264, 3);
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
            // pgNumberLabel
            // 
            this.pgNumberLabel.AutoSize = true;
            this.pgNumberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pgNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pgNumberLabel.ForeColor = System.Drawing.Color.White;
            this.pgNumberLabel.Location = new System.Drawing.Point(117, 3);
            this.pgNumberLabel.Name = "pgNumberLabel";
            this.pgNumberLabel.Padding = new System.Windows.Forms.Padding(3);
            this.pgNumberLabel.Size = new System.Drawing.Size(147, 27);
            this.pgNumberLabel.TabIndex = 118;
            this.pgNumberLabel.Text = "Page 1000 of 3000";
            this.pgNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prePageBtn
            // 
            this.prePageBtn.AutoSize = true;
            this.prePageBtn.BackColor = System.Drawing.Color.Transparent;
            this.prePageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prePageBtn.DefaultForeColor = System.Drawing.Color.White;
            this.prePageBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.prePageBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.prePageBtn.ForeColor = System.Drawing.Color.White;
            this.prePageBtn.Location = new System.Drawing.Point(3, 3);
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
            // customPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printCtrl);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.rightBorder);
            this.Controls.Add(this.leftBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "customPrintPreview";
            this.Text = "customPrintPreview";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.rightBorder.ResumeLayout(false);
            this.leftBorder.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel toolBar;
        public System.Windows.Forms.Panel titleBar;
        public CustomFlatButton maxrestoreBtn;
        public CustomFlatButton closeBtn;
        private System.Windows.Forms.Panel topBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel toprightresize;
        private System.Windows.Forms.Panel bottomrightresize;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Panel topleftresize;
        private System.Windows.Forms.Panel bottomleftresize;
        private System.Windows.Forms.Label label1;
        private CustomLabelButton printBtn;
        private System.Windows.Forms.PrintPreviewControl printCtrl;
        private CustomLabelButton zoomOutBtn;
        private CustomLabelButton zoomInBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox viewTypeSelector;
        private System.Windows.Forms.Panel panel1;
        private CustomLabelButton prePageBtn;
        private CustomLabelButton nextPageBtn;
        private System.Windows.Forms.Label pgNumberLabel;
    }
}