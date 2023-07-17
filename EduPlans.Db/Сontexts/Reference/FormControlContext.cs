using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class FormControlContext : DbContext
    {
        public DbSet<FormControl> FormControls { get; set; }

        public FormControlContext() : base("EduPlansDb") { }

        public FormControl GetFormControl(string title)
        {
            return FormControls.FirstOrDefault(c => c.Title == title);
        }

        public int GetFormControlId(string title)
        {
            return GetFormControl(title)?.Id ?? 0;
        }
    }
}
