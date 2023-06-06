using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("title_plan")]
    public  class TitlePlan
    {
        public int Id { get; set; }
        [Column("spec_id")]
        public int SpecId { get; set; }
        public string Profile { get; set; }
        [Column("date_uchsovet")]
        public DateTime DateUchsovet { get; set; }
        [Column("number_uchsovet")]
        public int NumberUchsovet { get; set; }
        [Column("current_year")]
        public DateTime CurrentYear { get; set; }
        [Column("date_enter")]
        public DateTime DateEnter { get; set; }
        [Column("date_fgos")]
        public DateTime DateFgos { get; set; }
        [Column("number_fgos")]
        public int NumberFgos { get; set; }
        [Column("department_id")]
        public int DepartmentId { get; set; }
        public string Included { get; set; }
    }
}
