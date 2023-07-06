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
        { }

        public SubjectContext(DbConnection connection, bool contextOwnConnection) : base(connection, contextOwnConnection) { }

        public void Add(string subjectTitle)
        {
            if (subjectTitle.Trim() == "") // если пусто, то пропускаем
                return;
            var subject = new Subject(subjectTitle);
            if (!Subjects.Any(s => s.Title == subject.Title))
                Subjects.Add(subject);
        }

        public void Add(Subject subject)
        {
            if (subject.Title.Trim() == "") // если пусто, то пропускаем
                return;
            if (!Subjects.Any(s => s.Title == subject.Title))
                Subjects.Add(subject);
        }
    }   
}
