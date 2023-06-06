using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.EntityFramework;

namespace EduPlans.Db
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SubjectContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
       

        public SubjectContext():base("EduPlansDb")
        { 
        }

        public SubjectContext(DbConnection connection, bool contextOwnConnection) : base(connection, contextOwnConnection) { }

        public void Add(string name)
        {
            var subject = new Subject { Title=name};
            Subjects.Add(subject);
        }
       
       

    }
}
