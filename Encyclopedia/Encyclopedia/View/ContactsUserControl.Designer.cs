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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contactsTabPage = new System.Windows.Forms.TabPage();
            this.groupTabPage = new System.Windows.Forms.TabPage();
            this.createGroupButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
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
            this.searchContactsTextBox.Size = new System.Drawing.Size(280, 36);
            this.searchContactsTextBox.TabIndex = 18;
            this.searchContactsTextBox.Text = "Search contacts";
            this.searchContactsTextBox.UseWaitCursor = true;
            // 
            // searchContactsButton
            // 
            this.searchContactsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchContactsButton.AutoSize = true;
            this.searchContactsButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchContactsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.searchContactsButton.Location = new System.Drawing.Point(319, 47);
            this.searchContactsButton.Margin = new System.Windows.Forms.Padding(5);
            this.searchContactsButton.Name = "searchContactsButton";
            this.searchContactsButton.Size = new System.Drawing.Size(147, 37);
            this.searchContactsButton.TabIndex = 17;
            this.searchContactsButton.Text = "Search";
            this.searchContactsButton.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.contactsTabPage);
            this.tabControl1.Controls.Add(this.groupTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.tabControl1.Location = new System.Drawing.Point(41, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 358);
            this.tabControl1.TabIndex = 19;
            // 
            // contactsTabPage
            // 
            this.contactsTabPage.Controls.Add(this.listView1);
            this.contactsTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.contactsTabPage.Location = new System.Drawing.Point(4, 30);
            this.contactsTabPage.Name = "contactsTabPage";
            this.contactsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactsTabPage.Size = new System.Drawing.Size(969, 324);
            this.contactsTabPage.TabIndex = 0;
            this.contactsTabPage.Text = "Contacts";
            this.contactsTabPage.UseVisualStyleBackColor = true;
            // 
            // groupTabPage
            // 
            this.groupTabPage.Controls.Add(this.listView2);
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
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(6, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(957, 315);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(6, 52);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(957, 269);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ContactsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.searchContactsTextBox);
            this.Controls.Add(this.searchContactsButton);
            this.Name = "ContactsUserControl";
            this.Size = new System.Drawing.Size(1036, 498);
            this.tabControl1.ResumeLayout(false);
            this.contactsTabPage.ResumeLayout(false);
            this.groupTabPage.ResumeLayout(false);
            this.groupTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchContactsTextBox;
        private System.Windows.Forms.Button searchContactsButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage contactsTabPage;
        private System.Windows.Forms.TabPage groupTabPage;
        private System.Windows.Forms.Button createGroupButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}
