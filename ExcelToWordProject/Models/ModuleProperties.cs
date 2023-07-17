using ExcelToWordProject.Extenisons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExcelToWordProject.Models
{
    public class ModuleProperties
    {
        public int TotalLessonsHours { get => TotalLecturesHours + TotalPracticalLessonsHours + TotalLaboratoryLessonsHours; } // Итого аудиторных занятий +

        public List<int> TotalLessonsHoursBySemesters
        {
            get
            {
                List<int> result = new List<int>(LecturesHoursBySemesters);
                for (int i = 0; i < LecturesHoursBySemesters.Count; i++)
                    result[i] += PracticalLessonsHoursBySemesters[i] + LaboratoryLessonsHoursBySemesters[i];
                return result;
            }
        }
        public List<int> Years // Курсы, на которых преподается модуль
        {
            get
            {
                List<int> years = new List<int>();
                Semesters.ForEach(semester =>
                {
                    int year = semester % 2 == 0 ? semester / 2 : semester / 2 + 1;
                    if (!years.Contains(year))
                        years.Add(year);
                });

                return years;
            }
        }

        public int TotalLecturesHours { get => LecturesHoursBySemesters.Sum(); }//+
        public int TotalPracticalLessonsHours { get => PracticalLessonsHoursBySemesters.Sum(); }//+
        public int TotalLaboratoryLessonsHours { get => LaboratoryLessonsHoursBySemesters.Sum(); }//+
        public int TotalIndependentWorkHours { get => IndependentWorkHoursBySemesters.Sum(); }//+
        public int TotalControlHours { get => ControlHoursBySemesters.Sum(); }//+

        public List<ControlForm> Control
        {
            get
            {
                List<ControlForm> controls = new List<ControlForm>();
                Array enumValues = Enum.GetValues(typeof(ControlForm));
                for (int i = 0; i < enumValues.Length - 1; i++)
                {
                    ControlForm controlForm = (ControlForm)enumValues.GetValue(i);
                    if (ControlFormsBySemesters.ContainsKey(controlForm) && ControlFormsBySemesters[controlForm]?.Count > 0)
                        controls.Add(controlForm);
                }
                if (controls.Count == 0)
                    controls.Add(ControlForm.Error);
                return controls;
            }
        }

        public int BlockNumber = -1;
        public string BlockName = "";
        public string PartName = "";
        public string CreditUnits = "-1";
        public string DepartmentName = "";
        public string ModuleCode = "";

        public List<int> LecturesHoursBySemesters = new List<int>();
        public List<int> PracticalLessonsHoursBySemesters = new List<int>();
        public List<int> LaboratoryLessonsHoursBySemesters = new List<int>();
        public List<int> IndependentWorkHoursBySemesters = new List<int>();
        public List<int> ControlHoursBySemesters = new List<int>();
        public List<int> Semesters = new List<int>();

        // Соответсвие между формой контроля и перечислением семестров
        public Dictionary<ControlForm, List<int>> ControlFormsBySemesters
                                    = new Dictionary<ControlForm, List<int>>() {
                                        { ControlForm.Credit, new List<int>() },
                                        { ControlForm.Exam, new List<int>() },
                                        { ControlForm.GradedCredit, new List<int>() },
                                    };

        public int TotalHoursByPlan = 0;
        public bool isCourseWork = false;






        public ModuleProperties() { }

        public ModuleProperties(string blockName, string partName, List<ControlForm> controlForm, string creditUnits, int blockNumber = -1)
        {
            BlockName = blockName;
            BlockNumber = blockNumber;
            PartName = partName;
            CreditUnits = creditUnits;
        }



        public override string ToString()
        {
            return $"Итого аудиторных занятий:{this.TotalLessonsHours}\n" +
                $"Итого лекций:{this.TotalLecturesHours}\n" +
                $"Итого практики:{this.TotalPracticalLessonsHours}\n" +
                $"Итого лаб:{this.TotalLaboratoryLessonsHours}\n" +
                $"Итого самост-ой работы:{this.TotalIndependentWorkHours}\n" +
                $"Итого Контрольных:{this.TotalControlHours}\n" +
                $"Курсы на которых предмет проводят:{Years.InLine()}\n" +
                $"Всего аудиторных занятий по семестрам:{TotalLessonsHoursBySemesters.InLine()}\n" +
                $"Лекции по семестрам:{LecturesHoursBySemesters.InLine()}\n" +
                $"Практики по семестрам:{PracticalLessonsHoursBySemesters.InLine()}\n" +
                $"Лабы по семестрам:{LaboratoryLessonsHoursBySemesters.InLine()}\n" +
                $"Самост. работа по семестрам:{IndependentWorkHoursBySemesters.InLine()}\n" +
                $"Контрольных по семестрам{ControlHoursBySemesters.InLine()}\n" +
                $"Семестры:{Semesters.InLine()}\n" +
                $"Всего часов по плану:{TotalHoursByPlan}\n" +
                $"Номер блока:{BlockNumber}\n" +
                $"Название блока:{BlockName}\n" +
                $"PartName:{PartName}\n" +
                $"CreditUnits:{CreditUnits}\n" +
                $"Название кафедры:{DepartmentName}\n" +
                $"Есть курсовая работа или нет:{isCourseWork}\n" +
                $"Код дисциплины:{ModuleCode}";
        }

        public string ControlFormToString(int SemesterNumber)
        {
            if (ControlFormsBySemesters[ControlForm.Exam].Contains(SemesterNumber))
            {
                return "Экзамен";
            }
            else if (ControlFormsBySemesters[ControlForm.Credit].Contains(SemesterNumber))
            {
                return "Зачет";
            }
            else if (ControlFormsBySemesters[ControlForm.GradedCredit].Contains(SemesterNumber))
            {
                return "Зачет с оц.";
            }
            else
            {
                return "Ошибка";
            }
        }
    }




    // Формы контроля: Экзамен, Зачет, Зачет с оценкой
    public enum ControlForm { Exam, Credit, GradedCredit, Error }
}
