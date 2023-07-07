using EduPlans.Db.Models.Binding;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Blinding
{
    public class EduPlanCompetenciesContext : DbContext
    {
        public DbSet<EduPlanCompetencies> EduPlanCompetencies { get; set; }

        public EduPlanCompetenciesContext():base("EduPlansDb") { }

        public void Add(EduPlanCompetencies eduPlanCompetencies)
        {
            EduPlanCompetencies.Add(eduPlanCompetencies);
        }
    }
}
