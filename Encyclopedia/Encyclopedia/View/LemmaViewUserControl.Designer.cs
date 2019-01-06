namespace Encyclopedia.View
{
    partial class LemmaViewUserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LemmaViewUserControl));
			this.LemmaViewWebBrowser = new System.Windows.Forms.WebBrowser();
			this.lemmaTitleLabel = new System.Windows.Forms.Label();
			this.printButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.shareButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.favouritesButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LemmaViewWebBrowser
			// 
			this.LemmaViewWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LemmaViewWebBrowser.Location = new System.Drawing.Point(44, 70);
			this.LemmaViewWebBrowser.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.LemmaViewWebBrowser.MinimumSize = new System.Drawing.Size(36, 31);
			this.LemmaViewWebBrowser.Name = "LemmaViewWebBrowser";
			this.LemmaViewWebBrowser.Size = new System.Drawing.Size(1284, 494);
			this.LemmaViewWebBrowser.TabIndex = 23;
			// 
			// lemmaTitleLabel
			// 
			this.lemmaTitleLabel.AutoSize = true;
			this.lemmaTitleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.lemmaTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
			this.lemmaTitleLabel.Location = new System.Drawing.Point(36, 6);
			this.lemmaTitleLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lemmaTitleLabel.Name = "lemmaTitleLabel";
			this.lemmaTitleLabel.Size = new System.Drawing.Size(111, 36);
			this.lemmaTitleLabel.TabIndex = 34;
			this.lemmaTitleLabel.Text = "            ";
			// 
			// printButton
			// 
			this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.printButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("printButton.BackgroundImage")));
			this.printButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.printButton.Location = new System.Drawing.Point(1275, 8);
			this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.printButton.Name = "printButton";
			this.printButton.Size = new System.Drawing.Size(53, 53);
			this.printButton.TabIndex = 5;
			this.printButton.UseVisualStyleBackColor = true;
			this.printButton.Click += new System.EventHandler(this.printButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveButton.BackgroundImage")));
			this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.saveButton.Location = new System.Drawing.Point(1216, 8);
			this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(53, 53);
			this.saveButton.TabIndex = 4;
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// shareButton
			// 
			this.shareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.shareButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shareButton.BackgroundImage")));
			this.shareButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.shareButton.Location = new System.Drawing.Point(1156, 8);
			this.shareButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.shareButton.Name = "shareButton";
			this.shareButton.Size = new System.Drawing.Size(53, 53);
			this.shareButton.TabIndex = 3;
			this.shareButton.UseVisualStyleBackColor = true;
			this.shareButton.Visible = false;
			this.shareButton.Click += new System.EventHandler(this.shareButton_Click);
			// 
			// editButton
			// 
			this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
			this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.editButton.Location = new System.Drawing.Point(1096, 8);
			this.editButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(53, 53);
			this.editButton.TabIndex = 2;
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Visible = false;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// favouritesButton
			// 
			this.favouritesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.favouritesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("favouritesButton.BackgroundImage")));
			this.favouritesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.favouritesButton.Location = new System.Drawing.Point(1037, 8);
			this.favouritesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.favouritesButton.Name = "favouritesButton";
			this.favouritesButton.Size = new System.Drawing.Size(53, 53);
			this.favouritesButton.TabIndex = 0;
			this.favouritesButton.UseVisualStyleBackColor = true;
			this.favouritesButton.Visible = false;
			this.favouritesButton.Click += new System.EventHandler(this.favouritesButton_Click);
			// 
			// LemmaViewUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.Controls.Add(this.favouritesButton);
			this.Controls.Add(this.editButton);
			this.Controls.Add(this.shareButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.printButton);
			this.Controls.Add(this.lemmaTitleLabel);
			this.Controls.Add(this.LemmaViewWebBrowser);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "LemmaViewUserControl";
			this.Size = new System.Drawing.Size(1381, 613);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lemmaTitleLabel;
		private System.Windows.Forms.WebBrowser LemmaViewWebBrowser;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button shareButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button favouritesButton;
    }
}
