﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Title{ get; set; }

        public Subject(string title)
        {
            Title = title;
        }
        public Subject() { }
    }
}
