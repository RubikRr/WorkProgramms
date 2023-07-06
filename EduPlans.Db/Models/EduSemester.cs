using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("edu_semesters")]
    public class EduSemester
    {
        public int Id { get; set; }
        [Column("edu_plan_id")]
        public int EduPlanId { get; set; }
        public int Semester { get; set; }
        public Double Zed { get; set; }
        public int Lecture { get; set; }
        public int Practice { get; set; }
        public int Laboratory { get; set; }
        [Column("ind_work")]
        public int IndWork { get; set; }

        public EduSemester() { }
        public EduSemester(int eduPlanId,int semester,double zed,int lecture,int practice,int laboratory, int indWord)
        {
            EduPlanId= eduPlanId;
            Semester= semester;
            Zed= zed;
            Lecture= lecture;
            Practice= practice;
            Laboratory= laboratory;
            IndWork= indWord;
        }
    }
}
