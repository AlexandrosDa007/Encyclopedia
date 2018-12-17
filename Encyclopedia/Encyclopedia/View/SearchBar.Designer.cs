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
            this.label1.Location = new System.Drawing.Point(45, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search By Text";
            // 
            // searchBarText
            // 
            this.searchBarText.Location = new System.Drawing.Point(196, 39);
            this.searchBarText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBarText.Name = "searchBarText";
            this.searchBarText.Size = new System.Drawing.Size(221, 22);
            this.searchBarText.TabIndex = 1;
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(956, 39);
            this.textArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(661, 416);
            this.textArea.TabIndex = 2;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(161, 473);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1372, 578);
            this.webBrowser1.TabIndex = 3;
            // 
            // resultsList
            // 
            this.resultsList.FormattingEnabled = true;
            this.resultsList.ItemHeight = 16;
            this.resultsList.Location = new System.Drawing.Point(49, 97);
            this.resultsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultsList.Name = "resultsList";
            this.resultsList.Size = new System.Drawing.Size(771, 340);
            this.resultsList.TabIndex = 4;
            this.resultsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.resultsList_MouseDoubleClick);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(449, 33);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(149, 34);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 1055);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultsList);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.searchBarText);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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