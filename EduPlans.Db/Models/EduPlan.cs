using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("edu_plan")]
    public class EduPlan
    {
        public int Id { get; set; }
        [Column("block_id")]
        public int BlockId { get; set; }
        [Column("subject_id")]
        public int SubjectId { get; set; }
        [Column("code_subject")]
        public string CodeSubject { get; set; }

        //Кафедра
        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("title_plan_id")]
        public int TitlePlanId { get; set; }

    }
}
