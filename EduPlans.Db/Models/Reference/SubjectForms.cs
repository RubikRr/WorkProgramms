using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("subject_forms")]
    public class SubjectForms
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
