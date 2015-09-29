namespace FBLAData
{
    partial class addMembers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMembers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.filesSelectBox = new System.Windows.Forms.TextBox();
            this.browseFileBtn = new CustomLabelButton();
            this.browseFile = new System.Windows.Forms.OpenFileDialog();
            this.importBtn = new CustomLabelButton();
            this.addMemberDataViewList = new System.Windows.Forms.DataGridView();
            this.contentHolder = new System.Windows.Forms.Panel();
            this.importLocationLabel = new System.Windows.Forms.Label();
            this.addAllnew = new System.Windows.Forms.RadioButton();
            this.overAndAppend = new System.Windows.Forms.RadioButton();
            this.importWorker = new System.ComponentModel.BackgroundWorker();
            this.addToDbWorker = new System.ComponentModel.BackgroundWorker();
            this.loading = new FBLAData.loadingItem();
            ((System.ComponentModel.ISupportInitialize)(this.addMemberDataViewList)).BeginInit();
            this.contentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 81;
            this.label1.Text = "Import";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(621, 69);
            this.label2.TabIndex = 82;
            this.label2.Text = "You can import Excel files (.xls, .xlsx)  with multiple sheets as long as the fir" +
    "st row is used as headers and each sheet match headers. Unrecognized headers wil" +
    "l be ignored. See help.";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel7.Location = new System.Drawing.Point(24, 215);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(549, 1);
            this.panel7.TabIndex = 84;
            this.panel7.Tag = "border";
            // 
            // filesSelectBox
            // 
            this.filesSelectBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filesSelectBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filesSelectBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.filesSelectBox.BackColor = System.Drawing.Color.White;
            this.filesSelectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filesSelectBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filesSelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.filesSelectBox.Location = new System.Drawing.Point(24, 195);
            this.filesSelectBox.Name = "filesSelectBox";
            this.filesSelectBox.ReadOnly = true;
            this.filesSelectBox.Size = new System.Drawing.Size(549, 18);
            this.filesSelectBox.TabIndex = 83;
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.browseFileBtn.AutoSize = true;
            this.browseFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.browseFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseFileBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.browseFileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFileBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.browseFileBtn.Location = new System.Drawing.Point(579, 189);
            this.browseFileBtn.Margin = new System.Windows.Forms.Padding(3);
            this.browseFileBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.browseFileBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Padding = new System.Windows.Forms.Padding(3);
            this.browseFileBtn.Size = new System.Drawing.Size(67, 27);
            this.browseFileBtn.TabIndex = 107;
            this.browseFileBtn.Text = "Browse";
            this.browseFileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.browseFileBtn.Click += new System.EventHandler(this.browseFileBtn_Click);
            // 
            // browseFile
            // 
            this.browseFile.Filter = "All Excel Files|*.xls; *.xlsx";
            this.browseFile.Title = "Pick file";
            this.browseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.browseFile_FileOk);
            // 
            // importBtn
            // 
            this.importBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.importBtn.AutoSize = true;
            this.importBtn.BackColor = System.Drawing.Color.Transparent;
            this.importBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.importBtn.Enabled = false;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.importBtn.Location = new System.Drawing.Point(591, 512);
            this.importBtn.Margin = new System.Windows.Forms.Padding(3);
            this.importBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.importBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.importBtn.Name = "importBtn";
            this.importBtn.Padding = new System.Windows.Forms.Padding(3);
            this.importBtn.Size = new System.Drawing.Size(63, 27);
            this.importBtn.TabIndex = 108;
            this.importBtn.Text = "Import";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // addMemberDataViewList
            // 
            this.addMemberDataViewList.AllowUserToAddRows = false;
            this.addMemberDataViewList.AllowUserToDeleteRows = false;
            this.addMemberDataViewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addMemberDataViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addMemberDataViewList.BackgroundColor = System.Drawing.Color.White;
            this.addMemberDataViewList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addMemberDataViewList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.addMemberDataViewList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addMemberDataViewList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.addMemberDataViewList.ColumnHeadersHeight = 55;
            this.addMemberDataViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.addMemberDataViewList.DefaultCellStyle = dataGridViewCellStyle2;
            this.addMemberDataViewList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.addMemberDataViewList.EnableHeadersVisualStyles = false;
            this.addMemberDataViewList.GridColor = System.Drawing.Color.DimGray;
            this.addMemberDataViewList.Location = new System.Drawing.Point(24, 223);
            this.addMemberDataViewList.MultiSelect = false;
            this.addMemberDataViewList.Name = "addMemberDataViewList";
            this.addMemberDataViewList.ReadOnly = true;
            this.addMemberDataViewList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.addMemberDataViewList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.addMemberDataViewList.RowHeadersVisible = false;
            this.addMemberDataViewList.RowTemplate.Height = 30;
            this.addMemberDataViewList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addMemberDataViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addMemberDataViewList.Size = new System.Drawing.Size(617, 209);
            this.addMemberDataViewList.TabIndex = 109;
            this.addMemberDataViewList.VirtualMode = true;
            // 
            // contentHolder
            // 
            this.contentHolder.Controls.Add(this.importLocationLabel);
            this.contentHolder.Controls.Add(this.addMemberDataViewList);
            this.contentHolder.Controls.Add(this.addAllnew);
            this.contentHolder.Controls.Add(this.overAndAppend);
            this.contentHolder.Controls.Add(this.label1);
            this.contentHolder.Controls.Add(this.label2);
            this.contentHolder.Controls.Add(this.importBtn);
            this.contentHolder.Controls.Add(this.filesSelectBox);
            this.contentHolder.Controls.Add(this.browseFileBtn);
            this.contentHolder.Controls.Add(this.panel7);
            this.contentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentHolder.Location = new System.Drawing.Point(0, 0);
            this.contentHolder.Name = "contentHolder";
            this.contentHolder.Size = new System.Drawing.Size(668, 564);
            this.contentHolder.TabIndex = 111;
            // 
            // importLocationLabel
            // 
            this.importLocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.importLocationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.importLocationLabel.Location = new System.Drawing.Point(20, 125);
            this.importLocationLabel.Name = "importLocationLabel";
            this.importLocationLabel.Size = new System.Drawing.Size(634, 69);
            this.importLocationLabel.TabIndex = 112;
            this.importLocationLabel.Text = "These members will be imported into this chapter: \r\nIf you want to import it usin" +
    "g the provided chapter numbers, set the chapter view to View All in Menu > Selec" +
    "t Chapter";
            // 
            // addAllnew
            // 
            this.addAllnew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addAllnew.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addAllnew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAllnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.addAllnew.Location = new System.Drawing.Point(338, 438);
            this.addAllnew.Name = "addAllnew";
            this.addAllnew.Size = new System.Drawing.Size(247, 113);
            this.addAllnew.TabIndex = 111;
            this.addAllnew.TabStop = true;
            this.addAllnew.Text = "Assign above members new membership numbers";
            this.addAllnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addAllnew.UseVisualStyleBackColor = true;
            // 
            // overAndAppend
            // 
            this.overAndAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.overAndAppend.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.overAndAppend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overAndAppend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.overAndAppend.Location = new System.Drawing.Point(15, 438);
            this.overAndAppend.Name = "overAndAppend";
            this.overAndAppend.Size = new System.Drawing.Size(317, 113);
            this.overAndAppend.TabIndex = 109;
            this.overAndAppend.TabStop = true;
            this.overAndAppend.Text = "Overwrite existing members with matching membership numbers with the above member" +
    "s and add any new members";
            this.overAndAppend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.overAndAppend.UseVisualStyleBackColor = true;
            // 
            // importWorker
            // 
            this.importWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.importWorker_DoWork);
            this.importWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.importWorker_RunWorkerCompleted);
            // 
            // addToDbWorker
            // 
            this.addToDbWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.addToDbWorker_DoWork);
            this.addToDbWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.addToDbWorker_RunWorkerCompleted);
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(668, 564);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 110;
            this.loading.TabStop = false;
            this.loading.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loading.Visible = false;
            // 
            // addMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.contentHolder);
            this.Controls.Add(this.loading);
            this.Name = "addMembers";
            this.Size = new System.Drawing.Size(668, 564);
            ((System.ComponentModel.ISupportInitialize)(this.addMemberDataViewList)).EndInit();
            this.contentHolder.ResumeLayout(false);
            this.contentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox filesSelectBox;
        private CustomLabelButton browseFileBtn;
        private System.Windows.Forms.OpenFileDialog browseFile;
        private CustomLabelButton importBtn;
        public System.Windows.Forms.DataGridView addMemberDataViewList;
        private loadingItem loading;
        private System.Windows.Forms.Panel contentHolder;
        private System.ComponentModel.BackgroundWorker importWorker;
        private System.Windows.Forms.RadioButton addAllnew;
        private System.Windows.Forms.RadioButton overAndAppend;
        private System.ComponentModel.BackgroundWorker addToDbWorker;
        private System.Windows.Forms.Label importLocationLabel;
    }
}
