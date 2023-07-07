using EduPlans.Db.Сontexts.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("title_plan")]
    public  class TitlePlan
    {
        public int Id { get; set; }
        [Column("spec_id")]
        public int SpecId { get; set; } = 0;
        public string Profile { get; set; }
        [Column("date_uchsovet")]
        public DateTime DateUchsovet { get; set; }
        [Column("number_uchsovet")]
        public int NumberUchsovet { get; set; }
        [Column("current_year")]
        public int CurrentYear { get; set; }
        [Column("date_enter")]
        public int DateEnter { get; set; }
        [Column("date_fgos")]
        public DateTime DateFgos { get; set; }
        [Column("number_fgos")]
        public int NumberFgos { get; set; }
        [Column("department_id")]
        public int DepartmentId { get; set; } = 0;
        public string Included { get; set; }

        public TitlePlan(string specialityCode, string profile, DateTime dateUchsovet, int numberUchsovet, int dateEnter, 
            DateTime dateFgos, int numberFgos, string departmentTitle, string included)
        {
            SpecId = this.GetSpecialityId(specialityCode);
            Profile = profile;
            DateUchsovet = dateUchsovet;
            NumberUchsovet = numberUchsovet;    
            CurrentYear = DateTime.Now.Year;
            DateEnter = dateEnter;
            DateFgos = dateFgos;
            NumberFgos = numberFgos;
            DepartmentId = this.GetDepartmentId(departmentTitle);
            Included = included;
        }
        public TitlePlan() { }

        public int GetDepartmentId(string departmentTitle)
        {
            using (DepartmentContext dc = new DepartmentContext())
            {
                return dc.Departments.ToList().FirstOrDefault(department => department.Title == departmentTitle)?.Id ?? 0;
            }
        }

        public int GetSpecialityId(string specialityCode)
        {
            using (SpecialityContext dc = new SpecialityContext())
            {
                return dc.Specialities.ToList().FirstOrDefault(speciality => speciality.Code== specialityCode)?.Id ?? 0;
            }
        }


        public override string  ToString()
        {
            return $"Специальность:{SpecId}\nКафедра:{DepartmentId}\nПрофиль:{Profile}\nДата уч. совета:{DateUchsovet}  Номер уч. совета:{NumberUchsovet}\nДата ФГОС:{DateFgos} номер ФГОС:{NumberFgos} \nДата поступления:{DateEnter}\nIdКафедры:{DepartmentId}";
        }
    }
}
