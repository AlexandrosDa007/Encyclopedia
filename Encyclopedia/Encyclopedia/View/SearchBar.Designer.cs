namespace Encyclopedia.View
{
    partial class SearchBar
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.searchBarText = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.resultsList = new System.Windows.Forms.ListBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Text";
            // 
            // searchBarText
            // 
            this.searchBarText.Location = new System.Drawing.Point(147, 32);
            this.searchBarText.Name = "searchBarText";
            this.searchBarText.Size = new System.Drawing.Size(167, 20);
            this.searchBarText.TabIndex = 1;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(717, 32);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(497, 339);
            this.textArea.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(121, 384);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1029, 470);
            this.webBrowser1.TabIndex = 3;
            // 
            // resultsList
            // 
            this.resultsList.FormattingEnabled = true;
            this.resultsList.Location = new System.Drawing.Point(37, 79);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(579, 277);
            this.resultsList.TabIndex = 4;
            this.resultsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsList_MouseDoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(337, 27);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 28);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 866);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.searchBarText);
            this.Controls.Add(this.label1);
            this.Name = "SearchBar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBarText;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox resultsList;
        private System.Windows.Forms.Button searchButton;
    }
}