namespace Encyclopedia.View
{
    partial class RegisterForm
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
			this.nameTB = new System.Windows.Forms.TextBox();
			this.surnameTB = new System.Windows.Forms.TextBox();
			this.passwordConfirmTB = new System.Windows.Forms.TextBox();
			this.emailTB = new System.Windows.Forms.TextBox();
			this.usernameTB = new System.Windows.Forms.TextBox();
			this.passwordTB = new System.Windows.Forms.TextBox();
			this.telTB = new System.Windows.Forms.MaskedTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.genderFemaleRB = new System.Windows.Forms.RadioButton();
			this.genderMaleRB = new System.Windows.Forms.RadioButton();
			this.dateOfBirthDTP = new System.Windows.Forms.DateTimePicker();
			this.imagePB = new System.Windows.Forms.PictureBox();
			this.educationLevelCB = new System.Windows.Forms.ComboBox();
			this.roleCB = new System.Windows.Forms.ComboBox();
			this.descriptionRTB = new System.Windows.Forms.RichTextBox();
			this.registerB = new System.Windows.Forms.Button();
			this.imagePathTB = new System.Windows.Forms.TextBox();
			this.browseB = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePB)).BeginInit();
			this.SuspendLayout();
			// 
			// nameTB
			// 
			this.nameTB.Location = new System.Drawing.Point(213, 51);
			this.nameTB.MaxLength = 40;
			this.nameTB.Name = "nameTB";
			this.nameTB.Size = new System.Drawing.Size(203, 22);
			this.nameTB.TabIndex = 0;
			// 
			// surnameTB
			// 
			this.surnameTB.Location = new System.Drawing.Point(213, 98);
			this.surnameTB.MaxLength = 50;
			this.surnameTB.Name = "surnameTB";
			this.surnameTB.Size = new System.Drawing.Size(203, 22);
			this.surnameTB.TabIndex = 1;
			// 
			// passwordConfirmTB
			// 
			this.passwordConfirmTB.Location = new System.Drawing.Point(213, 371);
			this.passwordConfirmTB.MaxLength = 40;
			this.passwordConfirmTB.Name = "passwordConfirmTB";
			this.passwordConfirmTB.Size = new System.Drawing.Size(203, 22);
			this.passwordConfirmTB.TabIndex = 6;
			this.passwordConfirmTB.UseSystemPasswordChar = true;
			// 
			// emailTB
			// 
			this.emailTB.Location = new System.Drawing.Point(213, 202);
			this.emailTB.MaxLength = 60;
			this.emailTB.Name = "emailTB";
			this.emailTB.Size = new System.Drawing.Size(203, 22);
			this.emailTB.TabIndex = 3;
			// 
			// usernameTB
			// 
			this.usernameTB.Location = new System.Drawing.Point(213, 258);
			this.usernameTB.MaxLength = 40;
			this.usernameTB.Name = "usernameTB";
			this.usernameTB.Size = new System.Drawing.Size(203, 22);
			this.usernameTB.TabIndex = 4;
			// 
			// passwordTB
			// 
			this.passwordTB.Location = new System.Drawing.Point(213, 314);
			this.passwordTB.MaxLength = 40;
			this.passwordTB.Name = "passwordTB";
			this.passwordTB.Size = new System.Drawing.Size(203, 22);
			this.passwordTB.TabIndex = 5;
			this.passwordTB.UseSystemPasswordChar = true;
			// 
			// telTB
			// 
			this.telTB.Location = new System.Drawing.Point(213, 152);
			this.telTB.Mask = "(999) 000-0000";
			this.telTB.Name = "telTB";
			this.telTB.Size = new System.Drawing.Size(203, 22);
			this.telTB.TabIndex = 2;
			this.telTB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.genderFemaleRB);
			this.groupBox1.Controls.Add(this.genderMaleRB);
			this.groupBox1.Location = new System.Drawing.Point(213, 423);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 83);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "gender";
			// 
			// genderFemaleRB
			// 
			this.genderFemaleRB.AutoSize = true;
			this.genderFemaleRB.Location = new System.Drawing.Point(46, 48);
			this.genderFemaleRB.Name = "genderFemaleRB";
			this.genderFemaleRB.Size = new System.Drawing.Size(72, 21);
			this.genderFemaleRB.TabIndex = 8;
			this.genderFemaleRB.Text = "Female";
			this.genderFemaleRB.UseVisualStyleBackColor = true;
			// 
			// genderMaleRB
			// 
			this.genderMaleRB.AutoSize = true;
			this.genderMaleRB.Location = new System.Drawing.Point(46, 21);
			this.genderMaleRB.Name = "genderMaleRB";
			this.genderMaleRB.Size = new System.Drawing.Size(56, 21);
			this.genderMaleRB.TabIndex = 7;
			this.genderMaleRB.Text = "Male";
			this.genderMaleRB.UseVisualStyleBackColor = true;
			// 
			// dateOfBirthDTP
			// 
			this.dateOfBirthDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateOfBirthDTP.Location = new System.Drawing.Point(213, 535);
			this.dateOfBirthDTP.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
			this.dateOfBirthDTP.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
			this.dateOfBirthDTP.Name = "dateOfBirthDTP";
			this.dateOfBirthDTP.Size = new System.Drawing.Size(203, 22);
			this.dateOfBirthDTP.TabIndex = 9;
			this.dateOfBirthDTP.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
			// 
			// imagePB
			// 
			this.imagePB.Location = new System.Drawing.Point(447, 697);
			this.imagePB.Name = "imagePB";
			this.imagePB.Size = new System.Drawing.Size(102, 100);
			this.imagePB.TabIndex = 9;
			this.imagePB.TabStop = false;
			// 
			// educationLevelCB
			// 
			this.educationLevelCB.FormattingEnabled = true;
			this.educationLevelCB.Location = new System.Drawing.Point(213, 594);
			this.educationLevelCB.Name = "educationLevelCB";
			this.educationLevelCB.Size = new System.Drawing.Size(203, 24);
			this.educationLevelCB.TabIndex = 10;
			// 
			// roleCB
			// 
			this.roleCB.FormattingEnabled = true;
			this.roleCB.Location = new System.Drawing.Point(213, 645);
			this.roleCB.Name = "roleCB";
			this.roleCB.Size = new System.Drawing.Size(203, 24);
			this.roleCB.TabIndex = 11;
			// 
			// descriptionRTB
			// 
			this.descriptionRTB.Location = new System.Drawing.Point(213, 706);
			this.descriptionRTB.MaxLength = 250;
			this.descriptionRTB.Name = "descriptionRTB";
			this.descriptionRTB.Size = new System.Drawing.Size(203, 80);
			this.descriptionRTB.TabIndex = 12;
			this.descriptionRTB.Text = "";
			// 
			// registerB
			// 
			this.registerB.Location = new System.Drawing.Point(341, 868);
			this.registerB.Name = "registerB";
			this.registerB.Size = new System.Drawing.Size(75, 23);
			this.registerB.TabIndex = 15;
			this.registerB.Text = "Register";
			this.registerB.UseVisualStyleBackColor = true;
			this.registerB.Click += new System.EventHandler(this.registerb_Click);
			// 
			// imagePathTB
			// 
			this.imagePathTB.Location = new System.Drawing.Point(213, 814);
			this.imagePathTB.Name = "imagePathTB";
			this.imagePathTB.Size = new System.Drawing.Size(200, 22);
			this.imagePathTB.TabIndex = 13;
			// 
			// browseB
			// 
			this.browseB.Location = new System.Drawing.Point(447, 814);
			this.browseB.Name = "browseB";
			this.browseB.Size = new System.Drawing.Size(102, 23);
			this.browseB.TabIndex = 14;
			this.browseB.Text = "Browse";
			this.browseB.UseVisualStyleBackColor = true;
			this.browseB.Click += new System.EventHandler(this.browseb_Click);
			// 
			// RegisterForm
			// 
			this.AcceptButton = this.registerB;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 925);
			this.Controls.Add(this.browseB);
			this.Controls.Add(this.imagePathTB);
			this.Controls.Add(this.registerB);
			this.Controls.Add(this.descriptionRTB);
			this.Controls.Add(this.roleCB);
			this.Controls.Add(this.educationLevelCB);
			this.Controls.Add(this.imagePB);
			this.Controls.Add(this.dateOfBirthDTP);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.telTB);
			this.Controls.Add(this.passwordTB);
			this.Controls.Add(this.usernameTB);
			this.Controls.Add(this.emailTB);
			this.Controls.Add(this.passwordConfirmTB);
			this.Controls.Add(this.surnameTB);
			this.Controls.Add(this.nameTB);
			this.Name = "RegisterForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Registration Form";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imagePB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox surnameTB;
        private System.Windows.Forms.TextBox passwordConfirmTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.MaskedTextBox telTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton genderFemaleRB;
        private System.Windows.Forms.RadioButton genderMaleRB;
        private System.Windows.Forms.DateTimePicker dateOfBirthDTP;
        private System.Windows.Forms.PictureBox imagePB;
        private System.Windows.Forms.ComboBox educationLevelCB;
        private System.Windows.Forms.ComboBox roleCB;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.Button registerB;
        private System.Windows.Forms.TextBox imagePathTB;
        private System.Windows.Forms.Button browseB;
    }
}