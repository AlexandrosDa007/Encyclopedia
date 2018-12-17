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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.monthCalendar.Location = new System.Drawing.Point(627, 94);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 20;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            // 
            // lemmaOfTheDayLabel
            // 
            this.lemmaOfTheDayLabel.AutoSize = true;
            this.lemmaOfTheDayLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lemmaOfTheDayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lemmaOfTheDayLabel.Location = new System.Drawing.Point(11, 39);
            this.lemmaOfTheDayLabel.Name = "lemmaOfTheDayLabel";
            this.lemmaOfTheDayLabel.Size = new System.Drawing.Size(225, 28);
            this.lemmaOfTheDayLabel.TabIndex = 18;
            this.lemmaOfTheDayLabel.Text = "Lemma of the day";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(9, 72);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(598, 342);
            this.webBrowser1.TabIndex = 21;
            // 
            // LemmaOfTheDayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lemmaOfTheDayLabel);
            this.Name = "LemmaOfTheDayUserControl";
            this.Size = new System.Drawing.Size(849, 429);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lemmaOfTheDayLabel;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
