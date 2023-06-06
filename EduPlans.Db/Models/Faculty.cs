using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("faculties")]
    public class Faculty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column("dean_id")]
        public int DeanId { get; set; }

    }
}
