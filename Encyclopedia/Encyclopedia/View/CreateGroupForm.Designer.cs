namespace Encyclopedia.View
{
    partial class CreateGroupForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroupForm));
			this.closePictureBox = new System.Windows.Forms.PictureBox();
			this.topPanel = new System.Windows.Forms.Panel();
			this.contactsCheckedListBox = new System.Windows.Forms.CheckedListBox();
			this.yourContactsLabel = new System.Windows.Forms.Label();
			this.saveGroupButton = new System.Windows.Forms.Button();
			this.groupNameTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.createGroupToolTip = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
			this.topPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// closePictureBox
			// 
			this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("closePictureBox.Image")));
			this.closePictureBox.Location = new System.Drawing.Point(809, 13);
			this.closePictureBox.Margin = new System.Windows.Forms.Padding(4);
			this.closePictureBox.Name = "closePictureBox";
			this.closePictureBox.Size = new System.Drawing.Size(25, 19);
			this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.closePictureBox.TabIndex = 0;
			this.closePictureBox.TabStop = false;
			this.createGroupToolTip.SetToolTip(this.closePictureBox, "Close form ");
			this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
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
			this.topPanel.Size = new System.Drawing.Size(847, 36);
			this.topPanel.TabIndex = 30;
			// 
			// contactsCheckedListBox
			// 
			this.contactsCheckedListBox.CheckOnClick = true;
			this.contactsCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 13.14783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsCheckedListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactsCheckedListBox.FormattingEnabled = true;
			this.contactsCheckedListBox.Location = new System.Drawing.Point(46, 113);
			this.contactsCheckedListBox.Name = "contactsCheckedListBox";
			this.contactsCheckedListBox.Size = new System.Drawing.Size(750, 200);
			this.contactsCheckedListBox.Sorted = true;
			this.contactsCheckedListBox.TabIndex = 0;
			// 
			// yourContactsLabel
			// 
			this.yourContactsLabel.AutoSize = true;
			this.yourContactsLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.yourContactsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.yourContactsLabel.Location = new System.Drawing.Point(29, 52);
			this.yourContactsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.yourContactsLabel.Name = "yourContactsLabel";
			this.yourContactsLabel.Size = new System.Drawing.Size(312, 45);
			this.yourContactsLabel.TabIndex = 32;
			this.yourContactsLabel.Text = "Select contacts";
			// 
			// saveGroupButton
			// 
			this.saveGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveGroupButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.saveGroupButton.Location = new System.Drawing.Point(648, 391);
			this.saveGroupButton.Name = "saveGroupButton";
			this.saveGroupButton.Size = new System.Drawing.Size(148, 38);
			this.saveGroupButton.TabIndex = 2;
			this.saveGroupButton.Text = "Save group";
			this.createGroupToolTip.SetToolTip(this.saveGroupButton, "Save your group");
			this.saveGroupButton.UseVisualStyleBackColor = true;
			this.saveGroupButton.Click += new System.EventHandler(this.saveGroupButton_Click);
			// 
			// groupNameTextBox
			// 
			this.groupNameTextBox.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupNameTextBox.Location = new System.Drawing.Point(46, 411);
			this.groupNameTextBox.MaxLength = 40;
			this.groupNameTextBox.Name = "groupNameTextBox";
			this.groupNameTextBox.Size = new System.Drawing.Size(412, 33);
			this.groupNameTextBox.TabIndex = 1;
			this.createGroupToolTip.SetToolTip(this.groupNameTextBox, "Pick a group name");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.label1.Location = new System.Drawing.Point(29, 341);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 45);
			this.label1.TabIndex = 35;
			this.label1.Text = "Group name";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.button1.Location = new System.Drawing.Point(648, 435);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(148, 38);
			this.button1.TabIndex = 36;
			this.button1.Text = "Delete group";
			this.createGroupToolTip.SetToolTip(this.button1, "Delete group");
			this.button1.UseVisualStyleBackColor = true;
			// 
			// CreateGroupForm
			// 
			this.AcceptButton = this.saveGroupButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(847, 500);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupNameTextBox);
			this.Controls.Add(this.saveGroupButton);
			this.Controls.Add(this.yourContactsLabel);
			this.Controls.Add(this.contactsCheckedListBox);
			this.Controls.Add(this.topPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CreateGroupForm";
			this.Text = "CreateGroupForm";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.CreateGroupForm_Paint);
			((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
			this.topPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.CheckedListBox contactsCheckedListBox;
        private System.Windows.Forms.Label yourContactsLabel;
        private System.Windows.Forms.Button saveGroupButton;
        private System.Windows.Forms.TextBox groupNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip createGroupToolTip;
    }
}