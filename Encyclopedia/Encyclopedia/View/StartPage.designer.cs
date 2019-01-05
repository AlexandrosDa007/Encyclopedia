namespace UI
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.logoLabel = new System.Windows.Forms.Label();
            this.newUserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.forgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.connectUserLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimizePictureBox = new System.Windows.Forms.PictureBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.recentButton = new System.Windows.Forms.Button();
            this.popularButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dateFilterLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.filterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.leftPanel.Controls.Add(this.feedbackLabel);
            this.leftPanel.Controls.Add(this.logoPanel);
            this.leftPanel.Controls.Add(this.newUserLinkLabel);
            this.leftPanel.Controls.Add(this.forgotPasswordLinkLabel);
            this.leftPanel.Controls.Add(this.usernameTextBox);
            this.leftPanel.Controls.Add(this.loginButton);
            this.leftPanel.Controls.Add(this.connectUserLabel);
            this.leftPanel.Controls.Add(this.passwordTextBox);
            this.leftPanel.Controls.Add(this.passwordLabel);
            this.leftPanel.Controls.Add(this.usernameLabel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(238, 640);
            this.leftPanel.TabIndex = 0;
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.feedbackLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.feedbackLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedbackLabel.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.feedbackLabel.ForeColor = System.Drawing.Color.White;
            this.feedbackLabel.Location = new System.Drawing.Point(0, 619);
            this.feedbackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(51, 21);
            this.feedbackLabel.TabIndex = 30;
            this.feedbackLabel.Text = "          ";
            this.feedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(238, 61);
            this.logoPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(17, 15);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(31, 33);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(52, 18);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(195, 32);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "Encyclopedia";
            this.logoLabel.Click += new System.EventHandler(this.logoLabel_Click);
            // 
            // newUserLinkLabel
            // 
            this.newUserLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.newUserLinkLabel.AutoSize = true;
            this.newUserLinkLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.newUserLinkLabel.LinkColor = System.Drawing.Color.White;
            this.newUserLinkLabel.Location = new System.Drawing.Point(88, 273);
            this.newUserLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newUserLinkLabel.Name = "newUserLinkLabel";
            this.newUserLinkLabel.Size = new System.Drawing.Size(57, 16);
            this.newUserLinkLabel.TabIndex = 5;
            this.newUserLinkLabel.TabStop = true;
            this.newUserLinkLabel.Text = "New user";
            this.newUserLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.newUserLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newUserLinkLabel_LinkClicked);
            // 
            // forgotPasswordLinkLabel
            // 
            this.forgotPasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.forgotPasswordLinkLabel.AutoSize = true;
            this.forgotPasswordLinkLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.forgotPasswordLinkLabel.LinkColor = System.Drawing.Color.White;
            this.forgotPasswordLinkLabel.Location = new System.Drawing.Point(69, 200);
            this.forgotPasswordLinkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.Size = new System.Drawing.Size(103, 16);
            this.forgotPasswordLinkLabel.TabIndex = 3;
            this.forgotPasswordLinkLabel.TabStop = true;
            this.forgotPasswordLinkLabel.Text = "Forgot password?";
            this.forgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(88, 123);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(139, 20);
            this.usernameTextBox.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.loginButton.Location = new System.Drawing.Point(66, 232);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // connectUserLabel
            // 
            this.connectUserLabel.AutoSize = true;
            this.connectUserLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.connectUserLabel.ForeColor = System.Drawing.Color.White;
            this.connectUserLabel.Location = new System.Drawing.Point(50, 75);
            this.connectUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.connectUserLabel.Name = "connectUserLabel";
            this.connectUserLabel.Size = new System.Drawing.Size(157, 25);
            this.connectUserLabel.TabIndex = 9;
            this.connectUserLabel.Text = "Connect User";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(88, 164);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(139, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(10, 163);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 19);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(10, 122);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "username:";
            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.Controls.Add(this.minimizePictureBox);
            this.topPanel.Controls.Add(this.closePictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(783, 34);
            this.topPanel.TabIndex = 1;
            // 
            // minimizePictureBox
            // 
            this.minimizePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizePictureBox.Image")));
            this.minimizePictureBox.Location = new System.Drawing.Point(707, 3);
            this.minimizePictureBox.Name = "minimizePictureBox";
            this.minimizePictureBox.Size = new System.Drawing.Size(32, 28);
            this.minimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.minimizePictureBox.TabIndex = 1;
            this.minimizePictureBox.TabStop = false;
            this.minimizePictureBox.Click += new System.EventHandler(this.minimizePictureBox_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(746, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(34, 28);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // recentButton
            // 
            this.recentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recentButton.AutoSize = true;
            this.recentButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.recentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.recentButton.Location = new System.Drawing.Point(410, 41);
            this.recentButton.Margin = new System.Windows.Forms.Padding(4);
            this.recentButton.Name = "recentButton";
            this.recentButton.Size = new System.Drawing.Size(190, 31);
            this.recentButton.TabIndex = 10;
            this.recentButton.Text = "Recent Lemmata";
            this.recentButton.UseVisualStyleBackColor = true;
            this.recentButton.Click += new System.EventHandler(this.recentButton_Click);
            // 
            // popularButton
            // 
            this.popularButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.popularButton.AutoSize = true;
            this.popularButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.popularButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.popularButton.Location = new System.Drawing.Point(162, 41);
            this.popularButton.Margin = new System.Windows.Forms.Padding(4);
            this.popularButton.Name = "popularButton";
            this.popularButton.Size = new System.Drawing.Size(188, 31);
            this.popularButton.TabIndex = 9;
            this.popularButton.Text = "Popular Lemmata";
            this.popularButton.UseVisualStyleBackColor = true;
            this.popularButton.Click += new System.EventHandler(this.popularButton_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.AutoSize = true;
            this.searchPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.mainPanel);
            this.searchPanel.Controls.Add(this.recentButton);
            this.searchPanel.Controls.Add(this.topPanel);
            this.searchPanel.Controls.Add(this.dateFilterLabel);
            this.searchPanel.Controls.Add(this.popularButton);
            this.searchPanel.Controls.Add(this.dateTimePicker);
            this.searchPanel.Controls.Add(this.filterCheckedListBox);
            this.searchPanel.Controls.Add(this.filtersLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(238, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(783, 640);
            this.searchPanel.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextBox.BackColor = System.Drawing.Color.Silver;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.searchTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.searchTextBox.Location = new System.Drawing.Point(162, 93);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(324, 34);
            this.searchTextBox.TabIndex = 16;
            this.searchTextBox.Text = " Search";
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.AutoSize = true;
            this.searchButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.searchButton.Location = new System.Drawing.Point(490, 93);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 33);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Location = new System.Drawing.Point(0, 249);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(779, 391);
            this.mainPanel.TabIndex = 12;
            // 
            // dateFilterLabel
            // 
            this.dateFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFilterLabel.AutoSize = true;
            this.dateFilterLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dateFilterLabel.Location = new System.Drawing.Point(204, 225);
            this.dateFilterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateFilterLabel.Name = "dateFilterLabel";
            this.dateFilterLabel.Size = new System.Drawing.Size(79, 19);
            this.dateFilterLabel.TabIndex = 7;
            this.dateFilterLabel.Text = "Date filter:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker.Location = new System.Drawing.Point(293, 225);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(207, 21);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // filterCheckedListBox
            // 
            this.filterCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filterCheckedListBox.FormattingEnabled = true;
            this.filterCheckedListBox.Items.AddRange(new object[] {
            " "});
            this.filterCheckedListBox.Location = new System.Drawing.Point(293, 141);
            this.filterCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.filterCheckedListBox.Name = "filterCheckedListBox";
            this.filterCheckedListBox.Size = new System.Drawing.Size(207, 80);
            this.filterCheckedListBox.TabIndex = 4;
            // 
            // filtersLabel
            // 
            this.filtersLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filtersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtersLabel.Location = new System.Drawing.Point(232, 141);
            this.filtersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(49, 19);
            this.filtersLabel.TabIndex = 3;
            this.filtersLabel.Text = "Filters:";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1021, 640);
            this.ControlBox = false;
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encyclopedia";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.LinkLabel newUserLinkLabel;
        private System.Windows.Forms.LinkLabel forgotPasswordLinkLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label connectUserLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button recentButton;
        private System.Windows.Forms.Button popularButton;
        private System.Windows.Forms.CheckedListBox filterCheckedListBox;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateFilterLabel;
        private System.Windows.Forms.PictureBox minimizePictureBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.TextBox searchTextBox;

        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.Panel mainPanel;
		public System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label feedbackLabel;
    }
}

