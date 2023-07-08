namespace WordDocsWriter
{
    partial class WordDocsWriter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordDocsWriter));
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.bodyGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubjectName = new System.Windows.Forms.ComboBox();
            this.pictureBoxAllSubjects = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDocYear = new System.Windows.Forms.Label();
            this.dateTimePickerAdmissionYear = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDocYear = new System.Windows.Forms.DateTimePicker();
            this.comboBoxWordFileType = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.resultFilePrefixLabel = new System.Windows.Forms.Label();
            this.resultFilePrefixTextBox = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.PictureBox();
            this.folderPathButton = new System.Windows.Forms.PictureBox();
            this.resultFolderPathLabel = new System.Windows.Forms.Label();
            this.resultFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.bodyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllSubjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderPathButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodyPanel.Controls.Add(this.bodyGroupBox);
            this.bodyPanel.Location = new System.Drawing.Point(0, 25);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Padding = new System.Windows.Forms.Padding(15, 7, 15, 14);
            this.bodyPanel.Size = new System.Drawing.Size(626, 533);
            this.bodyPanel.TabIndex = 3;
            // 
            // bodyGroupBox
            // 
            this.bodyGroupBox.Controls.Add(this.comboBoxSpeciality);
            this.bodyGroupBox.Controls.Add(this.label5);
            this.bodyGroupBox.Controls.Add(this.label3);
            this.bodyGroupBox.Controls.Add(this.comboBoxSubjectName);
            this.bodyGroupBox.Controls.Add(this.pictureBoxAllSubjects);
            this.bodyGroupBox.Controls.Add(this.label2);
            this.bodyGroupBox.Controls.Add(this.label1);
            this.bodyGroupBox.Controls.Add(this.labelDocYear);
            this.bodyGroupBox.Controls.Add(this.dateTimePickerAdmissionYear);
            this.bodyGroupBox.Controls.Add(this.dateTimePickerDocYear);
            this.bodyGroupBox.Controls.Add(this.comboBoxWordFileType);
            this.bodyGroupBox.Controls.Add(this.progressBar1);
            this.bodyGroupBox.Controls.Add(this.resultFilePrefixLabel);
            this.bodyGroupBox.Controls.Add(this.resultFilePrefixTextBox);
            this.bodyGroupBox.Controls.Add(this.writeButton);
            this.bodyGroupBox.Controls.Add(this.folderPathButton);
            this.bodyGroupBox.Controls.Add(this.resultFolderPathLabel);
            this.bodyGroupBox.Controls.Add(this.resultFolderPathTextBox);
            this.bodyGroupBox.Controls.Add(this.filePathLabel);
            this.bodyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyGroupBox.Location = new System.Drawing.Point(15, 7);
            this.bodyGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.bodyGroupBox.Name = "bodyGroupBox";
            this.bodyGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.bodyGroupBox.Size = new System.Drawing.Size(596, 512);
            this.bodyGroupBox.TabIndex = 1;
            this.bodyGroupBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(429, 251);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Все дисциплины";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSubjectName
            // 
            this.comboBoxSubjectName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSubjectName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSubjectName.FormattingEnabled = true;
            this.comboBoxSubjectName.Location = new System.Drawing.Point(13, 281);
            this.comboBoxSubjectName.Name = "comboBoxSubjectName";
            this.comboBoxSubjectName.Size = new System.Drawing.Size(542, 26);
            this.comboBoxSubjectName.TabIndex = 20;
            // 
            // pictureBoxAllSubjects
            // 
            this.pictureBoxAllSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAllSubjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAllSubjects.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAllSubjects.Image")));
            this.pictureBoxAllSubjects.Location = new System.Drawing.Point(402, 251);
            this.pictureBoxAllSubjects.Name = "pictureBoxAllSubjects";
            this.pictureBoxAllSubjects.Size = new System.Drawing.Size(26, 26);
            this.pictureBoxAllSubjects.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAllSubjects.TabIndex = 19;
            this.pictureBoxAllSubjects.TabStop = false;
            this.pictureBoxAllSubjects.Click += new System.EventHandler(this.pictureBoxAllSubjects_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дисциплина";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Год Поступления";
            // 
            // labelDocYear
            // 
            this.labelDocYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDocYear.AutoSize = true;
            this.labelDocYear.Location = new System.Drawing.Point(10, 86);
            this.labelDocYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDocYear.Name = "labelDocYear";
            this.labelDocYear.Size = new System.Drawing.Size(116, 18);
            this.labelDocYear.TabIndex = 15;
            this.labelDocYear.Text = "Год Документа";
            // 
            // dateTimePickerAdmissionYear
            // 
            this.dateTimePickerAdmissionYear.CustomFormat = "yyyy";
            this.dateTimePickerAdmissionYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAdmissionYear.Location = new System.Drawing.Point(152, 107);
            this.dateTimePickerAdmissionYear.Name = "dateTimePickerAdmissionYear";
            this.dateTimePickerAdmissionYear.ShowUpDown = true;
            this.dateTimePickerAdmissionYear.Size = new System.Drawing.Size(61, 26);
            this.dateTimePickerAdmissionYear.TabIndex = 14;
            // 
            // dateTimePickerDocYear
            // 
            this.dateTimePickerDocYear.CustomFormat = "yyyy";
            this.dateTimePickerDocYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDocYear.Location = new System.Drawing.Point(13, 107);
            this.dateTimePickerDocYear.Name = "dateTimePickerDocYear";
            this.dateTimePickerDocYear.ShowUpDown = true;
            this.dateTimePickerDocYear.Size = new System.Drawing.Size(61, 26);
            this.dateTimePickerDocYear.TabIndex = 13;
            // 
            // comboBoxWordFileType
            // 
            this.comboBoxWordFileType.AutoCompleteCustomSource.AddRange(new string[] {
            "Рабочая программа",
            "Аннотация",
            "Кадровая справка"});
            this.comboBoxWordFileType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWordFileType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWordFileType.FormattingEnabled = true;
            this.comboBoxWordFileType.Items.AddRange(new object[] {
            "Рабочая программа",
            "Аннотация",
            "Кадровая справка"});
            this.comboBoxWordFileType.Location = new System.Drawing.Point(13, 44);
            this.comboBoxWordFileType.Name = "comboBoxWordFileType";
            this.comboBoxWordFileType.Size = new System.Drawing.Size(266, 26);
            this.comboBoxWordFileType.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(13, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 27);
            this.progressBar1.TabIndex = 10;
            // 
            // resultFilePrefixLabel
            // 
            this.resultFilePrefixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFilePrefixLabel.AutoSize = true;
            this.resultFilePrefixLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultFilePrefixLabel.Location = new System.Drawing.Point(10, 398);
            this.resultFilePrefixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultFilePrefixLabel.Name = "resultFilePrefixLabel";
            this.resultFilePrefixLabel.Size = new System.Drawing.Size(173, 34);
            this.resultFilePrefixLabel.TabIndex = 5;
            this.resultFilePrefixLabel.Text = "Префикс к имени\r\nрезультирующего файла";
            // 
            // resultFilePrefixTextBox
            // 
            this.resultFilePrefixTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFilePrefixTextBox.Location = new System.Drawing.Point(191, 402);
            this.resultFilePrefixTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultFilePrefixTextBox.Name = "resultFilePrefixTextBox";
            this.resultFilePrefixTextBox.Size = new System.Drawing.Size(397, 26);
            this.resultFilePrefixTextBox.TabIndex = 4;
            // 
            // writeButton
            // 
            this.writeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.writeButton.BackColor = System.Drawing.SystemColors.Control;
            this.writeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.writeButton.ErrorImage = null;
            this.writeButton.Image = ((System.Drawing.Image)(resources.GetObject("writeButton.Image")));
            this.writeButton.InitialImage = null;
            this.writeButton.Location = new System.Drawing.Point(525, 435);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(64, 64);
            this.writeButton.TabIndex = 6;
            this.writeButton.TabStop = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // folderPathButton
            // 
            this.folderPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.folderPathButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.folderPathButton.Image = ((System.Drawing.Image)(resources.GetObject("folderPathButton.Image")));
            this.folderPathButton.Location = new System.Drawing.Point(562, 355);
            this.folderPathButton.Name = "folderPathButton";
            this.folderPathButton.Size = new System.Drawing.Size(26, 26);
            this.folderPathButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.folderPathButton.TabIndex = 4;
            this.folderPathButton.TabStop = false;
            this.folderPathButton.Click += new System.EventHandler(this.folderPathButton_Click);
            // 
            // resultFolderPathLabel
            // 
            this.resultFolderPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFolderPathLabel.AutoSize = true;
            this.resultFolderPathLabel.Location = new System.Drawing.Point(10, 333);
            this.resultFolderPathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultFolderPathLabel.Name = "resultFolderPathLabel";
            this.resultFolderPathLabel.Size = new System.Drawing.Size(221, 18);
            this.resultFolderPathLabel.TabIndex = 3;
            this.resultFolderPathLabel.Text = "Путь к результирующей папке";
            // 
            // resultFolderPathTextBox
            // 
            this.resultFolderPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFolderPathTextBox.Location = new System.Drawing.Point(13, 355);
            this.resultFolderPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultFolderPathTextBox.Name = "resultFolderPathTextBox";
            this.resultFolderPathTextBox.Size = new System.Drawing.Size(542, 26);
            this.resultFolderPathTextBox.TabIndex = 2;
            // 
            // filePathLabel
            // 
            this.filePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(10, 23);
            this.filePathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(192, 18);
            this.filePathLabel.TabIndex = 1;
            this.filePathLabel.Text = "Тип файла для генерации";
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSpeciality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSpeciality.ItemHeight = 18;
            this.comboBoxSpeciality.Location = new System.Drawing.Point(13, 192);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(542, 26);
            this.comboBoxSpeciality.TabIndex = 24;
            this.comboBoxSpeciality.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeciality_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Специальность";
            // 
            // WordDocsWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 583);
            this.Controls.Add(this.bodyPanel);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(642, 441);
            this.Name = "WordDocsWriter";
            this.Text = "WordDocsWriter";
            this.bodyPanel.ResumeLayout(false);
            this.bodyGroupBox.ResumeLayout(false);
            this.bodyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAllSubjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.writeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.folderPathButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.GroupBox bodyGroupBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label resultFilePrefixLabel;
        private System.Windows.Forms.TextBox resultFilePrefixTextBox;
        private System.Windows.Forms.PictureBox writeButton;
        private System.Windows.Forms.PictureBox folderPathButton;
        private System.Windows.Forms.Label resultFolderPathLabel;
        private System.Windows.Forms.TextBox resultFolderPathTextBox;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.ComboBox comboBoxWordFileType;
        private System.Windows.Forms.DateTimePicker dateTimePickerDocYear;
        private System.Windows.Forms.Label labelDocYear;
        private System.Windows.Forms.DateTimePicker dateTimePickerAdmissionYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxAllSubjects;
        private System.Windows.Forms.ComboBox comboBoxSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSpeciality;
        private System.Windows.Forms.Label label5;
    }
}

