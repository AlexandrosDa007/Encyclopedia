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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsUserControl));
			this.searchContactsTextBox = new System.Windows.Forms.TextBox();
			this.searchContactsButton = new System.Windows.Forms.Button();
			this.contactsTabControl = new System.Windows.Forms.TabControl();
			this.contactsTabPage = new System.Windows.Forms.TabPage();
			this.contactsListView = new System.Windows.Forms.ListView();
			this.groupTabPage = new System.Windows.Forms.TabPage();
			this.groupListView = new System.Windows.Forms.ListView();
			this.createGroupButton = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.contactsSearchResultsListView = new System.Windows.Forms.ListView();
			this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.refreshButton = new System.Windows.Forms.Button();
			this.contactsTabControl.SuspendLayout();
			this.contactsTabPage.SuspendLayout();
			this.groupTabPage.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchContactsTextBox
			// 
			this.searchContactsTextBox.BackColor = System.Drawing.Color.Silver;
			this.searchContactsTextBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.searchContactsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.searchContactsTextBox.Location = new System.Drawing.Point(31, 23);
			this.searchContactsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchContactsTextBox.Name = "searchContactsTextBox";
			this.searchContactsTextBox.Size = new System.Drawing.Size(314, 34);
			this.searchContactsTextBox.TabIndex = 18;
			this.searchContactsTextBox.Text = " Search contacts";
			this.searchContactsTextBox.Enter += new System.EventHandler(this.searchContactsTextBox_Enter);
			// 
			// searchContactsButton
			// 
			this.searchContactsButton.AutoSize = true;
			this.searchContactsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.searchContactsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.searchContactsButton.Location = new System.Drawing.Point(350, 23);
			this.searchContactsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.searchContactsButton.Name = "searchContactsButton";
			this.searchContactsButton.Size = new System.Drawing.Size(110, 33);
			this.searchContactsButton.TabIndex = 17;
			this.searchContactsButton.Text = "Search";
			this.searchContactsButton.UseVisualStyleBackColor = true;
			// 
			// contactsTabControl
			// 
			this.contactsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.contactsTabControl.Controls.Add(this.contactsTabPage);
			this.contactsTabControl.Controls.Add(this.groupTabPage);
			this.contactsTabControl.Controls.Add(this.tabPage1);
			this.contactsTabControl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsTabControl.Location = new System.Drawing.Point(16, 88);
			this.contactsTabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.contactsTabControl.Name = "contactsTabControl";
			this.contactsTabControl.Padding = new System.Drawing.Point(15, 10);
			this.contactsTabControl.SelectedIndex = 0;
			this.contactsTabControl.Size = new System.Drawing.Size(736, 287);
			this.contactsTabControl.TabIndex = 19;
			this.contactsTabControl.SelectedIndexChanged += new System.EventHandler(this.contactsTabControl_SelectedIndexChanged);
			// 
			// contactsTabPage
			// 
			this.contactsTabPage.Controls.Add(this.contactsListView);
			this.contactsTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsTabPage.Location = new System.Drawing.Point(4, 44);
			this.contactsTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.contactsTabPage.Name = "contactsTabPage";
			this.contactsTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.contactsTabPage.Size = new System.Drawing.Size(728, 239);
			this.contactsTabPage.TabIndex = 0;
			this.contactsTabPage.Text = "Contacts";
			this.contactsTabPage.UseVisualStyleBackColor = true;
			// 
			// contactsListView
			// 
			this.contactsListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.contactsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contactsListView.Font = new System.Drawing.Font("Century Gothic", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactsListView.Location = new System.Drawing.Point(2, 2);
			this.contactsListView.Margin = new System.Windows.Forms.Padding(11, 12, 2, 2);
			this.contactsListView.MultiSelect = false;
			this.contactsListView.Name = "contactsListView";
			this.contactsListView.Size = new System.Drawing.Size(724, 235);
			this.contactsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.contactsListView.TabIndex = 0;
			this.contactsListView.TileSize = new System.Drawing.Size(300, 120);
			this.contactsListView.UseCompatibleStateImageBehavior = false;
			this.contactsListView.View = System.Windows.Forms.View.Tile;
			// 
			// groupTabPage
			// 
			this.groupTabPage.Controls.Add(this.groupListView);
			this.groupTabPage.Controls.Add(this.createGroupButton);
			this.groupTabPage.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupTabPage.Location = new System.Drawing.Point(4, 44);
			this.groupTabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupTabPage.Name = "groupTabPage";
			this.groupTabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupTabPage.Size = new System.Drawing.Size(728, 239);
			this.groupTabPage.TabIndex = 1;
			this.groupTabPage.Text = "Groups";
			this.groupTabPage.UseVisualStyleBackColor = true;
			// 
			// groupListView
			// 
			this.groupListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.groupListView.Font = new System.Drawing.Font("Century Gothic", 13.14783F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.groupListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.groupListView.Location = new System.Drawing.Point(4, 42);
			this.groupListView.Margin = new System.Windows.Forms.Padding(11, 12, 2, 2);
			this.groupListView.MultiSelect = false;
			this.groupListView.Name = "groupListView";
			this.groupListView.Size = new System.Drawing.Size(703, 201);
			this.groupListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.groupListView.TabIndex = 19;
			this.groupListView.TileSize = new System.Drawing.Size(300, 120);
			this.groupListView.UseCompatibleStateImageBehavior = false;
			this.groupListView.View = System.Windows.Forms.View.Tile;
			// 
			// createGroupButton
			// 
			this.createGroupButton.AutoSize = true;
			this.createGroupButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.createGroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.createGroupButton.Location = new System.Drawing.Point(11, 11);
			this.createGroupButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.createGroupButton.Name = "createGroupButton";
			this.createGroupButton.Size = new System.Drawing.Size(115, 29);
			this.createGroupButton.TabIndex = 18;
			this.createGroupButton.Text = "Create Group";
			this.createGroupButton.UseVisualStyleBackColor = true;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.contactsSearchResultsListView);
			this.tabPage1.Location = new System.Drawing.Point(4, 44);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tabPage1.Size = new System.Drawing.Size(728, 239);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Search results";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// contactsSearchResultsListView
			// 
			this.contactsSearchResultsListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.contactsSearchResultsListView.AutoArrange = false;
			this.contactsSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHeader});
			this.contactsSearchResultsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contactsSearchResultsListView.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsSearchResultsListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactsSearchResultsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.contactsSearchResultsListView.Location = new System.Drawing.Point(2, 2);
			this.contactsSearchResultsListView.MultiSelect = false;
			this.contactsSearchResultsListView.Name = "contactsSearchResultsListView";
			this.contactsSearchResultsListView.ShowGroups = false;
			this.contactsSearchResultsListView.Size = new System.Drawing.Size(724, 235);
			this.contactsSearchResultsListView.TabIndex = 4;
			this.contactsSearchResultsListView.UseCompatibleStateImageBehavior = false;
			// 
			// titleHeader
			// 
			this.titleHeader.Text = "";
			this.titleHeader.Width = 1400;
			// 
			// refreshButton
			// 
			this.refreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.BackgroundImage")));
			this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.refreshButton.Location = new System.Drawing.Point(466, 23);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(35, 32);
			this.refreshButton.TabIndex = 3;
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Visible = false;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// ContactsUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.Controls.Add(this.refreshButton);
			this.Controls.Add(this.contactsTabControl);
			this.Controls.Add(this.searchContactsTextBox);
			this.Controls.Add(this.searchContactsButton);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "ContactsUserControl";
			this.Size = new System.Drawing.Size(777, 405);
			this.contactsTabControl.ResumeLayout(false);
			this.contactsTabPage.ResumeLayout(false);
			this.groupTabPage.ResumeLayout(false);
			this.groupTabPage.PerformLayout();
			this.tabPage1.ResumeLayout(false);
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
		private System.Windows.Forms.Button refreshButton;
		private System.Windows.Forms.ListView groupListView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView contactsSearchResultsListView;
        private System.Windows.Forms.ColumnHeader titleHeader;
    }
}
