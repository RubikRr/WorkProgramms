using EduPlans.Db.Сontexts.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models
{
    [Table("edu_plan")]
    public class EduPlan
    {
        public int Id { get; set; }
        [Column("block_id")]
        public int BlockId { get; set; }
        [Column("subject_id")]
        public int SubjectId { get; set; }
        [Column("code_subject")]
        public string CodeSubject { get; set; } = "0";

        [Column("department_id")]
        public int DepartmentId { get; set; }

        [Column("title_plan_id")]
        public int TitlePlanId { get; set; }

        public EduPlan(string blockTitle,string partTitle,string subjectName,string subjectCode,string departmentTitle,int titilePlanId=0) 
        {
            BlockId = GetBlockId(blockTitle, partTitle);
            SubjectId = GetSubjectId(subjectName);
            CodeSubject = subjectCode!=""?subjectCode:"0";
            DepartmentId = GetDepartmentId(departmentTitle);
            TitlePlanId = titilePlanId;

        }

        public int GetSubjectId(string subjectName)
        {
            using (SubjectContext dc = new SubjectContext())
            {
                return dc.Subjects.ToList().FirstOrDefault(subject => subject.Title == subjectName)?.Id ?? 0;
            }
        }

        public int GetBlockId(string blockTitle,string partTitle)
        {
            using (BlockContext dc = new BlockContext())
            {
                return dc.Blocks.ToList().FirstOrDefault(block => block.BlockTitle == blockTitle && (block.PartTitle==partTitle ||block.PartTitle==""))?.Id ?? 0;
            }
        }

        public int GetDepartmentId(string departmentTitle)
        {
            using (DepartmentContext dc = new DepartmentContext())
            {
                return dc.Departments.ToList().FirstOrDefault(department => department.Title == departmentTitle)?.Id ?? 0;
            }
        }
    }
}
