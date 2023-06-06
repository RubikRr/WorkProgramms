﻿using MySqlX.XDevAPI.Relational;
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
        public int specialityId { get; set; }
    }
}
