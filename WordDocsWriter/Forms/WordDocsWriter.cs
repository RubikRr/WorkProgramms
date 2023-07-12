using EduPlans.Db;
using EduPlans.Db.Сontexts.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordDocsWriter.Syllabus;

namespace WordDocsWriter
{
    public partial class WordDocsWriter : Form
    {
        private string wordFileType;
        private bool writeAllSubjects;
        private int admissionYear;
        private int docYear;
        private string speciality;

        public WordDocsWriter()
        {
            InitializeComponent();
            FillComboBoxSpeciality(comboBoxSpeciality);
            SetDefaultValuesForFields();
        }


        /// <summary>
        /// устанавливает дефолтные значения для всех полей формы
        /// </summary>
        private void SetDefaultValuesForFields()
        {
            resultFolderPathTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            comboBoxWordFileType.Text = comboBoxWordFileType.Items[0].ToString();
            writeAllSubjects = false;
            ChangePictureBoxAllSubjectsState(pictureBoxAllSubjects);
        }


        private void ResetComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Text = string.Empty;
        }

        /// <summary>
        /// Заполняет коллекцию ComboBox'a всеми дисциплинами из базы 
        /// </summary>
        private void ChangeComboBoxSubjectNameItems(ComboBox comboBox, int admissionYear, int docYear, string speciality)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(DBReader.GetSubjects(admissionYear, docYear, speciality).ToArray());
        }

        /// <summary>
        /// Заполняет коллекцию ComboBox'a всеми специальностями из базы 
        /// </summary>
        private void FillComboBoxSpeciality(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(DBReader.GetAllSpecialties().ToArray());
        }

        /// <summary>
        /// Заполняет коллекцию ComboBox'a всеми возможными годами поступления из базы 
        /// </summary>
        private void ChangeComboBoxAdmissionYear(ComboBox comboBox, string speciality)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(DBReader.GetAdmissionYears(speciality).ToArray());
        }

        /// <summary>
        /// Заполняет коллекцию ComboBox'a всеми возможными годами документов из базы 
        /// </summary>
        private void ChangeComboBoxDocYear(ComboBox comboBox, string speciality, int admissionYear)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(DBReader.GetDocYears(speciality, admissionYear).ToArray());
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                var pictureBoxWriteButton = sender as PictureBox;
                pictureBoxAllSubjects.Enabled = false;

                var wordFileType = comboBoxWordFileType.Text;
                var docYear = comboBoxDocYear.Text; // current_year in BD
                var admissionYear = comboBoxDocYear.Text; //date_enter in BD
                var speciality = comboBoxSpeciality.Text;
                var subjectName = comboBoxSubjectName.Text;
                var resultFolderPath = resultFolderPathTextBox.Text;

                try
                {
                    Directory.CreateDirectory(resultFolderPath);
                    // Begin generation
                }
                catch (Exception err)
                {

                    throw err;
                }

                pictureBoxAllSubjects.Enabled = true;
            }            
        }


        /// <summary>
        /// Изменяет состояние кастомного CheckButton'а (PictureBox)
        /// </summary>
        /// <param name="pictureBox"></param>
        private void ChangePictureBoxAllSubjectsState(PictureBox pictureBox)
        {
            if (writeAllSubjects)
            {
                pictureBox.Image = Properties.Resources.uncheck;
                writeAllSubjects = false;
            }
            else
            {
                pictureBox.Image = Properties.Resources.check;
                writeAllSubjects = true;
            }
            comboBoxSubjectName.Enabled = !writeAllSubjects;
        }

        private void pictureBoxAllSubjects_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                ChangePictureBoxAllSubjectsState(sender as PictureBox);
                Console.WriteLine("klick");
            }
        }

        private void folderPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = resultFolderPathTextBox.Text;
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                resultFolderPathTextBox.Text = folderDialog.SelectedPath;
            }
        }

        private void comboBoxSpeciality_SelectedIndexChanged(object sender, EventArgs e)
        {
            speciality = (sender as ComboBox).Text;
            ResetComboBox(comboBoxAdmissionYear);
            ChangeComboBoxAdmissionYear(comboBoxAdmissionYear,speciality);
            ResetComboBox(comboBoxDocYear);
            ResetComboBox(comboBoxSubjectName);
        }

        private void comboBoxDocYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            docYear = Convert.ToInt32((sender as ComboBox).Text);
            ChangeComboBoxSubjectNameItems(comboBoxSubjectName, admissionYear, docYear, speciality);
        }

        private void comboBoxAdmissionYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            admissionYear = Convert.ToInt32((sender as ComboBox).Text);
            ResetComboBox(comboBoxDocYear);
            ChangeComboBoxDocYear(comboBoxDocYear, speciality, admissionYear);
            ResetComboBox(comboBoxSubjectName);
        }
    }
}
