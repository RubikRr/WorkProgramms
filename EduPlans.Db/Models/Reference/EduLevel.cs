using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models.Reference
{
    [Table("edu_levels")]
    public class EduLevel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Level { get; set; }
    }
}
