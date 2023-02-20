namespace ExcelToWordProject.Forms
{
    partial class SosParser
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
            this.resultFolderPathLabel = new System.Windows.Forms.Label();
            this.resultFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.folderPathButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.folderPathButton)).BeginInit();
            this.SuspendLayout();
            // 
            // resultFolderPathLabel
            // 
            this.resultFolderPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFolderPathLabel.AutoSize = true;
            this.resultFolderPathLabel.Location = new System.Drawing.Point(21, 207);
            this.resultFolderPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultFolderPathLabel.Name = "resultFolderPathLabel";
            this.resultFolderPathLabel.Size = new System.Drawing.Size(162, 13);
            this.resultFolderPathLabel.TabIndex = 6;
            this.resultFolderPathLabel.Text = "Путь к результирующей папке";
            // 
            // resultFolderPathTextBox
            // 
            this.resultFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFolderPathTextBox.Location = new System.Drawing.Point(24, 229);
            this.resultFolderPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultFolderPathTextBox.Name = "resultFolderPathTextBox";
            this.resultFolderPathTextBox.Size = new System.Drawing.Size(368, 20);
            this.resultFolderPathTextBox.TabIndex = 5;
            // 
            // folderPathButton
            // 
            this.folderPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderPathButton.Image = global::ExcelToWordProject.Properties.Resources.folder;
            this.folderPathButton.Location = new System.Drawing.Point(452, 229);
            this.folderPathButton.Name = "folderPathButton";
            this.folderPathButton.Size = new System.Drawing.Size(26, 26);
            this.folderPathButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folderPathButton.TabIndex = 7;
            this.folderPathButton.TabStop = false;
            this.folderPathButton.Click += new System.EventHandler(this.folderPathButton_Click);
            // 
            // SosParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 402);
            this.Controls.Add(this.folderPathButton);
            this.Controls.Add(this.resultFolderPathLabel);
            this.Controls.Add(this.resultFolderPathTextBox);
            this.MinimumSize = new System.Drawing.Size(642, 441);
            this.Name = "SosParser";
            this.Text = "SosParser";
            ((System.ComponentModel.ISupportInitialize)(this.folderPathButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox folderPathButton;
        private System.Windows.Forms.Label resultFolderPathLabel;
        private System.Windows.Forms.TextBox resultFolderPathTextBox;
    }
}