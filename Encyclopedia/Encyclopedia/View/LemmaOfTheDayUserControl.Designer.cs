namespace Encyclopedia.View
{
    partial class LemmaOfTheDayUserControl
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lemmaOfTheDayLabel = new System.Windows.Forms.Label();
            this.lemmaOfTheDayWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.monthCalendar.Location = new System.Drawing.Point(836, 116);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 20;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            // 
            // lemmaOfTheDayLabel
            // 
            this.lemmaOfTheDayLabel.AutoSize = true;
            this.lemmaOfTheDayLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lemmaOfTheDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lemmaOfTheDayLabel.Location = new System.Drawing.Point(15, 48);
            this.lemmaOfTheDayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lemmaOfTheDayLabel.Name = "lemmaOfTheDayLabel";
            this.lemmaOfTheDayLabel.Size = new System.Drawing.Size(279, 37);
            this.lemmaOfTheDayLabel.TabIndex = 18;
            this.lemmaOfTheDayLabel.Text = "Lemma of the day";
            // 
            // lemmaOfTheDayWebBrowser
            // 
            this.lemmaOfTheDayWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lemmaOfTheDayWebBrowser.Location = new System.Drawing.Point(12, 89);
            this.lemmaOfTheDayWebBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lemmaOfTheDayWebBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.lemmaOfTheDayWebBrowser.Name = "lemmaOfTheDayWebBrowser";
            this.lemmaOfTheDayWebBrowser.Size = new System.Drawing.Size(797, 421);
            this.lemmaOfTheDayWebBrowser.TabIndex = 21;
            // 
            // LemmaOfTheDayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lemmaOfTheDayWebBrowser);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lemmaOfTheDayLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LemmaOfTheDayUserControl";
            this.Size = new System.Drawing.Size(1132, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lemmaOfTheDayLabel;
        private System.Windows.Forms.WebBrowser lemmaOfTheDayWebBrowser;
    }
}
