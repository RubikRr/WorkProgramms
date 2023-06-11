using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    [Table("title_plan")]
    public class TitlePlanContext : DbContext
    {
        public DbSet<TitlePlan> TitlePlans { get; set; }

        public TitlePlanContext() : base("EduPlansDb") { }

        public void Add(TitlePlan titlePlan)
        {
            TitlePlans.Add(titlePlan);
        }
    }
}
