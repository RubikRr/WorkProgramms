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

        public List<EduPlanFormControl> GetEduPlanFormControlList(int eduSemesterId)
        {
            return EduPlanFormControls.Where(x => x.EduSemesterId == eduSemesterId).ToList();
        }

        public List<int> GetFormControlsIdList(int eduSemesterId)
        {
            return GetEduPlanFormControlList(eduSemesterId).Select(x => x.FormControlId).ToList();
        }
    }
}
