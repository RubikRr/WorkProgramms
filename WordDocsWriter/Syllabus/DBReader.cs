using EduPlans.Db;
using EduPlans.Db.Models;
using EduPlans.Db.Models.Binding;
using EduPlans.Db.Models.Reference;
using EduPlans.Db.Сontexts.Blinding;
using EduPlans.Db.Сontexts.Reference;
using ExcelToWordProject;
using ExcelToWordProject.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordDocsWriter.Syllabus
{
    internal class DBReader
    {
        private List<ExcelToWordProject.Module> modules;

        public DBReader(List<string> subjectsTitles, int dateEnter, int currentYear, string specialityTitle)
        {
            using (SpecialityContext specCon = new SpecialityContext())
            {
                Speciality speciality = specCon.GetSpecialty(specialityTitle);

                using (TitlePlanContext tpCon = new TitlePlanContext())
                {
                    TitlePlan titlePlan = tpCon.GetTitlePlan(speciality.Id, dateEnter, currentYear);

                    foreach (var subjectTitle in subjectsTitles)
                    {
                        List<EduPlan> eduPlans = GetEduplansList(subjectTitle, titlePlan.Id);

                        foreach (EduPlan eduPlan in eduPlans)
                        {
                            List<string> compitensiesCodes = GetCompitensiesCodes(eduPlan.Id);

                            var module = new ExcelToWordProject.Module(
                                eduPlan.CodeSubject,
                                subjectTitle,
                                compitensiesCodes.ToArray(),
                                GetModuleProperties(eduPlan)
                                //new ModuleProperties()
                                );
                        }
                    }
                }
            }
        }

        private ModuleProperties GetModuleProperties(EduPlan eduPlan)
        {
            var moduleProperties = new ModuleProperties();

            using (BlockContext blockCon = new BlockContext())
            {
                var block = blockCon.GetBlock(eduPlan.BlockId);
                moduleProperties.BlockName = block.BlockTitle;
                moduleProperties.PartName = block.PartTitle;

                // Номер блока
                string temp = Regex.Replace(block.BlockTitle, @"[^\d]+", "");
                moduleProperties.BlockNumber = (temp != "") ? Convert.ToInt32(temp) : -1;

            }

            using (EduSemesterContext esCon = new EduSemesterContext())
            {
                var eduSemesters = esCon.GetEduSemesters(eduPlan.Id);
                var creditUnits = 0.0;

                foreach (var eduSemester in eduSemesters)
                {
                    creditUnits += eduSemester.Zed;
                    moduleProperties.Semesters.Add(eduSemester.Semester);

                    moduleProperties.LecturesHoursBySemesters.Add(eduSemester.Lecture);
                    moduleProperties.PracticalLessonsHoursBySemesters.Add(eduSemester.Practice);
                    moduleProperties.LaboratoryLessonsHoursBySemesters.Add(eduSemester.Laboratory);
                    moduleProperties.IndependentWorkHoursBySemesters.Add(eduSemester.IndWork);

                    moduleProperties.TotalHoursByPlan += eduSemester.Lecture + eduSemester.Practice + eduSemester.Laboratory + eduSemester.IndWork;

                    foreach (var formControl in GetControlForms(eduSemester.Id))
                        moduleProperties.ControlFormsBySemesters[formControl].Add(eduSemester.Semester);

                }

            }

            return moduleProperties;
        }
        /*
         пропушено:
        isCourseWork
        Часы контроля
         */

        private List<ControlForm> GetControlForms(int eduSemesterId)
        {
            var formControls = new List<ControlForm>();
            using (EduPlanFormControlContext epfcCon = new EduPlanFormControlContext())
            using (FormControlContext fcCon = new FormControlContext())
            {
                var formControlIdList = epfcCon.GetFormControlsIdList(eduSemesterId);

                foreach (var formControlId in formControlIdList)
                {
                    var formControlTitle = fcCon.GetFormControlTitle(formControlId);
                    var formControl = ModuleProperties.StringToControlForm(formControlTitle);
                    formControls.Add(formControl);
                }
            }
            return formControls;
        }

        private List<string> GetCompitensiesCodes(int eduPlanId)
        {
            using (EduPlanCompetenciesContext epСompCon = new EduPlanCompetenciesContext())
            using (CompetenceContext compCon = new CompetenceContext())
            {
                var compitensiesId = epСompCon.GetEduPlanCompetenciesId(eduPlanId);
                var compitensiesCodes = compCon.GetCompetenciesCodes(compitensiesId);
                return compitensiesCodes;
            }
        }

        private List<EduPlan> GetEduplansList(string subjectTitle, int titlePlanId)
        {
            using (SubjectContext subCon = new SubjectContext())
            {
                Subject subject = subCon.GetSubject(subjectTitle);

                using (EduPlanContext epCon = new EduPlanContext())
                {
                    return epCon.GetEduPlans(titlePlanId, subject.Id);
                }
            }
        }

        public static List<string> GetAdmissionYears(string specialityTitle)
        {
            List<string> values = new List<string>();
            using (SpecialityContext specc = new SpecialityContext())
            {
                Speciality speciality = specc.GetSpecialty(specialityTitle);
                using (TitlePlanContext tpc = new TitlePlanContext())
                {
                    values = tpc.GetTitlePlansBySpecIdDateEnter(speciality.Id);
                }
            }
            return values;
        }

        public static List<string> GetDocYears(string specialityTitle, int dateEnter)
        {
            List<string> values = new List<string>();
            using (SpecialityContext specc = new SpecialityContext())
            {
                Speciality speciality = specc.GetSpecialty(specialityTitle);
                using (TitlePlanContext tpc = new TitlePlanContext())
                {
                    values = tpc.GetTitlePlansCurrentYear(speciality.Id, dateEnter);
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

        public static List<string> GetSubjects(int dateEnter, int currentYear, string specialityTitle)
        {
            List<string> values = new List<string>();
            using (SpecialityContext specc = new SpecialityContext())
            {
                Speciality speciality = specc.GetSpecialty(specialityTitle);

                using (TitlePlanContext tpc = new TitlePlanContext())
                {
                    TitlePlan titlePlan = tpc.GetTitlePlan(speciality.Id, dateEnter, currentYear);

                    using (EduPlanContext epc = new EduPlanContext())
                    {
                        List<int> SubjectIdList = epc.GetEduPlansSubjectId(titlePlan.Id);

                        using (SubjectContext subc = new SubjectContext())
                        {
                            values = subc.GetSubjectsTitle(SubjectIdList);
                        }
                    }
                }
            }
            return values;
        }
    }
}
