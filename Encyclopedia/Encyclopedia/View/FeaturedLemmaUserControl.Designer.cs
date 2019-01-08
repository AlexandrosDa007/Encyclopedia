namespace Encyclopedia.View
{
    partial class FeaturedLemmaUserControl
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
            this.featuredLemmaLabel = new System.Windows.Forms.Label();
            this.lemmaOfTheDayWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // featuredLemmaLabel
            // 
            this.featuredLemmaLabel.AutoSize = true;
            this.featuredLemmaLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.featuredLemmaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.featuredLemmaLabel.Location = new System.Drawing.Point(27, 0);
            this.featuredLemmaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.featuredLemmaLabel.Name = "featuredLemmaLabel";
            this.featuredLemmaLabel.Size = new System.Drawing.Size(341, 47);
            this.featuredLemmaLabel.TabIndex = 18;
            this.featuredLemmaLabel.Text = "Featured lemma";
            // 
            // lemmaOfTheDayWebBrowser
            // 
            this.lemmaOfTheDayWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lemmaOfTheDayWebBrowser.Location = new System.Drawing.Point(33, 57);
            this.lemmaOfTheDayWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.lemmaOfTheDayWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.lemmaOfTheDayWebBrowser.Name = "lemmaOfTheDayWebBrowser";
            this.lemmaOfTheDayWebBrowser.Size = new System.Drawing.Size(964, 406);
            this.lemmaOfTheDayWebBrowser.TabIndex = 21;
            // 
            // FeaturedLemmaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lemmaOfTheDayWebBrowser);
            this.Controls.Add(this.featuredLemmaLabel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FeaturedLemmaUserControl";
            this.Size = new System.Drawing.Size(1036, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label featuredLemmaLabel;
        private System.Windows.Forms.WebBrowser lemmaOfTheDayWebBrowser;
    }
}
