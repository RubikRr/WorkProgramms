using EduPlans.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordDocsWriter
{
    public partial class WordDocsWriter : Form
    {
        private string wordFileType;
        private bool writeAllSubjects;

        public WordDocsWriter()
        {
            InitializeComponent();
            FillComboBoxSubjectNameItems();
        }

        private void FillComboBoxSubjectNameItems()
        {
            using (SubjectContext sc = new SubjectContext())
            {
                
            }
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            wordFileType = comboBoxWordFileType.Text;
        }

        private void pictureBoxAllSubjects_Click(object sender, EventArgs e)
        {

            if (sender is PictureBox)
            {
                var pictureBoxAllSubjects = sender as PictureBox;
                if (writeAllSubjects)
                {
                    pictureBoxAllSubjects.Image = Properties.Resources.uncheck;
                    writeAllSubjects = false;
                }
                else
                {
                    pictureBoxAllSubjects.Image = Properties.Resources.check2;
                    writeAllSubjects = true;
                }

                this.comboBoxSubjectName.Enabled = !writeAllSubjects;
                Console.WriteLine("klick");
            }
        }
    }
}
