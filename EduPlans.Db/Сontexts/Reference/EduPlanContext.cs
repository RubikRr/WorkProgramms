using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class EduPlanContext:DbContext
    {
        public DbSet<EduPlan> EduPlans { get; set; }

        public EduPlanContext() : base("EduPlansDb") { }

        public void Add(EduPlan eduPlan)
        {
            EduPlans.Add(eduPlan);
        }
    }
}
