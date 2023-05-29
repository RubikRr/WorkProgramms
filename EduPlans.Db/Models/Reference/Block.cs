using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    public class Block
    {
        public int Id { get; set; }
        [Column("block_title")]
        public string BlockTitle { get; set; }
        [Column("part_title")]
        public string PartTitle { get; set; }


    }
}
