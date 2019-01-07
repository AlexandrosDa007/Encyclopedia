﻿namespace Encyclopedia.View
{
    partial class ContactsProfileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsProfileForm));
			this.topPanel = new System.Windows.Forms.Panel();
			this.closePictureBox = new System.Windows.Forms.PictureBox();
			this.educationLabel = new System.Windows.Forms.Label();
			this.professionLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.dateOfBirthLabel = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.emailLabel = new System.Windows.Forms.Label();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.roleCB = new System.Windows.Forms.ComboBox();
			this.educationLevelCB = new System.Windows.Forms.ComboBox();
			this.imagePB = new System.Windows.Forms.PictureBox();
			this.dateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
			this.descriptionRTB = new System.Windows.Forms.RichTextBox();
			this.genderGroupBox = new System.Windows.Forms.GroupBox();
			this.genderFemaleRB = new System.Windows.Forms.RadioButton();
			this.genderMaleRB = new System.Windows.Forms.RadioButton();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.surnameTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.contactProfileLabel = new System.Windows.Forms.Label();
			this.addButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
			this.genderGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// topPanel
			// 
			this.topPanel.AutoSize = true;
			this.topPanel.BackColor = System.Drawing.Color.Transparent;
			this.topPanel.Controls.Add(this.closePictureBox);
			this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.topPanel.Location = new System.Drawing.Point(0, 0);
			this.topPanel.Margin = new System.Windows.Forms.Padding(4);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(800, 36);
			this.topPanel.TabIndex = 30;
			// 
			// closePictureBox
			// 
			this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
			this.closePictureBox.Location = new System.Drawing.Point(762, 13);
			this.closePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.closePictureBox.Name = "closePictureBox";
			this.closePictureBox.Size = new System.Drawing.Size(25, 19);
			this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePictureBox.TabIndex = 0;
			this.closePictureBox.TabStop = false;
			this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
			// 
			// educationLabel
			// 
			this.educationLabel.AutoSize = true;
			this.educationLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.educationLabel.Location = new System.Drawing.Point(100, 471);
			this.educationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.educationLabel.Name = "educationLabel";
			this.educationLabel.Size = new System.Drawing.Size(146, 21);
			this.educationLabel.TabIndex = 73;
			this.educationLabel.Text = "Education level";
			// 
			// professionLabel
			// 
			this.professionLabel.AutoSize = true;
			this.professionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.professionLabel.Location = new System.Drawing.Point(150, 518);
			this.professionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.professionLabel.Name = "professionLabel";
			this.professionLabel.Size = new System.Drawing.Size(96, 21);
			this.professionLabel.TabIndex = 72;
			this.professionLabel.Text = "Profession";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.AutoSize = true;
			this.descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.descriptionLabel.Location = new System.Drawing.Point(139, 565);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Size = new System.Drawing.Size(107, 21);
			this.descriptionLabel.TabIndex = 71;
			this.descriptionLabel.Text = "Description";
			// 
			// dateOfBirthLabel
			// 
			this.dateOfBirthLabel.AutoSize = true;
			this.dateOfBirthLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.dateOfBirthLabel.Location = new System.Drawing.Point(124, 428);
			this.dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.dateOfBirthLabel.Name = "dateOfBirthLabel";
			this.dateOfBirthLabel.Size = new System.Drawing.Size(125, 21);
			this.dateOfBirthLabel.TabIndex = 70;
			this.dateOfBirthLabel.Text = "Date of birth ";
			// 
			// surnameLabel
			// 
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.surnameLabel.Location = new System.Drawing.Point(157, 181);
			this.surnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(92, 21);
			this.surnameLabel.TabIndex = 69;
			this.surnameLabel.Text = "Surname ";
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.emailLabel.Location = new System.Drawing.Point(189, 256);
			this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(60, 21);
			this.emailLabel.TabIndex = 68;
			this.emailLabel.Text = "Email ";
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.usernameLabel.Location = new System.Drawing.Point(146, 300);
			this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(103, 21);
			this.usernameLabel.TabIndex = 67;
			this.usernameLabel.Text = "Username ";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.nameLabel.Location = new System.Drawing.Point(180, 143);
			this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(69, 21);
			this.nameLabel.TabIndex = 66;
			this.nameLabel.Text = "Name ";
			// 
			// roleCB
			// 
			this.roleCB.BackColor = System.Drawing.SystemColors.Window;
			this.roleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.roleCB.Enabled = false;
			this.roleCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.roleCB.FormattingEnabled = true;
			this.roleCB.Location = new System.Drawing.Point(282, 515);
			this.roleCB.Margin = new System.Windows.Forms.Padding(2);
			this.roleCB.Name = "roleCB";
			this.roleCB.Size = new System.Drawing.Size(213, 29);
			this.roleCB.TabIndex = 64;
			// 
			// educationLevelCB
			// 
			this.educationLevelCB.BackColor = System.Drawing.SystemColors.Window;
			this.educationLevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.educationLevelCB.Enabled = false;
			this.educationLevelCB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.educationLevelCB.FormattingEnabled = true;
			this.educationLevelCB.Location = new System.Drawing.Point(282, 468);
			this.educationLevelCB.Margin = new System.Windows.Forms.Padding(2);
			this.educationLevelCB.Name = "educationLevelCB";
			this.educationLevelCB.Size = new System.Drawing.Size(213, 29);
			this.educationLevelCB.TabIndex = 63;
			// 
			// imagePB
			// 
			this.imagePB.Image = ((System.Drawing.Image)(resources.GetObject("imagePB.Image")));
			this.imagePB.Location = new System.Drawing.Point(561, 140);
			this.imagePB.Margin = new System.Windows.Forms.Padding(2);
			this.imagePB.Name = "imagePB";
			this.imagePB.Size = new System.Drawing.Size(146, 146);
			this.imagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imagePB.TabIndex = 62;
			this.imagePB.TabStop = false;
			// 
			// dateOfBirthDTP
			// 
			this.dateOfBirthDTP.Enabled = false;
			this.dateOfBirthDTP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateOfBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateOfBirthDTP.Location = new System.Drawing.Point(282, 423);
			this.dateOfBirthDTP.Margin = new System.Windows.Forms.Padding(2);
			this.dateOfBirthDTP.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.dateOfBirthDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateOfBirthDTP.Name = "dateOfBirthDTP";
			this.dateOfBirthDTP.Size = new System.Drawing.Size(213, 27);
			this.dateOfBirthDTP.TabIndex = 61;
			this.dateOfBirthDTP.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			// 
			// descriptionRTB
			// 
			this.descriptionRTB.BackColor = System.Drawing.SystemColors.Window;
			this.descriptionRTB.Enabled = false;
			this.descriptionRTB.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.descriptionRTB.Location = new System.Drawing.Point(282, 562);
			this.descriptionRTB.Margin = new System.Windows.Forms.Padding(2);
			this.descriptionRTB.MaxLength = 250;
			this.descriptionRTB.Name = "descriptionRTB";
			this.descriptionRTB.Size = new System.Drawing.Size(213, 81);
			this.descriptionRTB.TabIndex = 65;
			this.descriptionRTB.Text = "";
			// 
			// genderGroupBox
			// 
			this.genderGroupBox.Controls.Add(this.genderFemaleRB);
			this.genderGroupBox.Controls.Add(this.genderMaleRB);
			this.genderGroupBox.Enabled = false;
			this.genderGroupBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.genderGroupBox.Location = new System.Drawing.Point(161, 349);
			this.genderGroupBox.Margin = new System.Windows.Forms.Padding(2);
			this.genderGroupBox.Name = "genderGroupBox";
			this.genderGroupBox.Padding = new System.Windows.Forms.Padding(2);
			this.genderGroupBox.Size = new System.Drawing.Size(236, 55);
			this.genderGroupBox.TabIndex = 60;
			this.genderGroupBox.TabStop = false;
			this.genderGroupBox.Text = "Gender";
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
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.usernameTextBox.Enabled = false;
			this.usernameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.Location = new System.Drawing.Point(282, 300);
			this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.usernameTextBox.MaxLength = 40;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.ReadOnly = true;
			this.usernameTextBox.Size = new System.Drawing.Size(213, 27);
			this.usernameTextBox.TabIndex = 59;
			// 
			// emailTextBox
			// 
			this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.emailTextBox.Enabled = false;
			this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailTextBox.Location = new System.Drawing.Point(282, 256);
			this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.emailTextBox.MaxLength = 60;
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(213, 27);
			this.emailTextBox.TabIndex = 58;
			// 
			// surnameTextBox
			// 
			this.surnameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.surnameTextBox.Enabled = false;
			this.surnameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surnameTextBox.Location = new System.Drawing.Point(282, 181);
			this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.surnameTextBox.MaxLength = 50;
			this.surnameTextBox.Name = "surnameTextBox";
			this.surnameTextBox.Size = new System.Drawing.Size(213, 27);
			this.surnameTextBox.TabIndex = 57;
			// 
			// nameTextBox
			// 
			this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.nameTextBox.Enabled = false;
			this.nameTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameTextBox.Location = new System.Drawing.Point(282, 140);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameTextBox.MaxLength = 40;
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(213, 27);
			this.nameTextBox.TabIndex = 56;
			// 
			// contactProfileLabel
			// 
			this.contactProfileLabel.AutoSize = true;
			this.contactProfileLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactProfileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactProfileLabel.Location = new System.Drawing.Point(47, 61);
			this.contactProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.contactProfileLabel.Name = "contactProfileLabel";
			this.contactProfileLabel.Size = new System.Drawing.Size(226, 36);
			this.contactProfileLabel.TabIndex = 74;
			this.contactProfileLabel.Text = "Contact profile";
			// 
			// addButton
			// 
			this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.addButton.Location = new System.Drawing.Point(561, 658);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(151, 33);
			this.addButton.TabIndex = 75;
			this.addButton.Text = "Add contact";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Visible = false;
			// 
			// removeButton
			// 
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.removeButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.removeButton.Location = new System.Drawing.Point(561, 649);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(191, 33);
			this.removeButton.TabIndex = 76;
			this.removeButton.Text = "Remove contact";
			this.removeButton.UseVisualStyleBackColor = true;
			this.removeButton.Visible = false;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// ContactsProfileForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(800, 727);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.contactProfileLabel);
			this.Controls.Add(this.educationLabel);
			this.Controls.Add(this.professionLabel);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.dateOfBirthLabel);
			this.Controls.Add(this.surnameLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.roleCB);
			this.Controls.Add(this.educationLevelCB);
			this.Controls.Add(this.imagePB);
			this.Controls.Add(this.dateOfBirthDTP);
			this.Controls.Add(this.descriptionRTB);
			this.Controls.Add(this.genderGroupBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.surnameTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.topPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ContactsProfileForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ContactsProfileForm_Paint);
			this.topPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
			this.genderGroupBox.ResumeLayout(false);
			this.genderGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label educationLabel;
        private System.Windows.Forms.Label professionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.ComboBox educationLevelCB;
        private System.Windows.Forms.PictureBox imagePB;
        private System.Windows.Forms.DateTimePicker dateOfBirthDTP;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton genderFemaleRB;
        private System.Windows.Forms.RadioButton genderMaleRB;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label contactProfileLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
    }
}