namespace Encyclopedia.View
{
    partial class SendForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendForm));
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.contactsTabControl = new System.Windows.Forms.TabControl();
            this.contactsTabPage = new System.Windows.Forms.TabPage();
            this.contactsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupTabPage = new System.Windows.Forms.TabPage();
            this.groupsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.sendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.contactsTabControl.SuspendLayout();
            this.contactsTabPage.SuspendLayout();
            this.groupTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
            this.closePictureBox.Location = new System.Drawing.Point(987, 13);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(45, 27);
            this.closePictureBox.TabIndex = 0;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // topPanel
            // 
            this.topPanel.AutoSize = true;
            this.topPanel.Controls.Add(this.closePictureBox);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1036, 44);
            this.topPanel.TabIndex = 29;
            // 
            // contactsTabControl
            // 
            this.contactsTabControl.Controls.Add(this.contactsTabPage);
            this.contactsTabControl.Controls.Add(this.groupTabPage);
            this.contactsTabControl.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.contactsTabControl.Location = new System.Drawing.Point(25, 62);
            this.contactsTabControl.Name = "contactsTabControl";
            this.contactsTabControl.SelectedIndex = 0;
            this.contactsTabControl.Size = new System.Drawing.Size(977, 358);
            this.contactsTabControl.TabIndex = 30;
            // 
            // contactsTabPage
            // 
            this.contactsTabPage.Controls.Add(this.contactsCheckedListBox);
            this.contactsTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.contactsTabPage.Location = new System.Drawing.Point(4, 30);
            this.contactsTabPage.Name = "contactsTabPage";
            this.contactsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactsTabPage.Size = new System.Drawing.Size(969, 324);
            this.contactsTabPage.TabIndex = 0;
            this.contactsTabPage.Text = "Contacts";
            this.contactsTabPage.UseVisualStyleBackColor = true;
            // 
            // contactsCheckedListBox
            // 
            this.contactsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contactsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.contactsCheckedListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.contactsCheckedListBox.FormattingEnabled = true;
            this.contactsCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.contactsCheckedListBox.Name = "contactsCheckedListBox";
            this.contactsCheckedListBox.Size = new System.Drawing.Size(963, 318);
            this.contactsCheckedListBox.Sorted = true;
            this.contactsCheckedListBox.TabIndex = 1;
            // 
            // groupTabPage
            // 
            this.groupTabPage.Controls.Add(this.groupsCheckedListBox);
            this.groupTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupTabPage.Location = new System.Drawing.Point(4, 30);
            this.groupTabPage.Name = "groupTabPage";
            this.groupTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.groupTabPage.Size = new System.Drawing.Size(969, 324);
            this.groupTabPage.TabIndex = 1;
            this.groupTabPage.Text = "Groups";
            this.groupTabPage.UseVisualStyleBackColor = true;
            // 
            // groupsCheckedListBox
            // 
            this.groupsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupsCheckedListBox.FormattingEnabled = true;
            this.groupsCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.groupsCheckedListBox.Name = "groupsCheckedListBox";
            this.groupsCheckedListBox.Size = new System.Drawing.Size(963, 318);
            this.groupsCheckedListBox.Sorted = true;
            this.groupsCheckedListBox.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sendButton.Location = new System.Drawing.Point(899, 439);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(90, 38);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // SendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1036, 498);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.contactsTabControl);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendForm";
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.contactsTabControl.ResumeLayout(false);
            this.contactsTabPage.ResumeLayout(false);
            this.groupTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TabControl contactsTabControl;
        private System.Windows.Forms.TabPage contactsTabPage;
        private System.Windows.Forms.TabPage groupTabPage;
        private System.Windows.Forms.CheckedListBox groupsCheckedListBox;
        private System.Windows.Forms.CheckedListBox contactsCheckedListBox;
        private System.Windows.Forms.Button sendButton;
    }
}