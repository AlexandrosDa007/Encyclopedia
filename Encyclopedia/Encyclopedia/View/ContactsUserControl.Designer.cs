namespace Encyclopedia.View
{
    partial class ContactsUserControl
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
			this.searchContactsTextBox = new System.Windows.Forms.TextBox();
			this.searchContactsButton = new System.Windows.Forms.Button();
			this.contactsTabControl = new System.Windows.Forms.TabControl();
			this.contactsTabPage = new System.Windows.Forms.TabPage();
			this.contactsListView = new System.Windows.Forms.ListView();
			this.groupTabPage = new System.Windows.Forms.TabPage();
			this.groupListView = new System.Windows.Forms.ListView();
			this.createGroupButton = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contactsTabControl.SuspendLayout();
			this.contactsTabPage.SuspendLayout();
			this.groupTabPage.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchContactsTextBox
			// 
			this.searchContactsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.searchContactsTextBox.BackColor = System.Drawing.Color.Silver;
			this.searchContactsTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.searchContactsTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.searchContactsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.searchContactsTextBox.Location = new System.Drawing.Point(41, 48);
			this.searchContactsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.searchContactsTextBox.Name = "searchContactsTextBox";
			this.searchContactsTextBox.Size = new System.Drawing.Size(417, 35);
			this.searchContactsTextBox.TabIndex = 18;
			this.searchContactsTextBox.Text = "Search contacts/groups";
			this.searchContactsTextBox.UseWaitCursor = true;
			// 
			// searchContactsButton
			// 
			this.searchContactsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.searchContactsButton.AutoSize = true;
			this.searchContactsButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.searchContactsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.searchContactsButton.Location = new System.Drawing.Point(457, 48);
			this.searchContactsButton.Margin = new System.Windows.Forms.Padding(5);
			this.searchContactsButton.Name = "searchContactsButton";
			this.searchContactsButton.Size = new System.Drawing.Size(147, 37);
			this.searchContactsButton.TabIndex = 17;
			this.searchContactsButton.Text = "Search";
			this.searchContactsButton.UseVisualStyleBackColor = true;
			// 
			// contactsTabControl
			// 
			this.contactsTabControl.Controls.Add(this.contactsTabPage);
			this.contactsTabControl.Controls.Add(this.groupTabPage);
			this.contactsTabControl.Font = new System.Drawing.Font("Century Gothic", 10.8F);
			this.contactsTabControl.Location = new System.Drawing.Point(41, 108);
			this.contactsTabControl.Name = "contactsTabControl";
			this.contactsTabControl.SelectedIndex = 0;
			this.contactsTabControl.Size = new System.Drawing.Size(977, 358);
			this.contactsTabControl.TabIndex = 19;
			// 
			// contactsTabPage
			// 
			this.contactsTabPage.Controls.Add(this.contactsListView);
			this.contactsTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsTabPage.Location = new System.Drawing.Point(4, 30);
			this.contactsTabPage.Name = "contactsTabPage";
			this.contactsTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.contactsTabPage.Size = new System.Drawing.Size(969, 324);
			this.contactsTabPage.TabIndex = 0;
			this.contactsTabPage.Text = "Contacts";
			this.contactsTabPage.UseVisualStyleBackColor = true;
			// 
			// contactsListView
			// 
			this.contactsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.contactsListView.Location = new System.Drawing.Point(6, 3);
			this.contactsListView.Name = "contactsListView";
			this.contactsListView.Size = new System.Drawing.Size(957, 315);
			this.contactsListView.TabIndex = 0;
			this.contactsListView.UseCompatibleStateImageBehavior = false;
			// 
			// groupTabPage
			// 
			this.groupTabPage.Controls.Add(this.groupListView);
			this.groupTabPage.Controls.Add(this.createGroupButton);
			this.groupTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupTabPage.Location = new System.Drawing.Point(4, 30);
			this.groupTabPage.Name = "groupTabPage";
			this.groupTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.groupTabPage.Size = new System.Drawing.Size(969, 324);
			this.groupTabPage.TabIndex = 1;
			this.groupTabPage.Text = "Groups";
			this.groupTabPage.UseVisualStyleBackColor = true;
			// 
			// groupListView
			// 
			this.groupListView.Location = new System.Drawing.Point(6, 52);
			this.groupListView.Name = "groupListView";
			this.groupListView.Size = new System.Drawing.Size(957, 269);
			this.groupListView.TabIndex = 19;
			this.groupListView.UseCompatibleStateImageBehavior = false;
			// 
			// createGroupButton
			// 
			this.createGroupButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.createGroupButton.AutoSize = true;
			this.createGroupButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.createGroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.createGroupButton.Location = new System.Drawing.Point(15, 14);
			this.createGroupButton.Margin = new System.Windows.Forms.Padding(5);
			this.createGroupButton.Name = "createGroupButton";
			this.createGroupButton.Size = new System.Drawing.Size(129, 30);
			this.createGroupButton.TabIndex = 18;
			this.createGroupButton.Text = "Create Group";
			this.createGroupButton.UseVisualStyleBackColor = true;
			// 
			// ContactsUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.Controls.Add(this.contactsTabControl);
			this.Controls.Add(this.searchContactsTextBox);
			this.Controls.Add(this.searchContactsButton);
			this.Name = "ContactsUserControl";
			this.Size = new System.Drawing.Size(1036, 498);
			this.contactsTabControl.ResumeLayout(false);
			this.contactsTabPage.ResumeLayout(false);
			this.groupTabPage.ResumeLayout(false);
			this.groupTabPage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchContactsTextBox;
        private System.Windows.Forms.Button searchContactsButton;
        private System.Windows.Forms.TabControl contactsTabControl;
        private System.Windows.Forms.TabPage contactsTabPage;
        private System.Windows.Forms.TabPage groupTabPage;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.ListView contactsListView;
        private System.Windows.Forms.ListView groupListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}
