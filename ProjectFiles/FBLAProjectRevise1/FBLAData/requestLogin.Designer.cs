namespace FBLAData
{
    partial class requestLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(requestLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new CustomLabelButton();
            this.loading = new FBLAData.loadingItem();
            this.cancelBtn = new CustomLabelButton();
            this.messageLabel = new System.Windows.Forms.Label();
            this.checkLogin = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Sign in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(25, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel1.Location = new System.Drawing.Point(29, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 1);
            this.panel1.TabIndex = 46;
            this.panel1.Tag = "border";
            // 
            // passBox
            // 
            this.passBox.AcceptsReturn = true;
            this.passBox.BackColor = System.Drawing.Color.White;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.passBox.Location = new System.Drawing.Point(29, 133);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(411, 22);
            this.passBox.TabIndex = 45;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.AutoSize = true;
            this.loginBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loginBtn.Location = new System.Drawing.Point(379, 175);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3);
            this.loginBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.loginBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Padding = new System.Windows.Forms.Padding(3);
            this.loginBtn.Size = new System.Drawing.Size(79, 27);
            this.loginBtn.TabIndex = 41;
            this.loginBtn.Text = "Continue";
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loading
            // 
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Image = ((System.Drawing.Image)(resources.GetObject("loading.Image")));
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(470, 214);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 49;
            this.loading.TabStop = false;
            this.loading.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.DefaultForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.cancelBtn.Location = new System.Drawing.Point(311, 175);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3);
            this.cancelBtn.MouseDownColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(196)))), ((int)(((byte)(191)))));
            this.cancelBtn.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(3);
            this.cancelBtn.Size = new System.Drawing.Size(62, 27);
            this.cancelBtn.TabIndex = 50;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.messageLabel.Location = new System.Drawing.Point(25, 41);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(433, 68);
            this.messageLabel.TabIndex = 51;
            this.messageLabel.Text = "[Message]";
            // 
            // checkLogin
            // 
            this.checkLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkLogin_DoWork);
            this.checkLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.checkLogin_RunWorkerCompleted);
            // 
            // requestLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(470, 214);
            this.ControlBox = false;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "requestLogin";
            this.Text = "Sign in request";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.requestLogin_FormClosing);
            this.Load += new System.EventHandler(this.requestLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passBox;
        private CustomLabelButton loginBtn;
        private loadingItem loading;
        private CustomLabelButton cancelBtn;
        private System.Windows.Forms.Label messageLabel;
        private System.ComponentModel.BackgroundWorker checkLogin;
    }
}