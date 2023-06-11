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
    }
}
