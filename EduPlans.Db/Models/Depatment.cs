using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{

    [Table("departments")]
    public class Depatment
    {
        public int Id { get; set; }
        [Column("faculty_id")]
        public int FacultyId { get; set; }
        public string Title { get; set; }
        [Column("head_id")]
        public int HeadId { get; set; }

        public Depatment(string title,int facultyId=0,int headId=0)
        {
            FacultyId = facultyId;
            Title = title;
            HeadId = headId;
        }
        public Depatment()
        {
            
        }
    }
}
