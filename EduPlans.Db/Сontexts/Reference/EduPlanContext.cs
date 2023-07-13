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

        public List<EduPlan> GetEduPlans(int titlePlanId)
        {
            return EduPlans
                .Where(ep => ep.TitlePlanId == titlePlanId)
                .ToList();
        }

        public List<EduPlan> GetEduPlans(int titlePlanId, int subjectId)
        {
            return EduPlans
                .Where(ep => ep.TitlePlanId == titlePlanId && ep.SubjectId == subjectId)
                .ToList();
        }

        public List<int> GetEduPlansSubjectId(int titlePlanId)
        {
            return GetEduPlans(titlePlanId)
                .Select(ep => ep.SubjectId)
                .ToList();
        }
    }
}
