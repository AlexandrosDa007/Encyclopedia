namespace Encyclopedia.View
{
    partial class SearchResultsUserControl
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
            this.lemmaResultsΤableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchResultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lemmaResultsΤableLayoutPanel
            // 
            this.lemmaResultsΤableLayoutPanel.AutoSize = true;
            this.lemmaResultsΤableLayoutPanel.BackColor = System.Drawing.Color.Silver;
            this.lemmaResultsΤableLayoutPanel.ColumnCount = 1;
            this.lemmaResultsΤableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lemmaResultsΤableLayoutPanel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lemmaResultsΤableLayoutPanel.Location = new System.Drawing.Point(32, 66);
            this.lemmaResultsΤableLayoutPanel.Name = "lemmaResultsΤableLayoutPanel";
            this.lemmaResultsΤableLayoutPanel.RowCount = 7;
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.lemmaResultsΤableLayoutPanel.Size = new System.Drawing.Size(697, 283);
            this.lemmaResultsΤableLayoutPanel.TabIndex = 3;
            // 
            // searchResultsLabel
            // 
            this.searchResultsLabel.AutoSize = true;
            this.searchResultsLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.searchResultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.searchResultsLabel.Location = new System.Drawing.Point(57, 13);
            this.searchResultsLabel.Name = "searchResultsLabel";
            this.searchResultsLabel.Size = new System.Drawing.Size(221, 28);
            this.searchResultsLabel.TabIndex = 2;
            this.searchResultsLabel.Text = "Search Results for ";
            // 
            // SearchResultsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lemmaResultsΤableLayoutPanel);
            this.Controls.Add(this.searchResultsLabel);
            this.Name = "SearchResultsUserControl";
            this.Size = new System.Drawing.Size(765, 370);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lemmaResultsΤableLayoutPanel;
        private System.Windows.Forms.Label searchResultsLabel;
    }
}
