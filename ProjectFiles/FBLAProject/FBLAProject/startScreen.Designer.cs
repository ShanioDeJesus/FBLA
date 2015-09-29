namespace FBLAProject
{
    partial class startScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startScreen));
            this.searchBtn = new CustomFlatButton.CustomFlatButton();
            this.newMemberBtn = new CustomFlatButton.CustomFlatButton();
            this.viewAllBtn = new CustomFlatButton.CustomFlatButton();
            this.reportBtn = new CustomFlatButton.CustomFlatButton();
            this.importBtn = new CustomFlatButton.CustomFlatButton();
            this.exportBtn = new CustomFlatButton.CustomFlatButton();
            this.bulkBtn = new CustomFlatButton.CustomFlatButton();
            this.settingsBtn = new CustomFlatButton.CustomFlatButton();
            this.customFlatButton1 = new CustomFlatButton.CustomFlatButton();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBtn.BackColor = System.Drawing.Color.Transparent;
            this.searchBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.searchBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.searchBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.searchBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.searchBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.searchBtn.Check = false;
            this.searchBtn.CheckColor = System.Drawing.Color.Empty;
            this.searchBtn.DefaultForeColor = System.Drawing.Color.White;
            this.searchBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = global::FBLAProject.Properties.Resources.searchmem;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchBtn.Location = new System.Drawing.Point(34, 158);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.searchBtn.Size = new System.Drawing.Size(157, 171);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search and Edit member";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // newMemberBtn
            // 
            this.newMemberBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newMemberBtn.BackColor = System.Drawing.Color.Transparent;
            this.newMemberBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.newMemberBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.newMemberBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.newMemberBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.newMemberBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.newMemberBtn.Check = false;
            this.newMemberBtn.CheckColor = System.Drawing.Color.Empty;
            this.newMemberBtn.DefaultForeColor = System.Drawing.Color.White;
            this.newMemberBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberBtn.ForeColor = System.Drawing.Color.White;
            this.newMemberBtn.Image = ((System.Drawing.Image)(resources.GetObject("newMemberBtn.Image")));
            this.newMemberBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newMemberBtn.Location = new System.Drawing.Point(404, 158);
            this.newMemberBtn.Margin = new System.Windows.Forms.Padding(14);
            this.newMemberBtn.Name = "newMemberBtn";
            this.newMemberBtn.Padding = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.newMemberBtn.Size = new System.Drawing.Size(157, 171);
            this.newMemberBtn.TabIndex = 15;
            this.newMemberBtn.Text = "Add new member";
            this.newMemberBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newMemberBtn.Click += new System.EventHandler(this.newMemberBtn_Click);
            // 
            // viewAllBtn
            // 
            this.viewAllBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.viewAllBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.viewAllBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.viewAllBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.viewAllBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.viewAllBtn.Check = false;
            this.viewAllBtn.CheckColor = System.Drawing.Color.Empty;
            this.viewAllBtn.DefaultForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllBtn.ForeColor = System.Drawing.Color.White;
            this.viewAllBtn.Image = global::FBLAProject.Properties.Resources.viewall;
            this.viewAllBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.viewAllBtn.Location = new System.Drawing.Point(219, 158);
            this.viewAllBtn.Margin = new System.Windows.Forms.Padding(14);
            this.viewAllBtn.Name = "viewAllBtn";
            this.viewAllBtn.Padding = new System.Windows.Forms.Padding(4);
            this.viewAllBtn.Size = new System.Drawing.Size(157, 171);
            this.viewAllBtn.TabIndex = 17;
            this.viewAllBtn.Text = "View exisiting members";
            this.viewAllBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.viewAllBtn.Click += new System.EventHandler(this.viewAllBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportBtn.BackColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.reportBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.reportBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.reportBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.reportBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.reportBtn.Check = false;
            this.reportBtn.CheckColor = System.Drawing.Color.Empty;
            this.reportBtn.DefaultForeColor = System.Drawing.Color.White;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.Color.White;
            this.reportBtn.Image = global::FBLAProject.Properties.Resources.print;
            this.reportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reportBtn.Location = new System.Drawing.Point(404, 386);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(14);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Padding = new System.Windows.Forms.Padding(4);
            this.reportBtn.Size = new System.Drawing.Size(157, 171);
            this.reportBtn.TabIndex = 18;
            this.reportBtn.Text = "Print reports";
            this.reportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.importBtn.BackColor = System.Drawing.Color.Transparent;
            this.importBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.importBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.importBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.importBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.importBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.importBtn.Check = false;
            this.importBtn.CheckColor = System.Drawing.Color.Empty;
            this.importBtn.DefaultForeColor = System.Drawing.Color.White;
            this.importBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importBtn.ForeColor = System.Drawing.Color.White;
            this.importBtn.Image = global::FBLAProject.Properties.Resources.imprt;
            this.importBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.importBtn.Location = new System.Drawing.Point(34, 386);
            this.importBtn.Margin = new System.Windows.Forms.Padding(14);
            this.importBtn.Name = "importBtn";
            this.importBtn.Padding = new System.Windows.Forms.Padding(4);
            this.importBtn.Size = new System.Drawing.Size(157, 171);
            this.importBtn.TabIndex = 19;
            this.importBtn.Text = "Import";
            this.importBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exportBtn.BackColor = System.Drawing.Color.Transparent;
            this.exportBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.exportBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.exportBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.exportBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.exportBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.exportBtn.Check = false;
            this.exportBtn.CheckColor = System.Drawing.Color.Empty;
            this.exportBtn.DefaultForeColor = System.Drawing.Color.White;
            this.exportBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.White;
            this.exportBtn.Image = global::FBLAProject.Properties.Resources.export1;
            this.exportBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.exportBtn.Location = new System.Drawing.Point(219, 386);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(14);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Padding = new System.Windows.Forms.Padding(4);
            this.exportBtn.Size = new System.Drawing.Size(157, 171);
            this.exportBtn.TabIndex = 20;
            this.exportBtn.Text = "Export";
            this.exportBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // bulkBtn
            // 
            this.bulkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bulkBtn.BackColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.bulkBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.bulkBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.bulkBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.bulkBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.bulkBtn.Check = false;
            this.bulkBtn.CheckColor = System.Drawing.Color.Empty;
            this.bulkBtn.DefaultForeColor = System.Drawing.Color.White;
            this.bulkBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bulkBtn.ForeColor = System.Drawing.Color.White;
            this.bulkBtn.Image = global::FBLAProject.Properties.Resources.bulkadd1;
            this.bulkBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bulkBtn.Location = new System.Drawing.Point(589, 158);
            this.bulkBtn.Margin = new System.Windows.Forms.Padding(14);
            this.bulkBtn.Name = "bulkBtn";
            this.bulkBtn.Padding = new System.Windows.Forms.Padding(4);
            this.bulkBtn.Size = new System.Drawing.Size(157, 171);
            this.bulkBtn.TabIndex = 21;
            this.bulkBtn.Text = "Bulk add new members";
            this.bulkBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bulkBtn.Click += new System.EventHandler(this.bulkBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonColor = System.Drawing.Color.Transparent;
            this.settingsBtn.ButtonDownColor = System.Drawing.Color.Gray;
            this.settingsBtn.ButtonDownTextColor = System.Drawing.Color.White;
            this.settingsBtn.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.settingsBtn.ButtonOverTextColor = System.Drawing.Color.White;
            this.settingsBtn.Check = false;
            this.settingsBtn.CheckColor = System.Drawing.Color.Empty;
            this.settingsBtn.DefaultForeColor = System.Drawing.Color.White;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Image = global::FBLAProject.Properties.Resources.settings;
            this.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settingsBtn.Location = new System.Drawing.Point(589, 386);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(14);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Padding = new System.Windows.Forms.Padding(4);
            this.settingsBtn.Size = new System.Drawing.Size(157, 171);
            this.settingsBtn.TabIndex = 22;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // customFlatButton1
            // 
            this.customFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.customFlatButton1.ButtonColor = System.Drawing.Color.Transparent;
            this.customFlatButton1.ButtonDownColor = System.Drawing.Color.Gray;
            this.customFlatButton1.ButtonDownTextColor = System.Drawing.Color.White;
            this.customFlatButton1.ButtonOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.customFlatButton1.ButtonOverTextColor = System.Drawing.Color.White;
            this.customFlatButton1.Check = false;
            this.customFlatButton1.CheckColor = System.Drawing.Color.Empty;
            this.customFlatButton1.DefaultForeColor = System.Drawing.Color.White;
            this.customFlatButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customFlatButton1.ForeColor = System.Drawing.Color.White;
            this.customFlatButton1.Image = global::FBLAProject.Properties.Resources.logout1;
            this.customFlatButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customFlatButton1.Location = new System.Drawing.Point(315, 580);
            this.customFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.customFlatButton1.Name = "customFlatButton1";
            this.customFlatButton1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.customFlatButton1.Size = new System.Drawing.Size(150, 73);
            this.customFlatButton1.TabIndex = 35;
            this.customFlatButton1.Text = "Log out";
            this.customFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.customFlatButton1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.newMemberBtn);
            this.Controls.Add(this.viewAllBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.bulkBtn);
            this.Controls.Add(this.settingsBtn);
            this.Name = "startScreen";
            this.Size = new System.Drawing.Size(775, 708);
            this.Load += new System.EventHandler(this.startScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomFlatButton.CustomFlatButton searchBtn;
        private CustomFlatButton.CustomFlatButton newMemberBtn;
        private CustomFlatButton.CustomFlatButton viewAllBtn;
        private CustomFlatButton.CustomFlatButton reportBtn;
        private CustomFlatButton.CustomFlatButton importBtn;
        private CustomFlatButton.CustomFlatButton exportBtn;
        private CustomFlatButton.CustomFlatButton bulkBtn;
        private CustomFlatButton.CustomFlatButton settingsBtn;
        public CustomFlatButton.CustomFlatButton customFlatButton1;
    }
}
