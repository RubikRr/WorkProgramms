using EduPlans.Db.Models.Reference;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class EduLevelContext:DbContext
    {
        public DbSet<EduLevel> EduLevels { get; set; }
        public EduLevelContext() : base("EduPlansDb") { }

       
    }
}
