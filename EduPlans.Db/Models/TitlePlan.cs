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

        public TitlePlan(string specialityCode, DateTime dateUchsovet, int numberUchsovet, int dateEnter, 
            DateTime dateFgos, int numberFgos, string departmentTitle, string included)
        {
            using (SpecialityContext sc = new SpecialityContext())
            {
                SpecId = sc.GetSpecialtyId(specialityCode);
            }
            using (DepartmentContext dc = new DepartmentContext())
            {
                DepartmentId = dc.GetDepartmentId(departmentTitle);
            }            
            DateUchsovet = dateUchsovet;
            NumberUchsovet = numberUchsovet;    
            CurrentYear = DateTime.Now.Year;
            DateEnter = dateEnter;
            DateFgos = dateFgos;
            NumberFgos = numberFgos;
            Included = included;
        }
        public TitlePlan() { }

        public override string  ToString()
        {
            return $"Айди:{Id}\nСпециальность:{SpecId}\nКафедра:{DepartmentId}\nДата уч. совета:{DateUchsovet}  Номер уч. совета:{NumberUchsovet}\nДата ФГОС:{DateFgos} номер ФГОС:{NumberFgos} \nДата поступления:{DateEnter}\nIdКафедры:{DepartmentId}";
        }
    }
}
