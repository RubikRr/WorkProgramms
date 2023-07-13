using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class CompetenceContext : DbContext
    {
        public DbSet<Competence> Competencies { get; set; }

        public CompetenceContext() : base("EduPlansDb") { }

        public void Add(Competence competence)
        {
            if (!Competencies.Any(x => x.Code == competence.Code))
                Competencies.Add(competence);
        }

        public Competence GetCompetence(int competencyId)
        {
            return Competencies.FirstOrDefault(competence => competence.Id == competencyId);
        }
        public List<Competence> GetCompetencies(List<int> competenciesId)
        {
            return Competencies
                .Where(competence => competenciesId
                .Contains(competence.Id))
                .ToList();
        }
        public List<string> GetCompetenciesCodes(List<int> competenciesId)
        {
            return GetCompetencies(competenciesId).Select(c => c.Code).ToList();
        }
    }
}
