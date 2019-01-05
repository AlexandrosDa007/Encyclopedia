namespace Encyclopedia.View
{
    partial class ProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
			this.closePictureBox = new System.Windows.Forms.PictureBox();
			this.topPanel = new System.Windows.Forms.Panel();
			this.imagePathLabel = new System.Windows.Forms.Label();
			this.educationLabel = new System.Windows.Forms.Label();
			this.professionLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.dateOfBirthLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.telLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordConfirmLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.imagePathTB = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.roleCB = new System.Windows.Forms.ComboBox();
			this.educationLevelCB = new System.Windows.Forms.ComboBox();
			this.imagePB = new System.Windows.Forms.PictureBox();
			this.dateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
			this.genderFemaleRB = new System.Windows.Forms.RadioButton();
			this.genderMaleRB = new System.Windows.Forms.RadioButton();
			this.descriptionRTB = new System.Windows.Forms.RichTextBox();
			this.genderGroupBox = new System.Windows.Forms.GroupBox();
			this.telTexBox = new System.Windows.Forms.MaskedTextBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.passwordConfirmTextBox = new System.Windows.Forms.TextBox();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.editButton = new System.Windows.Forms.Button();
			this.browseButton = new System.Windows.Forms.Button();
			this.feedbackLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
			this.genderGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// closePictureBox
			// 
			this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
			this.closePictureBox.Location = new System.Drawing.Point(814, 12);
			this.closePictureBox.Name = "closePictureBox";
			this.closePictureBox.Size = new System.Drawing.Size(25, 19);
			this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePictureBox.TabIndex = 0;
			this.closePictureBox.TabStop = false;
			this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.Color.Transparent;
			this.topPanel.Controls.Add(this.closePictureBox);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(851, 41);
			this.topPanel.TabIndex = 57;
			// 
			// imagePathLabel
			// 
			this.imagePathLabel.AutoSize = true;
			this.imagePathLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.imagePathLabel.Location = new System.Drawing.Point(114, 671);
			this.imagePathLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.imagePathLabel.Name = "imagePathLabel";
			this.imagePathLabel.Size = new System.Drawing.Size(114, 21);
			this.imagePathLabel.TabIndex = 56;
			this.imagePathLabel.Text = "Image Path";
			// 
			// educationLabel
			// 
			this.educationLabel.AutoSize = true;
			this.educationLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.educationLabel.Location = new System.Drawing.Point(82, 492);
			this.educationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.educationLabel.Name = "educationLabel";
			this.educationLabel.Size = new System.Drawing.Size(146, 21);
			this.educationLabel.TabIndex = 55;
			this.educationLabel.Text = "Education level";
			// 
			// professionLabel
			// 
			this.professionLabel.AutoSize = true;
			this.professionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.professionLabel.Location = new System.Drawing.Point(132, 539);
			this.professionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.professionLabel.Name = "professionLabel";
			this.professionLabel.Size = new System.Drawing.Size(96, 21);
			this.professionLabel.TabIndex = 54;
			this.professionLabel.Text = "Profession";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.descriptionLabel.Location = new System.Drawing.Point(121, 586);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(107, 21);
			this.descriptionLabel.TabIndex = 53;
			this.descriptionLabel.Text = "Description";
			// 
			// dateOfBirthLabel
			// 
			this.dateOfBirthLabel.AutoSize = true;
			this.dateOfBirthLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.dateOfBirthLabel.Location = new System.Drawing.Point(106, 449);
			this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dateOfBirthLabel.Name = "dateOfBirthLabel";
			this.dateOfBirthLabel.Size = new System.Drawing.Size(132, 21);
			this.dateOfBirthLabel.TabIndex = 52;
			this.dateOfBirthLabel.Text = "Date of birth *";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.surnameLabel.Location = new System.Drawing.Point(139, 115);
			this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(99, 21);
			this.surnameLabel.TabIndex = 51;
			this.surnameLabel.Text = "Surname *";
			// 
			// telLabel
			// 
			this.telLabel.AutoSize = true;
			this.telLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.telLabel.Location = new System.Drawing.Point(52, 157);
			this.telLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.telLabel.Name = "telLabel";
			this.telLabel.Size = new System.Drawing.Size(176, 21);
			this.telLabel.TabIndex = 50;
			this.telLabel.Text = "Telephone number";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.emailLabel.Location = new System.Drawing.Point(171, 200);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(67, 21);
			this.emailLabel.TabIndex = 49;
			this.emailLabel.Text = "Email *";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.usernameLabel.Location = new System.Drawing.Point(128, 244);
			this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(110, 21);
			this.usernameLabel.TabIndex = 48;
			this.usernameLabel.Text = "Username *";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.passwordLabel.Location = new System.Drawing.Point(136, 288);
			this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(102, 21);
			this.passwordLabel.TabIndex = 47;
			this.passwordLabel.Text = "Password *";
			// 
			// passwordConfirmLabel
			// 
			this.passwordConfirmLabel.AutoSize = true;
			this.passwordConfirmLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.passwordConfirmLabel.Location = new System.Drawing.Point(61, 333);
			this.passwordConfirmLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.passwordConfirmLabel.Name = "passwordConfirmLabel";
			this.passwordConfirmLabel.Size = new System.Drawing.Size(177, 21);
			this.passwordConfirmLabel.TabIndex = 46;
			this.passwordConfirmLabel.Text = "Confirm password *";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.nameLabel.Location = new System.Drawing.Point(162, 77);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(76, 21);
			this.nameLabel.TabIndex = 45;
			this.nameLabel.Text = "Name *";
			// 
			// imagePathTB
			// 
			this.imagePathTB.BackColor = System.Drawing.SystemColors.Window;
			this.imagePathTB.Enabled = false;
			this.imagePathTB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.imagePathTB.Location = new System.Drawing.Point(264, 668);
			this.imagePathTB.Margin = new System.Windows.Forms.Padding(2);
			this.imagePathTB.Name = "imagePathTB";
			this.imagePathTB.ReadOnly = true;
			this.imagePathTB.Size = new System.Drawing.Size(200, 27);
			this.imagePathTB.TabIndex = 42;
			// 
			// saveButton
			// 
			this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.saveButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.saveButton.Location = new System.Drawing.Point(661, 694);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(151, 33);
			this.saveButton.TabIndex = 44;
			this.saveButton.Text = "Save changes";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Visible = false;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
			// 
			// roleCB
			// 
			this.roleCB.BackColor = System.Drawing.SystemColors.Window;
			this.roleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.roleCB.Enabled = false;
			this.roleCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roleCB.FormattingEnabled = true;
			this.roleCB.Location = new System.Drawing.Point(264, 536);
			this.roleCB.Margin = new System.Windows.Forms.Padding(2);
			this.roleCB.Name = "roleCB";
			this.roleCB.Size = new System.Drawing.Size(200, 29);
			this.roleCB.TabIndex = 40;
			// 
			// educationLevelCB
			// 
			this.educationLevelCB.BackColor = System.Drawing.SystemColors.Window;
			this.educationLevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.educationLevelCB.Enabled = false;
			this.educationLevelCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.educationLevelCB.FormattingEnabled = true;
			this.educationLevelCB.Location = new System.Drawing.Point(264, 489);
			this.educationLevelCB.Margin = new System.Windows.Forms.Padding(2);
			this.educationLevelCB.Name = "educationLevelCB";
			this.educationLevelCB.Size = new System.Drawing.Size(200, 29);
			this.educationLevelCB.TabIndex = 39;
			// 
			// imagePB
			// 
			this.imagePB.Image = ((System.Drawing.Image)(resources.GetObject("imagePB.Image")));
			this.imagePB.Location = new System.Drawing.Point(496, 74);
			this.imagePB.Margin = new System.Windows.Forms.Padding(2);
			this.imagePB.Name = "imagePB";
			this.imagePB.Size = new System.Drawing.Size(146, 146);
			this.imagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagePB.TabIndex = 38;
			this.imagePB.TabStop = false;
			// 
			// dateOfBirthDTP
			// 
			this.dateOfBirthDTP.Enabled = false;
			this.dateOfBirthDTP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateOfBirthDTP.Location = new System.Drawing.Point(264, 444);
			this.dateOfBirthDTP.Margin = new System.Windows.Forms.Padding(2);
			this.dateOfBirthDTP.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.dateOfBirthDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateOfBirthDTP.Name = "dateOfBirthDTP";
			this.dateOfBirthDTP.Size = new System.Drawing.Size(200, 27);
			this.dateOfBirthDTP.TabIndex = 37;
			this.dateOfBirthDTP.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			// 
			// genderFemaleRB
			// 
			this.genderFemaleRB.AutoSize = true;
			this.genderFemaleRB.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.genderFemaleRB.Location = new System.Drawing.Point(121, 29);
			this.genderFemaleRB.Margin = new System.Windows.Forms.Padding(2);
			this.genderFemaleRB.Name = "genderFemaleRB";
			this.genderFemaleRB.Size = new System.Drawing.Size(85, 25);
			this.genderFemaleRB.TabIndex = 8;
			this.genderFemaleRB.Text = "Female";
			this.genderFemaleRB.UseVisualStyleBackColor = true;
			// 
			// genderMaleRB
			// 
			this.genderMaleRB.AutoSize = true;
			this.genderMaleRB.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.genderMaleRB.Location = new System.Drawing.Point(121, 0);
			this.genderMaleRB.Margin = new System.Windows.Forms.Padding(2);
			this.genderMaleRB.Name = "genderMaleRB";
			this.genderMaleRB.Size = new System.Drawing.Size(67, 25);
			this.genderMaleRB.TabIndex = 7;
			this.genderMaleRB.Text = "Male";
			this.genderMaleRB.UseVisualStyleBackColor = true;
			// 
			// descriptionRTB
			// 
			this.descriptionRTB.BackColor = System.Drawing.SystemColors.Window;
			this.descriptionRTB.Enabled = false;
			this.descriptionRTB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionRTB.Location = new System.Drawing.Point(264, 583);
			this.descriptionRTB.Margin = new System.Windows.Forms.Padding(2);
			this.descriptionRTB.MaxLength = 250;
			this.descriptionRTB.Name = "descriptionRTB";
			this.descriptionRTB.Size = new System.Drawing.Size(200, 66);
			this.descriptionRTB.TabIndex = 41;
			this.descriptionRTB.Text = "";
			// 
			// genderGroupBox
			// 
			this.genderGroupBox.Controls.Add(this.genderFemaleRB);
			this.genderGroupBox.Controls.Add(this.genderMaleRB);
			this.genderGroupBox.Enabled = false;
			this.genderGroupBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.genderGroupBox.Location = new System.Drawing.Point(143, 375);
			this.genderGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.genderGroupBox.Name = "genderGroupBox";
			this.genderGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.genderGroupBox.Size = new System.Drawing.Size(236, 55);
			this.genderGroupBox.TabIndex = 36;
			this.genderGroupBox.TabStop = false;
			this.genderGroupBox.Text = "Gender";
			// 
			// telTexBox
			// 
			this.telTexBox.BackColor = System.Drawing.SystemColors.Window;
			this.telTexBox.Enabled = false;
			this.telTexBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telTexBox.Location = new System.Drawing.Point(264, 157);
			this.telTexBox.Margin = new System.Windows.Forms.Padding(2);
			this.telTexBox.Mask = "(999) 000-0000";
			this.telTexBox.Name = "telTexBox";
			this.telTexBox.Size = new System.Drawing.Size(200, 27);
			this.telTexBox.TabIndex = 31;
			this.telTexBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.passwordTextBox.Enabled = false;
			this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(264, 288);
			this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.passwordTextBox.MaxLength = 40;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(200, 27);
			this.passwordTextBox.TabIndex = 34;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.usernameTextBox.Enabled = false;
			this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.Location = new System.Drawing.Point(264, 244);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.usernameTextBox.MaxLength = 40;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.ReadOnly = true;
			this.usernameTextBox.Size = new System.Drawing.Size(200, 27);
			this.usernameTextBox.TabIndex = 33;
			// 
			// emailTextBox
			// 
			this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.emailTextBox.Enabled = false;
			this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.Location = new System.Drawing.Point(264, 200);
			this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.emailTextBox.MaxLength = 60;
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(200, 27);
			this.emailTextBox.TabIndex = 32;
			// 
			// passwordConfirmTextBox
			// 
			this.passwordConfirmTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.passwordConfirmTextBox.Enabled = false;
			this.passwordConfirmTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordConfirmTextBox.Location = new System.Drawing.Point(264, 333);
			this.passwordConfirmTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.passwordConfirmTextBox.MaxLength = 40;
			this.passwordConfirmTextBox.Name = "passwordConfirmTextBox";
			this.passwordConfirmTextBox.Size = new System.Drawing.Size(200, 27);
			this.passwordConfirmTextBox.TabIndex = 35;
			this.passwordConfirmTextBox.UseSystemPasswordChar = true;
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.surnameTextBox.Enabled = false;
			this.surnameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surnameTextBox.Location = new System.Drawing.Point(264, 115);
			this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.surnameTextBox.MaxLength = 50;
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(200, 27);
			this.surnameTextBox.TabIndex = 30;
			// 
			// nameTextBox
			// 
			this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.nameTextBox.Enabled = false;
			this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTextBox.Location = new System.Drawing.Point(264, 74);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameTextBox.MaxLength = 40;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(200, 27);
			this.nameTextBox.TabIndex = 29;
			// 
			// editButton
			// 
			this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.editButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.editButton.Location = new System.Drawing.Point(687, 74);
			this.editButton.Margin = new System.Windows.Forms.Padding(2);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(125, 29);
			this.editButton.TabIndex = 58;
			this.editButton.Text = "Edit Profile";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// browseButton
			// 
			this.browseButton.Enabled = false;
			this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.browseButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.browseButton.Location = new System.Drawing.Point(468, 668);
			this.browseButton.Margin = new System.Windows.Forms.Padding(2);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(89, 26);
			this.browseButton.TabIndex = 59;
			this.browseButton.Text = "Browse";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// feedbackLabel1
			// 
			this.feedbackLabel1.BackColor = System.Drawing.Color.Transparent;
			this.feedbackLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.feedbackLabel1.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.feedbackLabel1.Location = new System.Drawing.Point(0, 736);
			this.feedbackLabel1.Name = "feedbackLabel1";
			this.feedbackLabel1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
			this.feedbackLabel1.Size = new System.Drawing.Size(851, 51);
			this.feedbackLabel1.TabIndex = 61;
			this.feedbackLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ProfileForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(851, 787);
			this.Controls.Add(this.feedbackLabel1);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.imagePathLabel);
			this.Controls.Add(this.educationLabel);
			this.Controls.Add(this.professionLabel);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.dateOfBirthLabel);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.telLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordConfirmLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.imagePathTB);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.roleCB);
			this.Controls.Add(this.educationLevelCB);
			this.Controls.Add(this.imagePB);
			this.Controls.Add(this.dateOfBirthDTP);
			this.Controls.Add(this.descriptionRTB);
			this.Controls.Add(this.genderGroupBox);
			this.Controls.Add(this.telTexBox);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.passwordConfirmTextBox);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.nameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "ProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfileForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
			this.genderGroupBox.ResumeLayout(false);
			this.genderGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label telLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordConfirmLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox imagePathTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.ComboBox educationLevelCB;
        private System.Windows.Forms.PictureBox imagePB;
        private System.Windows.Forms.DateTimePicker dateOfBirthDTP;
        private System.Windows.Forms.RadioButton genderFemaleRB;
        private System.Windows.Forms.RadioButton genderMaleRB;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.MaskedTextBox telTexBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordConfirmTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label feedbackLabel1;
    }
}