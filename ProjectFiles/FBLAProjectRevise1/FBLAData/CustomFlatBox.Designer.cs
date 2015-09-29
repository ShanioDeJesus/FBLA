namespace FBLAData
{
    partial class CustomFlatBox
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.BottomBorder = new System.Windows.Forms.Panel();
            this.Topborder = new System.Windows.Forms.Panel();
            this.LeftBorder = new System.Windows.Forms.Panel();
            this.RightBorder = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TextBox.BackColor = System.Drawing.Color.White;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Location = new System.Drawing.Point(6, 6);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(199, 18);
            this.TextBox.TabIndex = 0;
            this.TextBox.BackColorChanged += new System.EventHandler(this.TextBox_BackColorChanged);
            this.TextBox.ForeColorChanged += new System.EventHandler(this.TextBox_ForeColorChanged);
            // 
            // BottomBorder
            // 
            this.BottomBorder.BackColor = System.Drawing.Color.Black;
            this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBorder.ForeColor = System.Drawing.Color.White;
            this.BottomBorder.Location = new System.Drawing.Point(0, 29);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(211, 1);
            this.BottomBorder.TabIndex = 66;
            this.BottomBorder.Tag = "border";
            // 
            // Topborder
            // 
            this.Topborder.BackColor = System.Drawing.Color.Black;
            this.Topborder.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topborder.ForeColor = System.Drawing.Color.White;
            this.Topborder.Location = new System.Drawing.Point(0, 0);
            this.Topborder.Name = "Topborder";
            this.Topborder.Size = new System.Drawing.Size(211, 1);
            this.Topborder.TabIndex = 67;
            this.Topborder.Tag = "border";
            // 
            // LeftBorder
            // 
            this.LeftBorder.BackColor = System.Drawing.Color.Black;
            this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBorder.ForeColor = System.Drawing.Color.White;
            this.LeftBorder.Location = new System.Drawing.Point(0, 1);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(1, 28);
            this.LeftBorder.TabIndex = 68;
            this.LeftBorder.Tag = "border";
            // 
            // RightBorder
            // 
            this.RightBorder.BackColor = System.Drawing.Color.Black;
            this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightBorder.ForeColor = System.Drawing.Color.White;
            this.RightBorder.Location = new System.Drawing.Point(210, 1);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(1, 28);
            this.RightBorder.TabIndex = 69;
            this.RightBorder.Tag = "border";
            // 
            // CustomFlatBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.Topborder);
            this.Controls.Add(this.BottomBorder);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CustomFlatBox";
            this.Size = new System.Drawing.Size(211, 30);
            this.BackColorChanged += new System.EventHandler(this.CustomFlatBox_BackColorChanged);
            this.ForeColorChanged += new System.EventHandler(this.CustomFlatBox_ForeColorChanged);
            this.Click += new System.EventHandler(this.CustomFlatBox_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel BottomBorder;
        public System.Windows.Forms.Panel Topborder;
        public System.Windows.Forms.Panel LeftBorder;
        public System.Windows.Forms.Panel RightBorder;
        public System.Windows.Forms.TextBox TextBox;
    }
}
