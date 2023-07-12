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

        public List<TitlePlan> GetTitlePlansBySpecId(int specId)
        {
            return TitlePlans.Where(x => x.Id == specId).ToList();
        }

        public List<TitlePlan> GetTitlePlansByDateEnter(int dateEnter)
        {
            return TitlePlans.Where(x => x.DateEnter == dateEnter).ToList();
        }

        public List<TitlePlan> GetTitlePlansByDateEnterAndSpecId(int specId, int dateEnter)
        {
            return TitlePlans.Where(x => x.Id == specId && x.DateEnter == dateEnter).ToList();
        }

        public TitlePlan GetTitlePlan(int specId, int dateEnter, int currentYear)
        {
            return TitlePlans.Where(x => x.Id == specId && x.DateEnter == dateEnter && x.CurrentYear == currentYear).First();
        }

    }
}
