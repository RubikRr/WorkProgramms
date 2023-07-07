using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class CompetenceContext:DbContext
    {
        public DbSet<Competence> Competencies { get; set; }

        public CompetenceContext():base("EduPlansDb") { }

        public void Add(Competence competence)
        {
            if(!Competencies.Any(x=>x.Code==competence.Code))
                Competencies.Add(competence);
        }
    }
}
