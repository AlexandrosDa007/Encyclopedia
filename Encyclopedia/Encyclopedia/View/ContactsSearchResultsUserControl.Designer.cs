namespace Encyclopedia.View
{
    partial class ContactsSearchResultsUserControl
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
            this.contactsSearchResultsListView = new System.Windows.Forms.ListView();
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contactsSearchResultsListView
            // 
            this.contactsSearchResultsListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.contactsSearchResultsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactsSearchResultsListView.AutoArrange = false;
            this.contactsSearchResultsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHeader});
            this.contactsSearchResultsListView.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactsSearchResultsListView.Location = new System.Drawing.Point(41, 59);
            this.contactsSearchResultsListView.Margin = new System.Windows.Forms.Padding(4);
            this.contactsSearchResultsListView.MultiSelect = false;
            this.contactsSearchResultsListView.Name = "contactsSearchResultsListView";
            this.contactsSearchResultsListView.ShowGroups = false;
            this.contactsSearchResultsListView.Size = new System.Drawing.Size(958, 414);
            this.contactsSearchResultsListView.TabIndex = 3;
            this.contactsSearchResultsListView.UseCompatibleStateImageBehavior = false;
            this.contactsSearchResultsListView.View = System.Windows.Forms.View.Details;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Lemma Titles";
            this.titleHeader.Width = 1080;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchResultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.searchResultsLabel.Location = new System.Drawing.Point(34, 18);
            this.searchResultsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(231, 37);
            this.searchResultsLabel.TabIndex = 4;
            this.searchResultsLabel.Text = "Search Results ";
            // 
            // ContactsSearchResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.contactsSearchResultsListView);
            this.Controls.Add(this.searchResultsLabel);
            this.Name = "ContactsSearchResultsUserControl";
            this.Size = new System.Drawing.Size(1036, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView contactsSearchResultsListView;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.Label searchResultsLabel;
    }
}
