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
            this.nametb = new System.Windows.Forms.TextBox();
            this.surnametb = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.usernametb = new System.Windows.Forms.TextBox();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.teltb = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.genderrbf = new System.Windows.Forms.RadioButton();
            this.genderrbm = new System.Windows.Forms.RadioButton();
            this.dateofbirth = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(213, 51);
            this.nametb.MaxLength = 40;
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(203, 22);
            this.nametb.TabIndex = 0;
            // 
            // surnametb
            // 
            this.surnametb.Location = new System.Drawing.Point(213, 98);
            this.surnametb.MaxLength = 50;
            this.surnametb.Name = "surnametb";
            this.surnametb.Size = new System.Drawing.Size(203, 22);
            this.surnametb.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 464);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(203, 22);
            this.textBox3.TabIndex = 2;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(213, 202);
            this.emailtb.MaxLength = 60;
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(203, 22);
            this.emailtb.TabIndex = 3;
            // 
            // usernametb
            // 
            this.usernametb.Location = new System.Drawing.Point(213, 258);
            this.usernametb.MaxLength = 40;
            this.usernametb.Name = "usernametb";
            this.usernametb.Size = new System.Drawing.Size(203, 22);
            this.usernametb.TabIndex = 4;
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(213, 314);
            this.passwordtb.MaxLength = 40;
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.PasswordChar = '*';
            this.passwordtb.Size = new System.Drawing.Size(203, 22);
            this.passwordtb.TabIndex = 5;
            this.passwordtb.UseSystemPasswordChar = true;
            // 
            // teltb
            // 
            this.teltb.Location = new System.Drawing.Point(213, 152);
            this.teltb.Mask = "(999) 000-0000";
            this.teltb.Name = "teltb";
            this.teltb.Size = new System.Drawing.Size(203, 22);
            this.teltb.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genderrbf);
            this.groupBox1.Controls.Add(this.genderrbm);
            this.groupBox1.Location = new System.Drawing.Point(213, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // genderrbf
            // 
            this.genderrbf.AutoSize = true;
            this.genderrbf.Location = new System.Drawing.Point(46, 48);
            this.genderrbf.Name = "genderrbf";
            this.genderrbf.Size = new System.Drawing.Size(107, 21);
            this.genderrbf.TabIndex = 1;
            this.genderrbf.TabStop = true;
            this.genderrbf.Text = "radioButton2";
            this.genderrbf.UseVisualStyleBackColor = true;
            // 
            // genderrbm
            // 
            this.genderrbm.AutoSize = true;
            this.genderrbm.Location = new System.Drawing.Point(46, 21);
            this.genderrbm.Name = "genderrbm";
            this.genderrbm.Size = new System.Drawing.Size(107, 21);
            this.genderrbm.TabIndex = 0;
            this.genderrbm.TabStop = true;
            this.genderrbm.Text = "radioButton1";
            this.genderrbm.UseVisualStyleBackColor = true;
            // 
            // dateofbirth
            // 
            this.dateofbirth.Location = new System.Drawing.Point(210, 515);
            this.dateofbirth.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dateofbirth.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateofbirth.Name = "dateofbirth";
            this.dateofbirth.Size = new System.Drawing.Size(246, 22);
            this.dateofbirth.TabIndex = 8;
            this.dateofbirth.Value = new System.DateTime(2018, 12, 19, 0, 29, 49, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(490, 359);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateofbirth);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.teltb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.usernametb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.surnametb);
            this.Controls.Add(this.nametb);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox surnametb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox usernametb;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.MaskedTextBox teltb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton genderrbf;
        private System.Windows.Forms.RadioButton genderrbm;
        private System.Windows.Forms.DateTimePicker dateofbirth;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}