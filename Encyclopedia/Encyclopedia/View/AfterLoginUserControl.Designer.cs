namespace Encyclopedia.View
{
    partial class AfterLoginUserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfterLoginUserControl));
			this.FeedbackPanel = new System.Windows.Forms.Panel();
			this.feedbackLabel = new System.Windows.Forms.Label();
			this.logoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.contactsButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.editedButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.favouritesButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.profileButton = new Bunifu.Framework.UI.BunifuFlatButton();
			this.connectUserLabel = new System.Windows.Forms.Label();
			this.sideProfilePicture = new System.Windows.Forms.PictureBox();
			this.FeedbackPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sideProfilePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// FeedbackPanel
			// 
			this.FeedbackPanel.Controls.Add(this.feedbackLabel);
			this.FeedbackPanel.Location = new System.Drawing.Point(0, 768);
			this.FeedbackPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FeedbackPanel.Name = "FeedbackPanel";
			this.FeedbackPanel.Size = new System.Drawing.Size(317, 37);
			this.FeedbackPanel.TabIndex = 24;
			this.FeedbackPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FeedbackPanel_Paint);
			// 
			// feedbackLabel
			// 
			this.feedbackLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.feedbackLabel.AutoSize = true;
			this.feedbackLabel.Font = new System.Drawing.Font("Century Gothic", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.feedbackLabel.ForeColor = System.Drawing.Color.White;
			this.feedbackLabel.Location = new System.Drawing.Point(13, 6);
			this.feedbackLabel.Name = "feedbackLabel";
			this.feedbackLabel.Size = new System.Drawing.Size(62, 21);
			this.feedbackLabel.TabIndex = 0;
			this.feedbackLabel.Text = "             ";
			this.feedbackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// logoutButton
			// 
			this.logoutButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.logoutButton.BorderRadius = 0;
			this.logoutButton.ButtonText = "Logout";
			this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.logoutButton.DisabledColor = System.Drawing.Color.Gray;
			this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.logoutButton.Iconcolor = System.Drawing.Color.Transparent;
			this.logoutButton.Iconimage = null;
			this.logoutButton.Iconimage_right = null;
			this.logoutButton.Iconimage_right_Selected = null;
			this.logoutButton.Iconimage_Selected = null;
			this.logoutButton.IconMarginLeft = 0;
			this.logoutButton.IconMarginRight = 0;
			this.logoutButton.IconRightVisible = true;
			this.logoutButton.IconRightZoom = 0D;
			this.logoutButton.IconVisible = true;
			this.logoutButton.IconZoom = 90D;
			this.logoutButton.IsTab = false;
			this.logoutButton.Location = new System.Drawing.Point(0, 593);
			this.logoutButton.Margin = new System.Windows.Forms.Padding(5);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.logoutButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
			this.logoutButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.logoutButton.selected = false;
			this.logoutButton.Size = new System.Drawing.Size(317, 63);
			this.logoutButton.TabIndex = 23;
			this.logoutButton.Text = "Logout";
			this.logoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.logoutButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.logoutButton.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// contactsButton
			// 
			this.contactsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.contactsButton.BorderRadius = 0;
			this.contactsButton.ButtonText = "Contacts";
			this.contactsButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.contactsButton.DisabledColor = System.Drawing.Color.Gray;
			this.contactsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsButton.Iconcolor = System.Drawing.Color.Transparent;
			this.contactsButton.Iconimage = null;
			this.contactsButton.Iconimage_right = null;
			this.contactsButton.Iconimage_right_Selected = null;
			this.contactsButton.Iconimage_Selected = null;
			this.contactsButton.IconMarginLeft = 0;
			this.contactsButton.IconMarginRight = 0;
			this.contactsButton.IconRightVisible = true;
			this.contactsButton.IconRightZoom = 0D;
			this.contactsButton.IconVisible = true;
			this.contactsButton.IconZoom = 90D;
			this.contactsButton.IsTab = false;
			this.contactsButton.Location = new System.Drawing.Point(0, 496);
			this.contactsButton.Margin = new System.Windows.Forms.Padding(5);
			this.contactsButton.Name = "contactsButton";
			this.contactsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.contactsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
			this.contactsButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.contactsButton.selected = false;
			this.contactsButton.Size = new System.Drawing.Size(317, 63);
			this.contactsButton.TabIndex = 22;
			this.contactsButton.Text = "Contacts";
			this.contactsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.contactsButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.contactsButton.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.contactsButton.Click += new System.EventHandler(this.contactsButton_Click);
			// 
			// editedButton
			// 
			this.editedButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.editedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.editedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.editedButton.BorderRadius = 0;
			this.editedButton.ButtonText = "Edited Lemmata";
			this.editedButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.editedButton.DisabledColor = System.Drawing.Color.Gray;
			this.editedButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.editedButton.Iconcolor = System.Drawing.Color.Transparent;
			this.editedButton.Iconimage = null;
			this.editedButton.Iconimage_right = null;
			this.editedButton.Iconimage_right_Selected = null;
			this.editedButton.Iconimage_Selected = null;
			this.editedButton.IconMarginLeft = 0;
			this.editedButton.IconMarginRight = 0;
			this.editedButton.IconRightVisible = true;
			this.editedButton.IconRightZoom = 0D;
			this.editedButton.IconVisible = true;
			this.editedButton.IconZoom = 90D;
			this.editedButton.IsTab = false;
			this.editedButton.Location = new System.Drawing.Point(0, 423);
			this.editedButton.Margin = new System.Windows.Forms.Padding(5);
			this.editedButton.Name = "editedButton";
			this.editedButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.editedButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
			this.editedButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.editedButton.selected = false;
			this.editedButton.Size = new System.Drawing.Size(317, 63);
			this.editedButton.TabIndex = 21;
			this.editedButton.Text = "Edited Lemmata";
			this.editedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.editedButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.editedButton.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.editedButton.Click += new System.EventHandler(this.editedButton_Click);
			// 
			// favouritesButton
			// 
			this.favouritesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.favouritesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.favouritesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.favouritesButton.BorderRadius = 0;
			this.favouritesButton.ButtonText = "Favourites";
			this.favouritesButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.favouritesButton.DisabledColor = System.Drawing.Color.Gray;
			this.favouritesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.favouritesButton.Iconcolor = System.Drawing.Color.Transparent;
			this.favouritesButton.Iconimage = null;
			this.favouritesButton.Iconimage_right = null;
			this.favouritesButton.Iconimage_right_Selected = null;
			this.favouritesButton.Iconimage_Selected = null;
			this.favouritesButton.IconMarginLeft = 0;
			this.favouritesButton.IconMarginRight = 0;
			this.favouritesButton.IconRightVisible = true;
			this.favouritesButton.IconRightZoom = 0D;
			this.favouritesButton.IconVisible = true;
			this.favouritesButton.IconZoom = 90D;
			this.favouritesButton.IsTab = false;
			this.favouritesButton.Location = new System.Drawing.Point(0, 350);
			this.favouritesButton.Margin = new System.Windows.Forms.Padding(5);
			this.favouritesButton.Name = "favouritesButton";
			this.favouritesButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.favouritesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
			this.favouritesButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.favouritesButton.selected = false;
			this.favouritesButton.Size = new System.Drawing.Size(317, 63);
			this.favouritesButton.TabIndex = 20;
			this.favouritesButton.Text = "Favourites";
			this.favouritesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.favouritesButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.favouritesButton.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.favouritesButton.Click += new System.EventHandler(this.favouritesButton_Click);
			// 
			// profileButton
			// 
			this.profileButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.profileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.profileButton.BorderRadius = 0;
			this.profileButton.ButtonText = "Profile";
			this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.profileButton.DisabledColor = System.Drawing.Color.Gray;
			this.profileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.profileButton.Iconcolor = System.Drawing.Color.Transparent;
			this.profileButton.Iconimage = null;
			this.profileButton.Iconimage_right = null;
			this.profileButton.Iconimage_right_Selected = null;
			this.profileButton.Iconimage_Selected = null;
			this.profileButton.IconMarginLeft = 0;
			this.profileButton.IconMarginRight = 0;
			this.profileButton.IconRightVisible = true;
			this.profileButton.IconRightZoom = 0D;
			this.profileButton.IconVisible = true;
			this.profileButton.IconZoom = 90D;
			this.profileButton.IsTab = false;
			this.profileButton.Location = new System.Drawing.Point(0, 277);
			this.profileButton.Margin = new System.Windows.Forms.Padding(5);
			this.profileButton.Name = "profileButton";
			this.profileButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.profileButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(92)))), ((int)(((byte)(127)))));
			this.profileButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.profileButton.selected = false;
			this.profileButton.Size = new System.Drawing.Size(317, 63);
			this.profileButton.TabIndex = 19;
			this.profileButton.Text = "Profile";
			this.profileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.profileButton.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
			this.profileButton.TextFont = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
			// 
			// connectUserLabel
			// 
			this.connectUserLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.connectUserLabel.ForeColor = System.Drawing.Color.White;
			this.connectUserLabel.Location = new System.Drawing.Point(5, 49);
			this.connectUserLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.connectUserLabel.Name = "connectUserLabel";
			this.connectUserLabel.Size = new System.Drawing.Size(307, 39);
			this.connectUserLabel.TabIndex = 17;
			this.connectUserLabel.Text = "Welcome";
			this.connectUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sideProfilePicture
			// 
			this.sideProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("sideProfilePicture.Image")));
			this.sideProfilePicture.Location = new System.Drawing.Point(87, 101);
			this.sideProfilePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.sideProfilePicture.Name = "sideProfilePicture";
			this.sideProfilePicture.Size = new System.Drawing.Size(140, 140);
			this.sideProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.sideProfilePicture.TabIndex = 18;
			this.sideProfilePicture.TabStop = false;
			// 
			// AfterLoginUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.FeedbackPanel);
			this.Controls.Add(this.logoutButton);
			this.Controls.Add(this.contactsButton);
			this.Controls.Add(this.editedButton);
			this.Controls.Add(this.favouritesButton);
			this.Controls.Add(this.profileButton);
			this.Controls.Add(this.sideProfilePicture);
			this.Controls.Add(this.connectUserLabel);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "AfterLoginUserControl";
			this.Size = new System.Drawing.Size(317, 805);
			this.FeedbackPanel.ResumeLayout(false);
			this.FeedbackPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sideProfilePicture)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FeedbackPanel;
        private System.Windows.Forms.Label feedbackLabel;
        private Bunifu.Framework.UI.BunifuFlatButton logoutButton;
        private Bunifu.Framework.UI.BunifuFlatButton contactsButton;
        private Bunifu.Framework.UI.BunifuFlatButton editedButton;
        private Bunifu.Framework.UI.BunifuFlatButton favouritesButton;
        private Bunifu.Framework.UI.BunifuFlatButton profileButton;
        private System.Windows.Forms.PictureBox sideProfilePicture;
        private System.Windows.Forms.Label connectUserLabel;
    }
}
