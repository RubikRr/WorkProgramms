using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class EduSemesterContext : DbContext
    {
        public DbSet<EduSemester> EduSemesters { get; set; }

        public EduSemesterContext() : base("EduPlansDb") { }

        public void Add(EduSemester eduSemester)
        {
            EduSemesters.Add(eduSemester);
        }

        public List<EduSemester> GetEduSemesters(int eduPlanId)
        {
            return EduSemesters.Where(es => es.EduPlanId == eduPlanId).ToList();
        }
    }
}
