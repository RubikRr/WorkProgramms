using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models.Reference
{
    [Table("speciality")]
    public class Speciality
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Code { get; set; }
        public string Profile { get; set; }
        [Column("edu_level_id")]
        public int EduLevelId { get; set; }
    }
}
