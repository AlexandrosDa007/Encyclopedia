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
            this.SuspendLayout();
            // 
            // LemmaViewWebBrowser
            // 
            this.LemmaViewWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LemmaViewWebBrowser.Location = new System.Drawing.Point(50, 33);
            this.LemmaViewWebBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.LemmaViewWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.LemmaViewWebBrowser.Name = "LemmaViewWebBrowser";
            this.LemmaViewWebBrowser.Size = new System.Drawing.Size(945, 445);
            this.LemmaViewWebBrowser.TabIndex = 23;
            // 
            // LemmaViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.LemmaViewWebBrowser);
            this.Name = "LemmaViewUserControl";
            this.Size = new System.Drawing.Size(1036, 498);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser LemmaViewWebBrowser;
    }
}
