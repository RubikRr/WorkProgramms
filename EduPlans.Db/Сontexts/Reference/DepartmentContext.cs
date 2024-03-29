﻿using EduPlans.Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Сontexts.Reference
{
    public class DepartmentContext:DbContext
    {
        public DbSet<Depatment> Departments { get; set; }
        public DepartmentContext():base("EduPlansDb") { }

        public void Add(Depatment depatment)
        {
            if (!Departments.Any(x => x.Title == depatment.Title))
            {
                Departments.Add(depatment);
            }
        }

        public Depatment GetDepartment(int id)
        {
            return Departments.FirstOrDefault(department => department.Id == id);
        }

        public string GetDepartmentTitle(int id)
        {
            return GetDepartment(id)?.Title;
        }

        public Depatment GetDepartment(string title)
        {
            return Departments.FirstOrDefault(department => department.Title == title);
        }

        public int GetDepartmentId(string title)
        {
            return Departments.FirstOrDefault(department => department.Title == title)?.Id ?? 0;
        }
    }
}
