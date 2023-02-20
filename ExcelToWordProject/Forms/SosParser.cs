using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelToWordProject.Models;

namespace ExcelToWordProject.Forms
{
    public partial class SosParser : Form
    {
        public SosParser()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void folderPathButton_Click(object sender, EventArgs e)
        {
            resultFolderPathTextBox.Text = FileSelection.ResultPath();
        }
    }
}
