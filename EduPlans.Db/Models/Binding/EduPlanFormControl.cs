using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models.Binding
{
    [Table("edu_plan_form_control")]
    public class EduPlanFormControl
    {
        public int Id { get; set; }
        [Column("edu_semester_id")]
        public int EduSemesterId { get; set; }
        [Column("form_control_id")]
        public int FormControlId { get; set; }
    }
}
