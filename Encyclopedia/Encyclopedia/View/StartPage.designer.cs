﻿namespace UI
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recentButton = new System.Windows.Forms.Button();
            this.popularButton = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.lemmaOfTheDayPanel = new System.Windows.Forms.Panel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lemmaOfTheDayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.lemmaOfTheDayLabel = new System.Windows.Forms.Label();
            this.dateFilterLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchTextbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.filterCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.filtersLabel = new System.Windows.Forms.Label();
            this.searchResultsPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.lemmaOfTheDayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
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
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(324, 805);
            this.leftPanel.TabIndex = 0;
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logoPanel.Controls.Add(this.logoPictureBox);
            this.logoPanel.Controls.Add(this.logoLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(324, 75);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.logoPanel_Paint);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(41, 22);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(44, 42);
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            this.logoPictureBox.Click += new System.EventHandler(this.logoPictureBox_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(97, 27);
            this.logoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(218, 37);
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
            this.newUserLinkLabel.Location = new System.Drawing.Point(113, 336);
            this.newUserLinkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.newUserLinkLabel.Name = "newUserLinkLabel";
            this.newUserLinkLabel.Size = new System.Drawing.Size(71, 19);
            this.newUserLinkLabel.TabIndex = 16;
            this.newUserLinkLabel.TabStop = true;
            this.newUserLinkLabel.Text = "New user";
            this.newUserLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // forgotPasswordLinkLabel
            // 
            this.forgotPasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.White;
            this.forgotPasswordLinkLabel.AutoSize = true;
            this.forgotPasswordLinkLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.forgotPasswordLinkLabel.LinkColor = System.Drawing.Color.White;
            this.forgotPasswordLinkLabel.Location = new System.Drawing.Point(92, 246);
            this.forgotPasswordLinkLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.forgotPasswordLinkLabel.Name = "forgotPasswordLinkLabel";
            this.forgotPasswordLinkLabel.Size = new System.Drawing.Size(129, 19);
            this.forgotPasswordLinkLabel.TabIndex = 15;
            this.forgotPasswordLinkLabel.TabStop = true;
            this.forgotPasswordLinkLabel.Text = "Forgot password?";
            this.forgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(117, 151);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(184, 22);
            this.usernameTextBox.TabIndex = 12;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.loginButton.Location = new System.Drawing.Point(88, 285);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(133, 34);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // connectUserLabel
            // 
            this.connectUserLabel.AutoSize = true;
            this.connectUserLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.connectUserLabel.ForeColor = System.Drawing.Color.White;
            this.connectUserLabel.Location = new System.Drawing.Point(92, 95);
            this.connectUserLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.connectUserLabel.Name = "connectUserLabel";
            this.connectUserLabel.Size = new System.Drawing.Size(142, 23);
            this.connectUserLabel.TabIndex = 9;
            this.connectUserLabel.Text = "Connect User";
            this.connectUserLabel.Click += new System.EventHandler(this.connectUserLabel_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(117, 202);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(184, 22);
            this.passwordTextBox.TabIndex = 13;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(7, 203);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(95, 21);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "password:";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Location = new System.Drawing.Point(5, 151);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(96, 21);
            this.usernameLabel.TabIndex = 11;
            this.usernameLabel.Text = "username:";
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1037, 42);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(940, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 28);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(987, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // recentButton
            // 
            this.recentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recentButton.AutoSize = true;
            this.recentButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.recentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.recentButton.Location = new System.Drawing.Point(590, 51);
            this.recentButton.Margin = new System.Windows.Forms.Padding(5);
            this.recentButton.Name = "recentButton";
            this.recentButton.Size = new System.Drawing.Size(249, 34);
            this.recentButton.TabIndex = 10;
            this.recentButton.Text = "Recent Lemmata";
            this.recentButton.UseVisualStyleBackColor = true;
            // 
            // popularButton
            // 
            this.popularButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.popularButton.AutoSize = true;
            this.popularButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.popularButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.popularButton.Location = new System.Drawing.Point(253, 51);
            this.popularButton.Margin = new System.Windows.Forms.Padding(5);
            this.popularButton.Name = "popularButton";
            this.popularButton.Size = new System.Drawing.Size(241, 34);
            this.popularButton.TabIndex = 9;
            this.popularButton.Text = "Popular Lemmata";
            this.popularButton.UseVisualStyleBackColor = true;
            // 
            // searchPanel
            // 
            this.searchPanel.AutoSize = true;
            this.searchPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.searchPanel.Controls.Add(this.lemmaOfTheDayPanel);
            this.searchPanel.Controls.Add(this.recentButton);
            this.searchPanel.Controls.Add(this.topPanel);
            this.searchPanel.Controls.Add(this.dateFilterLabel);
            this.searchPanel.Controls.Add(this.popularButton);
            this.searchPanel.Controls.Add(this.dateTimePicker);
            this.searchPanel.Controls.Add(this.searchTextbox);
            this.searchPanel.Controls.Add(this.filterCheckedListBox);
            this.searchPanel.Controls.Add(this.filtersLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel.Location = new System.Drawing.Point(324, 0);
            this.searchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(1037, 805);
            this.searchPanel.TabIndex = 2;
            this.searchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchPanel_Paint);
            // 
            // lemmaOfTheDayPanel
            // 
            this.lemmaOfTheDayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lemmaOfTheDayPanel.AutoScroll = true;
            this.lemmaOfTheDayPanel.Controls.Add(this.searchResultsPanel);
            this.lemmaOfTheDayPanel.Controls.Add(this.monthCalendar);
            this.lemmaOfTheDayPanel.Controls.Add(this.lemmaOfTheDayRichTextBox);
            this.lemmaOfTheDayPanel.Controls.Add(this.lemmaOfTheDayLabel);
            this.lemmaOfTheDayPanel.Location = new System.Drawing.Point(-4, 307);
            this.lemmaOfTheDayPanel.Name = "lemmaOfTheDayPanel";
            this.lemmaOfTheDayPanel.Size = new System.Drawing.Size(1036, 498);
            this.lemmaOfTheDayPanel.TabIndex = 12;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.monthCalendar.Location = new System.Drawing.Point(740, 75);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 17;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            // 
            // lemmaOfTheDayRichTextBox
            // 
            this.lemmaOfTheDayRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lemmaOfTheDayRichTextBox.BackColor = System.Drawing.Color.Gainsboro;
            this.lemmaOfTheDayRichTextBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lemmaOfTheDayRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lemmaOfTheDayRichTextBox.Location = new System.Drawing.Point(37, 75);
            this.lemmaOfTheDayRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lemmaOfTheDayRichTextBox.Name = "lemmaOfTheDayRichTextBox";
            this.lemmaOfTheDayRichTextBox.ReadOnly = true;
            this.lemmaOfTheDayRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.lemmaOfTheDayRichTextBox.Size = new System.Drawing.Size(678, 412);
            this.lemmaOfTheDayRichTextBox.TabIndex = 16;
            this.lemmaOfTheDayRichTextBox.Text = "";
            // 
            // lemmaOfTheDayLabel
            // 
            this.lemmaOfTheDayLabel.AutoSize = true;
            this.lemmaOfTheDayLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lemmaOfTheDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lemmaOfTheDayLabel.Location = new System.Drawing.Point(30, 19);
            this.lemmaOfTheDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lemmaOfTheDayLabel.Name = "lemmaOfTheDayLabel";
            this.lemmaOfTheDayLabel.Size = new System.Drawing.Size(279, 37);
            this.lemmaOfTheDayLabel.TabIndex = 15;
            this.lemmaOfTheDayLabel.Text = "Lemma of the day";
            // 
            // dateFilterLabel
            // 
            this.dateFilterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFilterLabel.AutoSize = true;
            this.dateFilterLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.dateFilterLabel.Location = new System.Drawing.Point(325, 259);
            this.dateFilterLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dateFilterLabel.Name = "dateFilterLabel";
            this.dateFilterLabel.Size = new System.Drawing.Size(97, 21);
            this.dateFilterLabel.TabIndex = 7;
            this.dateFilterLabel.Text = "Date filter:";
            this.dateFilterLabel.Click += new System.EventHandler(this.dateFilterLabel_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dateTimePicker.Location = new System.Drawing.Point(433, 256);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(279, 24);
            this.dateTimePicker.TabIndex = 6;
            // 
            // searchTextbox
            // 
            this.searchTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchTextbox.AutoSize = true;
            this.searchTextbox.BackColor = System.Drawing.Color.Silver;
            this.searchTextbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTextbox.BackgroundImage")));
            this.searchTextbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.searchTextbox.Icon = ((System.Drawing.Image)(resources.GetObject("searchTextbox.Icon")));
            this.searchTextbox.Location = new System.Drawing.Point(317, 109);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(471, 46);
            this.searchTextbox.TabIndex = 5;
            this.searchTextbox.text = "Search";
            // 
            // filterCheckedListBox
            // 
            this.filterCheckedListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filterCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filterCheckedListBox.FormattingEnabled = true;
            this.filterCheckedListBox.Items.AddRange(new object[] {
            "Academic disciplines",
            "Arts",
            "Business",
            "Concepts",
            "Culture",
            "Education",
            "Entertainment",
            "Events",
            "Geography",
            "Health",
            "History",
            "Humanities",
            "Language",
            "Law",
            "Life",
            "Mathematics",
            "Nature",
            "People",
            "Philosophy",
            "Politics",
            "Reference",
            "Religion",
            "Science",
            "Society",
            "Sports",
            "Technology",
            "Universe",
            "World"});
            this.filterCheckedListBox.Location = new System.Drawing.Point(433, 180);
            this.filterCheckedListBox.Margin = new System.Windows.Forms.Padding(5);
            this.filterCheckedListBox.Name = "filterCheckedListBox";
            this.filterCheckedListBox.Size = new System.Drawing.Size(267, 67);
            this.filterCheckedListBox.TabIndex = 4;
            // 
            // filtersLabel
            // 
            this.filtersLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filtersLabel.AutoSize = true;
            this.filtersLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.filtersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.filtersLabel.Location = new System.Drawing.Point(354, 182);
            this.filtersLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filtersLabel.Name = "filtersLabel";
            this.filtersLabel.Size = new System.Drawing.Size(59, 21);
            this.filtersLabel.TabIndex = 3;
            this.filtersLabel.Text = "Filters:";
            // 
            // searchResultsPanel
            // 
            this.searchResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResultsPanel.Location = new System.Drawing.Point(0, 0);
            this.searchResultsPanel.Name = "searchResultsPanel";
            this.searchResultsPanel.Size = new System.Drawing.Size(1036, 498);
            this.searchResultsPanel.TabIndex = 18;
            this.searchResultsPanel.Visible = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1361, 805);
            this.Controls.Add(this.searchPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartPage";
            this.Text = "Encyclopedia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.lemmaOfTheDayPanel.ResumeLayout(false);
            this.lemmaOfTheDayPanel.PerformLayout();
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
        private System.Windows.Forms.Panel searchPanel;
        private Bunifu.Framework.UI.BunifuTextbox searchTextbox;
        private System.Windows.Forms.CheckedListBox filterCheckedListBox;
        private System.Windows.Forms.Label filtersLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateFilterLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel lemmaOfTheDayPanel;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.RichTextBox lemmaOfTheDayRichTextBox;
        private System.Windows.Forms.Label lemmaOfTheDayLabel;
        private System.Windows.Forms.Panel searchResultsPanel;
    }
}

