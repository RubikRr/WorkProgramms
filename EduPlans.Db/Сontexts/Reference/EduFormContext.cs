using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db
{
    public class EduFormContext:DbContext
    {
        public DbSet<EduForm> Edu_Forms { get; set; }

        public EduFormContext(DbConnection connection, bool contextOwnConnection) : base(connection, contextOwnConnection) { }

        public void Add(string name)
        {
            var eduForm = new EduForm { Title = name };
            Edu_Forms.Add(eduForm);

        }

    }
}
