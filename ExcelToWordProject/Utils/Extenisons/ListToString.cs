using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToWordProject.Extenisons
{
    public static class ListToString
    {
        public static string  InLine(this List<int> list)
        {
            return String.Join(" ", list);
        }
    }
}
