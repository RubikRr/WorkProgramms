using EduPlans.Db;
using EduPlans.Db.Models;
using EduPlans.Db.Models.Reference;
using EduPlans.Db.Сontexts.Reference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordDocsWriter.Syllabus
{
    internal class DBReader
    {
        private List<Module> modules;

        public DBReader(List<string> subjects)
        {

        }

        public static List<string> GetAdmissionYears(string speciality)
        {
            List<string> values = new List<string>();
            using (SpecialityContext specc = new SpecialityContext())
            {
                int specialityId = specc.GetSpecialty(speciality).Id;
                using (TitlePlanContext tpc = new TitlePlanContext())
                {
                    values = tpc.GetTitlePlansBySpecId(specialityId).Select(tp => tp.DateEnter.ToString()).ToList();
                }
            }
            return values;
        }

        public static List<string> GetDocYears(string speciality, int dateEnter)
        {
            List<string> values = new List<string>();
            using (SpecialityContext specc = new SpecialityContext())
            {
                int specialityId = specc.GetSpecialty(speciality).Id;
                using (TitlePlanContext tpc = new TitlePlanContext())
                {
                    values = tpc.GetTitlePlansByDateEnterAndSpecId(specialityId, dateEnter).Select(tp => tp.CurrentYear.ToString()).ToList();
                }
            }
            return values;
        }

        public static List<string> GetAllSpecialties()
        {
            List<string> values = new List<string>();

            using (SpecialityContext specc = new SpecialityContext())
            {
                values = specc.GetAllTitles();
            }
            return values;
        }

        public static List<string> GetSubjects(int dateEnter, int currentYear, string speciality = null)
        {
            List<string> values = new List<string>();

            if (String.IsNullOrEmpty(speciality))
            {
                using (SubjectContext subc = new SubjectContext())
                {
                    foreach (var item in subc.Subjects)
                        values.Add(item.ToString());
                }
            }
            else
            {
                using (SpecialityContext specc = new SpecialityContext())
                {
                    int specialityId = specc.GetSpecialty(speciality).Id;

                    using (TitlePlanContext tpc = new TitlePlanContext())
                    {
                        int titlePlanId = tpc.GetTitlePlan(specialityId, dateEnter, currentYear).Id;

                        using (EduPlanContext epc = new EduPlanContext())
                        {
                            List<int> SubjectIdList = epc.GetEduPlansSubjectId(titlePlanId);

                            using (SubjectContext subc = new SubjectContext())
                            {
                                values = subc.GetSubjectsTitle(SubjectIdList);
                            }
                        }
                    }
                }
            }
            
            return values;
        }

        public enum Tables
        {
            None,
            Speciality,
            Subjects,
        }
    }
}
