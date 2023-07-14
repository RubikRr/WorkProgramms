using EduPlans.Db.Models.Binding;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Blinding
{
    public class EduPlanFormControlContext : DbContext
    {
        public DbSet<EduPlanFormControl> EduPlanFormControls { get; set; }

        public EduPlanFormControlContext() : base("EduPlansDb") { }

        public void Add(EduPlanFormControl eduPlanFormControl)
        {
            EduPlanFormControls.Add(eduPlanFormControl);
        }


    }
}
