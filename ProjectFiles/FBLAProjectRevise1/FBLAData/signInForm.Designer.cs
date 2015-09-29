namespace FBLAData
{
    partial class signInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signInForm));
            this.loginBtn = new CustomLabelButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkLogin = new System.ComponentModel.BackgroundWorker();
            this.beginLoad = new System.ComponentModel.BackgroundWorker();
            this.loading = new FBLAData.loadingItem();
            this.userList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.AutoSize = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loginBtn.Enabled = false;
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loginBtn.Location = new System.Drawing.Point(377, 156);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3);
            this.loginBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.loginBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Padding = new System.Windows.Forms.Padding(3);
            this.loginBtn.Size = new System.Drawing.Size(64, 27);
            this.loginBtn.TabIndex = 16;
            this.loginBtn.Text = "Sign in";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel6.Location = new System.Drawing.Point(33, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 1);
            this.panel6.TabIndex = 35;
            this.panel6.Tag = "border";
            // 
            // usernameBox
            // 
            this.usernameBox.AcceptsReturn = true;
            this.usernameBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.usernameBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.usernameBox.BackColor = System.Drawing.Color.White;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Enabled = false;
            this.usernameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.usernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.usernameBox.Location = new System.Drawing.Point(33, 64);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(400, 22);
            this.usernameBox.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(29, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(33, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 38;
            this.panel1.Tag = "border";
            // 
            // passBox
            // 
            this.passBox.AcceptsReturn = true;
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Enabled = false;
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.passBox.Location = new System.Drawing.Point(33, 125);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(400, 22);
            this.passBox.TabIndex = 37;
            this.passBox.UseSystemPasswordChar = true;
            this.passBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passBox_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(203, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Sign in";
            // 
            // checkLogin
            // 
            this.checkLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkLogin_DoWork);
            this.checkLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkLogin_RunWorkerCompleted);
            // 
            // beginLoad
            // 
            this.beginLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.beginLoad_DoWork);
            this.beginLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.beginLoad_RunWorkerCompleted);
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(3, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(462, 410);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 42;
            this.loading.TabStop = false;
            this.loading.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loading.Visible = false;
            // 
            // userList
            // 
            this.userList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userList.BackColor = System.Drawing.Color.White;
            this.userList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.userList.FormattingEnabled = true;
            this.userList.ItemHeight = 20;
            this.userList.Location = new System.Drawing.Point(22, 241);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(421, 160);
            this.userList.TabIndex = 44;
            this.userList.DoubleClick += new System.EventHandler(this.userList_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label4.Location = new System.Drawing.Point(174, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Locked users";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label5.Location = new System.Drawing.Point(112, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Double click your user ID to sign back in";
            // 
            // signInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(468, 410);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "signInForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.signInForm_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.signInForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabelButton loginBtn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker checkLogin;
        private System.ComponentModel.BackgroundWorker beginLoad;
        private loadingItem loading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListBox userList;
    }
}

