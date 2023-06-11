using EduPlans.Db;
using EduPlans.Db.Сontexts.Reference;
using ExcelToWordProject.Forms;
using ExcelToWordProject.Models;
using ExcelToWordProject.Syllabus;
using ExcelToWordProject.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ExcelToWordProject
{
    public partial class MainForm : Form
    {
        bool LockButtons = false;
        DefaultTagSettingsForm DefaultTagSettingsForm;
        SmartTagSettingsForm SmartTagSettingsForm;
        TagListForm TagListForm;
        GetDataParametersForm getDataParametersForm;


        SyllabusParameters syllabusParameters;

        string[] selectedExcels = new string[0];

        public MainForm()
        {
            InitializeComponent();

            syllabusParameters = ConfigManager.GetConfigData();

            SetToolTips();

        }

        private void ExcelLoadingMode()
        {

            excelFilesLabel.Visible = true;
            excelFilesLabelClear.Visible = true;
            filePathTextBox.Visible = false;
            filePathTextBox.Text = "";
            excelFilesLabel.Text = "Вы выбрали " + selectedExcels.Length + " ф.";

        }

        //Подсказки на кнопки
        private void SetToolTips()
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(convertButton, "Конвертировать");
            toolTip.SetToolTip(filePathButton, "Выберите файл");
            toolTip.SetToolTip(templateFilePathButton, "Выберите файл");
            toolTip.SetToolTip(folderPathButton, "Выберите папку");
        }

        public async Task ConvertProcessing(string selectedFilePath, string templateFilePath, string resultFolderPath, string prefix)
        {
            SyllabusExcelReader syllabusExcelReader = null;
            SyllabusDocWriter syllabusDocWriter = null;

            try
            {
                syllabusExcelReader = new SyllabusExcelReader(selectedFilePath, syllabusParameters);
                syllabusDocWriter = new SyllabusDocWriter(syllabusExcelReader, syllabusParameters);
                // Проверка на активные смарт теги при неправильном файле
                if (syllabusParameters.HasActiveSmartTags && !syllabusExcelReader.IsSyllabusFile)
                {
                    DialogResult dialogResult = MessageBox.Show("Возможно данный файл " +
                        "(" + selectedFilePath + ") не является " +
                        "файлом учебного плана, но у вас активны \"умные\" теги. Это может стать причиной " +
                        "сбоя в работе программы.\r\nОтключить \"умные\" теги?", "Внимание!", MessageBoxButtons.YesNoCancel);
                    switch (dialogResult)
                    {
                        case DialogResult.Yes:
                            // Склонируем новые параметры
                            SyllabusParameters tempParameters = ConfigManager.GetConfigData();

                            // Закроем старые потоки чтения
                            syllabusExcelReader.Dispose();
                            syllabusDocWriter.Dispose();

                            // Отключим умные теги
                            tempParameters.DisableSmartTags();
                            syllabusExcelReader = new SyllabusExcelReader(selectedFilePath, tempParameters);
                            syllabusDocWriter = new SyllabusDocWriter(syllabusExcelReader, tempParameters);
                            break;
                        case DialogResult.Cancel:
                            return;
                    }
                }

                //syllabusDocWriter.ConvertToDocx(resultFolderPath, templateFilePath, prefix,
                //            new Progress<int>(percent => progressBar1.Value = percent));

                await Task.Run(() => syllabusDocWriter.ConvertToDocx(resultFolderPath, templateFilePath, prefix,
                            new Progress<int>(percent => progressBar1.Value = percent)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\r\n" + ex.Message + "" +
                    "\r\nФайл:" + selectedFilePath,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                syllabusExcelReader?.CloseStreams();

            }
        }

        private async void ConvertButton_Click(object sender, EventArgs e)
        {
            if (LockButtons)
                return;
            LockButtons = true;
            //string selectedFilePath = filePathTextBox.Text;
            string templateFilePath = templateFilePathTextBox.Text;
            string resultFolderPath = resultFolderPathTextBox.Text;



            if (selectedExcels.Length >= 1)
                for (int i = 0; i < selectedExcels.Length; i++)
                {
                    status.Text = "Файл " + (i + 1) + " из " + selectedExcels.Length + "...";

                    string fileName = Path.GetFileNameWithoutExtension(selectedExcels[i]);
                    string folderPath = Path.Combine(resultFolderPath, fileName);

                    try
                    {
                        Directory.CreateDirectory(folderPath);
                        await ConvertProcessing(
                            selectedExcels[i],
                            templateFilePath,
                            folderPath,
                            resultFilePrefixTextBox.Text);
                    }
                    catch
                    {
                        string prefix = "[" + Path.GetFileNameWithoutExtension(selectedExcels[i]) + "] " + resultFilePrefixTextBox.Text;
                        await ConvertProcessing(selectedExcels[i], templateFilePath, resultFolderPath, prefix);
                    }
                }

            LockButtons = false;
            status.Text = "Ожидание...";

        }
        //Выбираем ексельки для парсинга
        private void FilePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel документы|*.xls;*.xlsx";
            fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedExcels = fileDialog.FileNames;
                ExcelLoadingMode();
            }
        }

        private void FolderPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = Application.StartupPath;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                resultFolderPathTextBox.Text = folderDialog.SelectedPath;
            }
        }
        //Выбираем Word шаблон на основе которого будем создавать
        private void TemplateFilePathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Word документы|*.doc;*.docx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                templateFilePathTextBox.Text = fileDialog.FileName;
            }
        }

        private void SmartTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SmartTagSettingsForm == null || SmartTagSettingsForm.IsDisposed)
            {
                SmartTagSettingsForm = new SmartTagSettingsForm(syllabusParameters);
                SmartTagSettingsForm.Show();
            }
            else
                SmartTagSettingsForm.Focus();
        }

        private void DefaultTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DefaultTagSettingsForm == null || DefaultTagSettingsForm.IsDisposed)
            {
                DefaultTagSettingsForm = new DefaultTagSettingsForm(syllabusParameters);
                DefaultTagSettingsForm.Show();
            }
            else
                DefaultTagSettingsForm.Focus();
        }

        private void tagsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TagListForm == null || TagListForm.IsDisposed)
            {
                TagListForm = new TagListForm(syllabusParameters.Tags);
                TagListForm.Show();
            }
            else
                TagListForm.Focus();
        }

        private void ExcelFilesLabelClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            excelFilesLabelClear.Visible = false;
            selectedExcels = new string[0];
        }

        private void ConstantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (getDataParametersForm == null || getDataParametersForm.IsDisposed)
            {
                getDataParametersForm = new GetDataParametersForm(syllabusParameters);
                getDataParametersForm.Show();
            }
            else
                getDataParametersForm.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (EduLevelContext context = new EduLevelContext())
            {
                foreach (var lvl in context.EduLevels)
                {
                    Console.WriteLine($"{lvl.Id} {lvl.Title} {lvl.Level}");
                }
            }
        }
    }
}
