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
            this.LemmaViewWebBrowser = new System.Windows.Forms.WebBrowser();
            this.lemmaTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LemmaViewWebBrowser
            // 
            this.LemmaViewWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LemmaViewWebBrowser.Location = new System.Drawing.Point(20, 90);
            this.LemmaViewWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.LemmaViewWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.LemmaViewWebBrowser.Name = "LemmaViewWebBrowser";
            this.LemmaViewWebBrowser.Size = new System.Drawing.Size(986, 393);
            this.LemmaViewWebBrowser.TabIndex = 23;
            // 
            // lemmaTitleLabel
            // 
            this.lemmaTitleLabel.AutoSize = true;
            this.lemmaTitleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lemmaTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lemmaTitleLabel.Location = new System.Drawing.Point(13, 25);
            this.lemmaTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lemmaTitleLabel.Name = "lemmaTitleLabel";
            this.lemmaTitleLabel.Size = new System.Drawing.Size(184, 37);
            this.lemmaTitleLabel.TabIndex = 34;
            this.lemmaTitleLabel.Text = "Lemma title";
            // 
            // LemmaViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lemmaTitleLabel);
            this.Controls.Add(this.LemmaViewWebBrowser);
            this.Name = "LemmaViewUserControl";
            this.Size = new System.Drawing.Size(1036, 498);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser LemmaViewWebBrowser;
        private System.Windows.Forms.Label lemmaTitleLabel;
    }
}
