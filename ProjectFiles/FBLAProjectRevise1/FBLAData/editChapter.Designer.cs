namespace FBLAData
{
    partial class editChapter
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
            this.components = new System.ComponentModel.Container();
            this.chapterSaveChanges = new CustomLabelButton();
            this.label24 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chapterAdvisorBox = new System.Windows.Forms.TextBox();
            this.chapterState = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.chapterFax = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.chapterPhone = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.chapterEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chapterCity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.chapterZip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chapterStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chapterSchool = new System.Windows.Forms.TextBox();
            this.loadInfo = new System.ComponentModel.BackgroundWorker();
            this.saveChanges = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.contentHolder = new System.Windows.Forms.Panel();
            this.autoFillBtn = new CustomLabelButton();
            this.removeChapterBtn = new CustomLabelButton();
            this.label2 = new System.Windows.Forms.Label();
            this.districtBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.tTip = new System.Windows.Forms.ToolTip(this.components);
            this.deleteChapter = new System.ComponentModel.BackgroundWorker();
            this.autoFill = new System.ComponentModel.BackgroundWorker();
            this.loading = new FBLAData.loadingItem();
            this.contentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).BeginInit();
            this.SuspendLayout();
            // 
            // chapterSaveChanges
            // 
            this.chapterSaveChanges.AutoSize = true;
            this.chapterSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chapterSaveChanges.DefaultForeColor = System.Drawing.Color.White;
            this.chapterSaveChanges.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterSaveChanges.ForeColor = System.Drawing.Color.White;
            this.chapterSaveChanges.Location = new System.Drawing.Point(174, 747);
            this.chapterSaveChanges.Margin = new System.Windows.Forms.Padding(3);
            this.chapterSaveChanges.MouseDownColor = System.Drawing.Color.Gray;
            this.chapterSaveChanges.MouseOverColor = System.Drawing.Color.Silver;
            this.chapterSaveChanges.Name = "chapterSaveChanges";
            this.chapterSaveChanges.Padding = new System.Windows.Forms.Padding(3);
            this.chapterSaveChanges.Size = new System.Drawing.Size(110, 27);
            this.chapterSaveChanges.TabIndex = 106;
            this.chapterSaveChanges.Text = "Save changes";
            this.chapterSaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chapterSaveChanges.Click += new System.EventHandler(this.chapterSaveChanges_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label24.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(23, 571);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 21);
            this.label24.TabIndex = 105;
            this.label24.Text = "Advisors";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(28, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 1);
            this.panel2.TabIndex = 104;
            this.panel2.Tag = "border";
            // 
            // chapterAdvisorBox
            // 
            this.chapterAdvisorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterAdvisorBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterAdvisorBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterAdvisorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterAdvisorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterAdvisorBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterAdvisorBox.ForeColor = System.Drawing.Color.White;
            this.chapterAdvisorBox.Location = new System.Drawing.Point(28, 638);
            this.chapterAdvisorBox.Multiline = true;
            this.chapterAdvisorBox.Name = "chapterAdvisorBox";
            this.chapterAdvisorBox.Size = new System.Drawing.Size(258, 70);
            this.chapterAdvisorBox.TabIndex = 103;
            // 
            // chapterState
            // 
            this.chapterState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chapterState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterState.ForeColor = System.Drawing.Color.White;
            this.chapterState.FormattingEnabled = true;
            this.chapterState.Items.AddRange(new object[] {
            "(AK) Alaska",
            "(AL) Alabama",
            "(AR) Arkansas",
            "(AZ) Arizona",
            "(CA) California",
            "(CO) Colorado",
            "(CT) Connecticut",
            "(DC) District of Columbia",
            "(DE) Delaware",
            "(FL) Florida",
            "(GA) Georgia",
            "(HI) Hawaii",
            "(IA) Iowa",
            "(ID) Idaho",
            "(IL) Illinois",
            "(IN) Indiana",
            "(KS) Kansas",
            "(KY) Kentucky",
            "(LA) Louisiana",
            "(MA) Massachusetts",
            "(MD) Maryland",
            "(ME) Maine",
            "(MI) Michigan",
            "(MN) Minnesota",
            "(MO) Missouri",
            "(MS) Mississippi",
            "(MT) Montana",
            "(NC) North Carolina",
            "(ND) North Dakota",
            "(NE) Nebraska",
            "(NH) New Hampshire",
            "(NJ) New Jersey",
            "(NM) New Mexico",
            "(NV) Nevada",
            "(NY) New York",
            "(OH) Ohio",
            "(OK) Oklahoma",
            "(OR) Oregon",
            "(PA) Pennsylvania",
            "(RI) Rhode Island",
            "(SC) South Carolina",
            "(SD) South Dakota",
            "(TN) Tennessee",
            "(TX) Texas",
            "(UT) Utah",
            "(VA) Virginia",
            "(VT)Vermont",
            "(WA) Washington",
            "(WI) Wisconsin",
            "(WV) West Virginia",
            "(WY) Wyoming"});
            this.chapterState.Location = new System.Drawing.Point(28, 163);
            this.chapterState.Name = "chapterState";
            this.chapterState.Size = new System.Drawing.Size(258, 23);
            this.chapterState.TabIndex = 98;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(24, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 21);
            this.label15.TabIndex = 97;
            this.label15.Text = "Fax";
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.ForeColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(29, 558);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(257, 1);
            this.panel11.TabIndex = 96;
            this.panel11.Tag = "border";
            // 
            // chapterFax
            // 
            this.chapterFax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterFax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterFax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterFax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterFax.ForeColor = System.Drawing.Color.White;
            this.chapterFax.Location = new System.Drawing.Point(29, 538);
            this.chapterFax.Name = "chapterFax";
            this.chapterFax.Size = new System.Drawing.Size(257, 18);
            this.chapterFax.TabIndex = 95;
            this.tTip.SetToolTip(this.chapterFax, "This field can only contain numbers and dashes");
            this.chapterFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chapterPhone_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(24, 386);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 21);
            this.label14.TabIndex = 94;
            this.label14.Text = "Phone number";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(28, 430);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(258, 1);
            this.panel10.TabIndex = 93;
            this.panel10.Tag = "border";
            // 
            // chapterPhone
            // 
            this.chapterPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterPhone.ForeColor = System.Drawing.Color.White;
            this.chapterPhone.Location = new System.Drawing.Point(28, 410);
            this.chapterPhone.Name = "chapterPhone";
            this.chapterPhone.Size = new System.Drawing.Size(258, 18);
            this.chapterPhone.TabIndex = 92;
            this.tTip.SetToolTip(this.chapterPhone, "This field can only contain numbers and dashes");
            this.chapterPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chapterPhone_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 451);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 21);
            this.label13.TabIndex = 91;
            this.label13.Text = "Email";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.ForeColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(29, 495);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(257, 1);
            this.panel9.TabIndex = 90;
            this.panel9.Tag = "border";
            // 
            // chapterEmail
            // 
            this.chapterEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterEmail.ForeColor = System.Drawing.Color.White;
            this.chapterEmail.Location = new System.Drawing.Point(29, 475);
            this.chapterEmail.Name = "chapterEmail";
            this.chapterEmail.Size = new System.Drawing.Size(257, 18);
            this.chapterEmail.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 21);
            this.label12.TabIndex = 88;
            this.label12.Text = "City";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(28, 309);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 1);
            this.panel5.TabIndex = 87;
            this.panel5.Tag = "border";
            // 
            // chapterCity
            // 
            this.chapterCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterCity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterCity.ForeColor = System.Drawing.Color.White;
            this.chapterCity.Location = new System.Drawing.Point(28, 289);
            this.chapterCity.Name = "chapterCity";
            this.chapterCity.Size = new System.Drawing.Size(258, 18);
            this.chapterCity.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(24, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 21);
            this.label10.TabIndex = 85;
            this.label10.Text = "State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(24, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 21);
            this.label7.TabIndex = 84;
            this.label7.Text = "Zip code";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(28, 247);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 1);
            this.panel8.TabIndex = 83;
            this.panel8.Tag = "border";
            // 
            // chapterZip
            // 
            this.chapterZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterZip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterZip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterZip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterZip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterZip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterZip.ForeColor = System.Drawing.Color.White;
            this.chapterZip.Location = new System.Drawing.Point(28, 227);
            this.chapterZip.Name = "chapterZip";
            this.chapterZip.Size = new System.Drawing.Size(258, 18);
            this.chapterZip.TabIndex = 82;
            this.tTip.SetToolTip(this.chapterZip, "This field can only contain numbers and dashes");
            this.chapterZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chapterPhone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 21);
            this.label6.TabIndex = 81;
            this.label6.Text = "Street name";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(29, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 1);
            this.panel3.TabIndex = 80;
            this.panel3.Tag = "border";
            // 
            // chapterStreet
            // 
            this.chapterStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterStreet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterStreet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterStreet.ForeColor = System.Drawing.Color.White;
            this.chapterStreet.Location = new System.Drawing.Point(29, 106);
            this.chapterStreet.Name = "chapterStreet";
            this.chapterStreet.Size = new System.Drawing.Size(257, 18);
            this.chapterStreet.TabIndex = 79;
            this.chapterStreet.Text = "gpDamonte Ranch";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(24, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 77;
            this.label8.Text = "School";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(29, 67);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(257, 1);
            this.panel7.TabIndex = 76;
            this.panel7.Tag = "border";
            // 
            // chapterSchool
            // 
            this.chapterSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterSchool.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterSchool.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.chapterSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.chapterSchool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chapterSchool.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.chapterSchool.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterSchool.ForeColor = System.Drawing.Color.White;
            this.chapterSchool.Location = new System.Drawing.Point(29, 47);
            this.chapterSchool.Name = "chapterSchool";
            this.chapterSchool.Size = new System.Drawing.Size(257, 18);
            this.chapterSchool.TabIndex = 75;
            this.chapterSchool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chapterSchool_KeyDown);
            // 
            // loadInfo
            // 
            this.loadInfo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadInfo_DoWork);
            this.loadInfo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadInfo_RunWorkerCompleted);
            // 
            // saveChanges
            // 
            this.saveChanges.DoWork += new System.ComponentModel.DoWorkEventHandler(this.saveChanges_DoWork);
            this.saveChanges.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.saveChanges_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 597);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 38);
            this.label1.TabIndex = 108;
            this.label1.Text = "Seperate each advisor\'s name with a comma\r\n(Ex. Advisor 1, Advisor 2).";
            // 
            // contentHolder
            // 
            this.contentHolder.AutoScroll = true;
            this.contentHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.contentHolder.Controls.Add(this.autoFillBtn);
            this.contentHolder.Controls.Add(this.removeChapterBtn);
            this.contentHolder.Controls.Add(this.label2);
            this.contentHolder.Controls.Add(this.districtBox);
            this.contentHolder.Controls.Add(this.panel1);
            this.contentHolder.Controls.Add(this.errorLabel);
            this.contentHolder.Controls.Add(this.panel7);
            this.contentHolder.Controls.Add(this.label1);
            this.contentHolder.Controls.Add(this.chapterSchool);
            this.contentHolder.Controls.Add(this.chapterSaveChanges);
            this.contentHolder.Controls.Add(this.label8);
            this.contentHolder.Controls.Add(this.label24);
            this.contentHolder.Controls.Add(this.chapterStreet);
            this.contentHolder.Controls.Add(this.panel2);
            this.contentHolder.Controls.Add(this.panel3);
            this.contentHolder.Controls.Add(this.chapterAdvisorBox);
            this.contentHolder.Controls.Add(this.label6);
            this.contentHolder.Controls.Add(this.chapterState);
            this.contentHolder.Controls.Add(this.chapterZip);
            this.contentHolder.Controls.Add(this.label15);
            this.contentHolder.Controls.Add(this.panel8);
            this.contentHolder.Controls.Add(this.panel11);
            this.contentHolder.Controls.Add(this.label7);
            this.contentHolder.Controls.Add(this.chapterFax);
            this.contentHolder.Controls.Add(this.label10);
            this.contentHolder.Controls.Add(this.label14);
            this.contentHolder.Controls.Add(this.chapterCity);
            this.contentHolder.Controls.Add(this.panel10);
            this.contentHolder.Controls.Add(this.panel5);
            this.contentHolder.Controls.Add(this.chapterPhone);
            this.contentHolder.Controls.Add(this.label12);
            this.contentHolder.Controls.Add(this.label13);
            this.contentHolder.Controls.Add(this.chapterEmail);
            this.contentHolder.Controls.Add(this.panel9);
            this.contentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentHolder.Location = new System.Drawing.Point(0, 0);
            this.contentHolder.Name = "contentHolder";
            this.contentHolder.Size = new System.Drawing.Size(313, 790);
            this.contentHolder.TabIndex = 109;
            // 
            // autoFillBtn
            // 
            this.autoFillBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autoFillBtn.AutoSize = true;
            this.autoFillBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.autoFillBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoFillBtn.DefaultForeColor = System.Drawing.Color.White;
            this.autoFillBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoFillBtn.ForeColor = System.Drawing.Color.White;
            this.autoFillBtn.Location = new System.Drawing.Point(224, 23);
            this.autoFillBtn.Margin = new System.Windows.Forms.Padding(3);
            this.autoFillBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.autoFillBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.autoFillBtn.Name = "autoFillBtn";
            this.autoFillBtn.Padding = new System.Windows.Forms.Padding(3);
            this.autoFillBtn.Size = new System.Drawing.Size(66, 27);
            this.autoFillBtn.TabIndex = 114;
            this.autoFillBtn.Text = "Autofill";
            this.autoFillBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autoFillBtn.Click += new System.EventHandler(this.autoFillBtn_Click);
            // 
            // removeChapterBtn
            // 
            this.removeChapterBtn.AutoSize = true;
            this.removeChapterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.removeChapterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeChapterBtn.DefaultForeColor = System.Drawing.Color.White;
            this.removeChapterBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeChapterBtn.ForeColor = System.Drawing.Color.White;
            this.removeChapterBtn.Location = new System.Drawing.Point(23, 747);
            this.removeChapterBtn.Margin = new System.Windows.Forms.Padding(3);
            this.removeChapterBtn.MouseDownColor = System.Drawing.Color.Gray;
            this.removeChapterBtn.MouseOverColor = System.Drawing.Color.Silver;
            this.removeChapterBtn.Name = "removeChapterBtn";
            this.removeChapterBtn.Padding = new System.Windows.Forms.Padding(3);
            this.removeChapterBtn.Size = new System.Drawing.Size(145, 27);
            this.removeChapterBtn.TabIndex = 113;
            this.removeChapterBtn.Text = "Delete this chapter";
            this.removeChapterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.removeChapterBtn.Click += new System.EventHandler(this.removeChapterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 112;
            this.label2.Text = "District";
            // 
            // districtBox
            // 
            this.districtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.districtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.districtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.districtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.districtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.districtBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtBox.ForeColor = System.Drawing.Color.White;
            this.districtBox.Location = new System.Drawing.Point(28, 351);
            this.districtBox.Name = "districtBox";
            this.districtBox.Size = new System.Drawing.Size(258, 18);
            this.districtBox.TabIndex = 110;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 1);
            this.panel1.TabIndex = 111;
            this.panel1.Tag = "border";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoEllipsis = true;
            this.errorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.errorLabel.Location = new System.Drawing.Point(24, 723);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.errorLabel.Size = new System.Drawing.Size(262, 21);
            this.errorLabel.TabIndex = 109;
            this.errorLabel.Text = "None";
            this.errorLabel.Visible = false;
            // 
            // tTip
            // 
            this.tTip.AutoPopDelay = 5000;
            this.tTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.tTip.ForeColor = System.Drawing.Color.White;
            this.tTip.InitialDelay = 0;
            this.tTip.IsBalloon = true;
            this.tTip.ReshowDelay = 0;
            // 
            // deleteChapter
            // 
            this.deleteChapter.DoWork += new System.ComponentModel.DoWorkEventHandler(this.deleteChapter_DoWork);
            this.deleteChapter.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.deleteChapter_RunWorkerCompleted);
            // 
            // autoFill
            // 
            this.autoFill.DoWork += new System.ComponentModel.DoWorkEventHandler(this.autoFill_DoWork);
            this.autoFill.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.autoFill_RunWorkerCompleted);
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Image = global::FBLAData.Properties.Resources.blueloading;
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(313, 790);
            this.loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loading.TabIndex = 110;
            this.loading.TabStop = false;
            this.loading.TextColor = System.Drawing.Color.White;
            this.loading.Visible = false;
            // 
            // editChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.Controls.Add(this.contentHolder);
            this.Controls.Add(this.loading);
            this.Name = "editChapter";
            this.Size = new System.Drawing.Size(313, 790);
            this.contentHolder.ResumeLayout(false);
            this.contentHolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomLabelButton chapterSaveChanges;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox chapterAdvisorBox;
        private System.Windows.Forms.ComboBox chapterState;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox chapterFax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox chapterPhone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox chapterEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox chapterCity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox chapterZip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox chapterStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.ComponentModel.BackgroundWorker loadInfo;
        public System.Windows.Forms.TextBox chapterSchool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contentHolder;
        public System.ComponentModel.BackgroundWorker saveChanges;
        private System.Windows.Forms.ToolTip tTip;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox districtBox;
        private System.Windows.Forms.Panel panel1;
        private CustomLabelButton removeChapterBtn;
        private System.ComponentModel.BackgroundWorker deleteChapter;
        private CustomLabelButton autoFillBtn;
        public System.ComponentModel.BackgroundWorker autoFill;
        public loadingItem loading;
    }
}
