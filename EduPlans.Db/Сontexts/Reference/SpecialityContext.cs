using EduPlans.Db.Models.Reference;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class SpecialityContext:DbContext
    {
        public DbSet<Speciality> Specialities { get; set; }
        public SpecialityContext():base("EduPlansDb") { }

        public List<string> GetAllTitles()
        {
            return Specialities
                .Select(x => x.Title)
                .ToList();
        }

        public Speciality GetSpecialty(string title)
        {
            return Specialities.FirstOrDefault(s => s.Title == title);
        }

        public Speciality GetSpecialty(int id)
        {
            return Specialities.FirstOrDefault(s => s.Id == id);

        }

        public int GetSpecialtyId(string title)
        {
            return GetSpecialty(title)?.Id ?? 0;
        }
    }
}
