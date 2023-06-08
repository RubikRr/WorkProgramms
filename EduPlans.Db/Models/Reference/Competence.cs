using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("competence")]
    public class Competence
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        [Column("speciality_id")]
        public int SpecialityId { get; set; }


        public Competence( string code, string descpription, int specialityId = 0)
        {
            Code = code;
            Description = descpription;
            SpecialityId = specialityId;
        }
    }
}
