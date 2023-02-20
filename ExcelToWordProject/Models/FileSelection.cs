using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelToWordProject.Models
{
    internal class FileSelection
    {
        public static string ResultPath()
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = Application.StartupPath;
            if (folderDialog.ShowDialog() == DialogResult.OK)
                return folderDialog.SelectedPath;
            return null;
        }

        
    }
}
