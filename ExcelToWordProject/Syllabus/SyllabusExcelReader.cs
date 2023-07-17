using EduPlans.Db;
using EduPlans.Db.Models;
using EduPlans.Db.Models.Binding;
using EduPlans.Db.Сontexts.Blinding;
using EduPlans.Db.Сontexts.Reference;
using ExcelDataReader;
using ExcelToWordProject.Models;
using ExcelToWordProject.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace ExcelToWordProject.Syllabus
{
    class SyllabusExcelReader : IDisposable
    {
        /// <summary>
        /// Является ли данный файл файлом расписания.
        /// </summary>
        public bool IsSyllabusFile
        {
            get
            {
                try
                {
                    string flagValue = ExcelData.Tables[0].Rows[11][8] as string ?? "";
                    string flagValue2 = ExcelData.Tables[0].Rows[22][11] as string ?? "";
                    return flagValue.ToLower().Contains("учебный план") || flagValue2.ToLower().Contains("учебный план");
                }
                catch
                {
                    return false;
                }
            }
        }

        public string FilePath { get; }
        public DataSet ExcelData; // ExcelData.Tables["Name"].Rows[11][0] - пример

        public TitlePlan Title;

        SyllabusParameters Parameters;


        IExcelDataReader excelStream;
        FileStream fileStream;

        public SyllabusExcelReader(string filePath, SyllabusParameters parameters)
        {
            FilePath = filePath;
            Parameters = parameters;
            OpenStreams();

        }

        public void ParseSubjects()
        {
            var suyl = new SyllabusParameters(true);
            ConfigManager.SaveConfigData(suyl);

            SmartSyllabusTag moduleNameTag =
              Parameters.Tags.Find(
                  tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.ModuleName) as SmartSyllabusTag;

            ExcelTableList list = new ExcelTableList(Parameters.PlanListName, ExcelData, Parameters.PlanListHeaderRowIndex);

            using (SubjectContext sc = new SubjectContext())
            {
                for (int i = Parameters.PlanListHeaderRowIndex + 1; i < list.RowsCount; i++)
                {
                    string subjectTitle = list.GetCellValue(i, moduleNameTag.ColumnIndex);
                    sc.Add(subjectTitle);
                }
                sc.SaveChanges();
                Console.WriteLine("Ураааааааааааа все предметы спарсил");
            }
        }

        public void ParseCompetencies()
        {

            ExcelTableList list = new ExcelTableList(Parameters.ModulesContentListName, ExcelData, Parameters.PlanListHeaderRowIndex);


            SmartSyllabusTag contentIndexTag =
               Parameters.Tags.Find(
                   tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.ContentIndex) as SmartSyllabusTag;

            SmartSyllabusTag contentDescriptionTag =
                Parameters.Tags.Find(
                    tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.Content) as SmartSyllabusTag;



            List<Competence> contentList = new List<Competence>();

            var rows = ExcelData.Tables[contentDescriptionTag.ListName].Rows;
            using (CompetenceContext cc = new CompetenceContext())
            {

                for (int i = 2; i < rows.Count; i++)
                {
                    var s = list.GetCellValue(i, contentDescriptionTag.ColumnIndex + 1);
                    if (s.Trim() != "")
                    {
                        string index = list.GetCellValue(i, contentIndexTag.ColumnIndex);
                        string description = list.GetCellValue(i, contentDescriptionTag.ColumnIndex);
                        cc.Add(new Competence(index, description));
                    }
                }

                cc.SaveChanges();
            }

        }

        public void ParseDepartments()
        {
            

            var tag = Parameters.Tags.Find(
                    tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.DepartmentNameNotInPlan) as SmartSyllabusTag;


            var list = new ExcelTableList(tag.ListName, ExcelData);

            var rows = ExcelData.Tables[tag.ListName].Rows;

            using (DepartmentContext dc = new DepartmentContext())
            {
                for (int i = 2; i < rows.Count; i++)
                {
                    string departmentTitle = list.GetCellValue(i, tag.ColumnIndex);
                    Depatment department = new Depatment(departmentTitle);
                    dc.Add(department);
                    Console.WriteLine($"{department.Title} {department.HeadId} {department.FacultyId}");
                }

                dc.SaveChanges();
            }
            

        }

        public void ParseTitle()
        {

            var directionCodeTag = Parameters.Tags.Find(tag => tag.Key == "DirectionCode") as DefaultSyllabusTag;
            var programValueTag = Parameters.Tags.Find(tag => tag.Key == "ProgramValue") as DefaultSyllabusTag;
            var protocolInfoDateTag = Parameters.Tags.Find(tag => tag.Key == "ProtocolInfoDate") as DefaultSyllabusTag;
            var protocolInfoNumberTag = Parameters.Tags.Find(tag => tag.Key == "ProtocolInfoNumber") as DefaultSyllabusTag;
            var dateEnterTag = Parameters.Tags.Find(tag => tag.Key == "DateEnter") as DefaultSyllabusTag;
            var educationalStandardDateTag = Parameters.Tags.Find(tag => tag.Key == "EducationalStandardDate") as DefaultSyllabusTag;
            var educationalStandardNumberTag = Parameters.Tags.Find(tag => tag.Key == "EducationalStandardNumber") as DefaultSyllabusTag;
            var departmentFromTitleTag = Parameters.Tags.Find(tag => tag.Key == "DepartmentFromTitle") as DefaultSyllabusTag;


            var directionCode = directionCodeTag.GetValue(null, null, ExcelData);
            var programValue = programValueTag.GetValue(null, null, ExcelData);
            //var protocolInfoDate = DateTime.Parse(protocolInfoDateTag.GetValue(null, null, ExcelData));
            var protocolInfoDate = new DateTime(2003,1,26);
            //var protocolInfoNumber = int.Parse(protocolInfoNumberTag.GetValue(null, null, ExcelData));
            var protocolInfoNumber = 0;
            var educationalStandardDate = DateTime.Parse(educationalStandardDateTag.GetValue(null, null, ExcelData));
            var educationalStandardNumber = int.Parse(educationalStandardNumberTag.GetValue(null, null, ExcelData));
            var dateEnter = int.Parse(dateEnterTag.GetValue(null, null, ExcelData));
            var departmentFromTitle = departmentFromTitleTag.GetValue(null, null, ExcelData);
            var title = new TitlePlan(directionCode, programValue, protocolInfoDate, protocolInfoNumber, dateEnter, educationalStandardDate, educationalStandardNumber, departmentFromTitle, "1");
            using (TitlePlanContext tpc = new TitlePlanContext())
            {
                tpc.Add(title);
                tpc.SaveChanges();
            }
            Title = title;
        }


        public void ParseEduPlan()
        {

            var modules = GetAllModules();
            var eduPlans = new List<EduPlan>();
            using (EduPlanContext epc = new EduPlanContext())
            {

                foreach (var module in modules)
                {
                    //Console.WriteLine($"{module.Name}\n" +
                    //    $"{module.Properties.ModuleCode}\n" +
                    //    $"{module.Properties.BlockName} and {module.Properties.PartName}\n" +
                    //    $"{module.Properties.DepartmentName}\n" +
                    //    $"Title plan:{0}\n");

                    EduPlan eduPlan = new EduPlan(module.Properties.BlockName, module.Properties.PartName, module.Name, module.Properties.ModuleCode, module.Properties.DepartmentName, Title.Id);
                    epc.Add(eduPlan);
                    epc.SaveChanges();
                    using (EduPlanCompetenciesContext epcc = new EduPlanCompetenciesContext())
                    {
                        foreach (var competenceCode in module.ContentIndexes)
                        {
                            epcc.Add(new EduPlanCompetencies(competenceCode, eduPlan.Id));
                        }
                        epcc.SaveChanges();
                    }
                    using (EduSemesterContext esc = new EduSemesterContext())
                    {
                        for (int i = 0; i < module.Properties.Semesters.Count; i++)
                        {
                            var lectures = module.Properties.LecturesHoursBySemesters[i];
                            var practice = module.Properties.PracticalLessonsHoursBySemesters[i];
                            var labs = module.Properties.LaboratoryLessonsHoursBySemesters[i];
                            var ind = module.Properties.IndependentWorkHoursBySemesters[i];
                            //Console.WriteLine($"{module.Name}\nСеместер:{i+1}\nЛекции:{lectures}\nПрактики:{practice}\nЛабы:{labs}\nИнд работа:{ind}\n");

                            EduSemester es = new EduSemester(eduPlan.Id, i + 1, 0.0, lectures, practice, labs, ind);

                            esc.Add(es);
                        }
                        esc.SaveChanges();
                    }
                }


            }



        }
        public void CloseStreams()
        {
            if (excelStream != null)
                excelStream.Close();
            if (fileStream != null)
                fileStream.Close();
            ExcelData = null;
        }

        public void OpenStreams()
        {
            fileStream = File.Open(FilePath, FileMode.Open, FileAccess.Read);
            excelStream = ExcelReaderFactory.CreateReader(fileStream);
            ExcelData = excelStream.AsDataSet();
        }

        public void Dispose()
        {
            CloseStreams();
        }

        /// <summary>
        /// Парсинг всех дисциплин в Excel файле, а затем фильтрация их по переданным курсам.
        /// </summary>
        /// <param name="years">курсы, за которые необходимо получить модули</param>
        /// <returns></returns>
        public List<Module> GetAllModules(int[] years)
        {
            List<Module> allModules = GetAllModules();
            if (years.Length == 0)
                return allModules;

            List<Module> result = allModules.FindAll(module =>
            {
                bool contains = false;
                foreach (int year in module.Properties.Years)
                {
                    contains = years.Contains(year);
                    if (contains)
                        return contains;
                }

                return contains;
            });

            return result ?? new List<Module>();
        }

        /// <summary>
        /// Парсинг всех дисциплин в Excel файле
        /// </summary>
        /// <returns>Список дисциплин</returns>
        public List<Module> GetAllModules()
        {
            // Получим все необходимые теги
            SmartSyllabusTag moduleNameTag =
                Parameters.Tags.Find(
                    tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.ModuleName) as SmartSyllabusTag;

            SmartSyllabusTag moduleIndexTag =
                Parameters.Tags.Find(
                    tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.ModuleIndex) as SmartSyllabusTag;
            //нот юз
            SmartSyllabusTag moduleContentIndexesTag =
                Parameters.Tags.Find(
                    tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.ModuleContentIndexes) as SmartSyllabusTag;

            // Список модулей
            List<Module> modules = new List<Module>();

            // Поиск
            ExcelTableList list = new ExcelTableList(Parameters.PlanListName, ExcelData, Parameters.PlanListHeaderRowIndex);

            for (int i = Parameters.PlanListHeaderRowIndex + 1; i < list.RowsCount; i++)
            {
                // Имя модуля
                string moduleName = list.GetCellValue(i, moduleNameTag.ColumnIndex);

                if (moduleName.Trim() == "") // если пусто, то пропускаем
                    continue;

                // Индекс модуля 
                string moduleIndex = list.GetCellValue(i, moduleIndexTag.ColumnIndex);


                // Строка, содержащая индексы компетенций
                string contentIndexesStr = list.GetFirstCellValue(i, Parameters.planListHeaderNames["Competitions"]);

                // Добавим модуль
                modules.Add(new Module(moduleIndex, moduleName, contentIndexesStr));

                // и получим его свойства
                modules.Last().Properties = ParseModuleProperties(modules.Last());
            }

            return modules;
        }

        /// <summary>
        /// Парсинг свойств модуля
        /// </summary>
        /// <param name="module">Модуль</param>
        /// <returns></returns>
        public ModuleProperties ParseModuleProperties(Module module)
        {
            ModuleProperties properties = new ModuleProperties(); // Результирующая переменная

            // Для начала найдем Index модуля на листе "План"
            // По дороге захватим имя блока и части
            // При этом номер части может быть не всегда (см. ФТД.Факультативы)
            // Поиск начнется с 3 индекса для скипа хедеров

            // Код работает на вере, что в 0 столбце будут либо плюсики с минусиками, либо имена блоков, либо null

            int rowIndex = 0;

            SmartSyllabusTag blockNameTag =
                Parameters.Tags.Find(
                    tag => tag is SmartSyllabusTag && (tag as SmartSyllabusTag).Type == SmartTagType.BlockName) as SmartSyllabusTag;
            SmartSyllabusTag partNameTag =
                Parameters.Tags.Find(
                    tag => tag is SmartSyllabusTag && (tag as SmartSyllabusTag).Type == SmartTagType.PartName) as SmartSyllabusTag;
            var rows = ExcelData.Tables[blockNameTag.ListName].Rows;

            // Маркеры, которые могут быть в 0 столбце
            string[] moduleMarkers = { "+", "-" };
            string[] skipMarkers = { null, "" };

            ExcelTableList planList = new ExcelTableList(Parameters.PlanListName, ExcelData, Parameters.PlanListHeaderRowIndex);

            // Поиск строки с дисциплиной и парсинг имени блока и части
            for (rowIndex = Parameters.PlanListHeaderRowIndex + 1; rowIndex < rows.Count; rowIndex++)
            {
                string val = rows[rowIndex][0] as string;
                if (moduleMarkers.Contains(val)) // Если строка содержит модуль
                {
                    if (rows[rowIndex][1] as string == module.Index) // если это наш модуль, то останавливаем процесс
                        break;
                }
                else
                {
                    // Содержит ли данная строка имя части
                    string maybePart = rows[rowIndex][partNameTag.ColumnIndex] as string ?? "";
                    if (!skipMarkers.Contains(maybePart.Trim()))
                    {
                        if (maybePart.ToLower().Contains("часть"))
                        {
                            properties.PartName = maybePart.Trim();
                        }
                        else
                        {
                            // Содержит ли данная строка имя блока
                            string maybeBlock = rows[rowIndex][blockNameTag.ColumnIndex] as string ?? "";
                            if (!skipMarkers.Contains(maybeBlock.Trim()))
                            {
                                properties.PartName = "";
                                properties.BlockName = maybeBlock.Trim();
                            }
                        }
                    }
                }
            }

            // если мы не нашли нужную строку
            if (rowIndex == rows.Count)
                return new ModuleProperties("error", "error", new List<ControlForm>(), "-1");

            // Тянем доп данные

            // Номер блока
            string temp = Regex.Replace(properties.BlockName, @"[^\d]+", "");
            properties.BlockNumber = (temp != "") ? Convert.ToInt32(temp) : -1;

            // Формы контроля по семестрам
            SmartSyllabusTag controlTag =
                Parameters.Tags.Find(
                    tag => tag is SmartSyllabusTag && (tag as SmartSyllabusTag).Type == SmartTagType.Control) as SmartSyllabusTag;
            Array enumValues = Enum.GetValues(typeof(ControlForm));
            for (int i = 0; i < enumValues.Length - 1; i++)
            {
                ControlForm controlForm = (ControlForm)enumValues.GetValue(i);
                string val = (rows[rowIndex][controlTag.ColumnIndex + i] as string) ?? "";
                properties.ControlFormsBySemesters[controlForm] = new List<int>();
                if (val != "")
                    properties.ControlFormsBySemesters[controlForm].AddRange(OtherUtils.StrToListInt(val).Distinct().ToList());
            }

            // Будет ли курсовая работа
            SmartSyllabusTag courseWorkTag =
                Parameters.Tags.Find(
                    tag => tag is SmartSyllabusTag && (tag as SmartSyllabusTag).Type == SmartTagType.isCourseWork) as SmartSyllabusTag;
            properties.isCourseWork = ((rows[rowIndex][courseWorkTag.ColumnIndex] as string) ?? "") != "";


            // Зачетные единицы
            SmartSyllabusTag сreditUnitsTag =
                Parameters.Tags.Find(
                    tag => tag is SmartSyllabusTag && (tag as SmartSyllabusTag).Type == SmartTagType.CreditUnits) as SmartSyllabusTag;
            properties.CreditUnits = "-1";
            if (rows[rowIndex][сreditUnitsTag.ColumnIndex] as string != "")
            {
                properties.CreditUnits = rows[rowIndex][сreditUnitsTag.ColumnIndex] as string ?? "-1";
            }


            // Количество часов на лекции (по семестрам)
            List<string> tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["LecturesHoursHeaderName"]);
            properties.LecturesHoursBySemesters = tempList.ConvertAll(el => OtherUtils.StrToInt(el));

            // Количество часов на лабораторки (по семестрам)
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["LaboratoryLessonsHoursHeaderName"]);
            properties.LaboratoryLessonsHoursBySemesters = tempList.ConvertAll(el => OtherUtils.StrToInt(el));

            // Количество часов на практики (по семестрам)
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["PracticalLessonsHoursHeaderName"]);
            properties.PracticalLessonsHoursBySemesters = tempList.ConvertAll(el => OtherUtils.StrToInt(el));

            // Количество часов на контроль (по семестрам)
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["ControlHoursHeaderName"]);
            properties.ControlHoursBySemesters = tempList.ConvertAll(el => OtherUtils.StrToInt(el));
            properties.ControlHoursBySemesters =
                properties.ControlHoursBySemesters.GetRange(1, properties.ControlHoursBySemesters.Count() - 1);

            // Количество часов на самостоятельную работу (по семестрам)
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["IndependentWorkHoursHeaderName"]);
            properties.IndependentWorkHoursBySemesters = tempList.ConvertAll(el => OtherUtils.StrToInt(el));
            properties.IndependentWorkHoursBySemesters =
                properties.IndependentWorkHoursBySemesters.GetRange(1, properties.IndependentWorkHoursBySemesters.Count() - 1);

            // Общее количество часов по плану
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["TotalHoursByPlanHeaderName"], true);
            properties.TotalHoursByPlan = tempList.Sum(el => OtherUtils.StrToInt(el));

            // Список семестров (тут придется плясать с бубном)
            // идея в том, что мы ищем все зачетные единицы по данном предмету
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["SemesterCountingCreditUnitsPlanHeaderName"], false);
            for (int i = 0; i < tempList.Count; i++)
                if (tempList[i] != null)
                    properties.Semesters.Add(i + 1);

            // Имя кафедры
            // последний столбец с хедером Наименование
            // первый столбец - имя дисциплины
            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["DepartmentName"], false);
            if (tempList.Count >= 2)
                properties.DepartmentName = tempList[tempList.Count - 1] ?? "";

            tempList = planList.GetCellValue(rowIndex, Parameters.planListHeaderNames["ModuleCode"], false);
            if (tempList.Count >= 1)
                properties.ModuleCode = tempList[tempList.Count - 1] ?? "";


            return properties;
        }

        /// <summary>
        /// Парсинг компетенций
        /// </summary>
        /// <param name="module"></param>
        /// <returns></returns>
        public List<Content> ParseContentList(Module module)
        {
            SmartSyllabusTag tag =
                Parameters.Tags.Find(
                    tag_ => tag_ is SmartSyllabusTag && (tag_ as SmartSyllabusTag).Type == SmartTagType.Content) as SmartSyllabusTag;

            List<Content> contentList = new List<Content>();

            var rows = ExcelData.Tables[tag.ListName].Rows;

            for (int i = 2; i < rows.Count; i++)
            {

                // Если справа мы встретили не пустой столбец "Тип"
                if ((rows[i][tag.ColumnIndex + 1] as string ?? "").Trim() != "")
                    foreach (string contentIndex in module.ContentIndexes) // Проверяем все индексы
                    {
                        if ((rows[i][tag.ColumnIndex - 2] as string) == contentIndex) //на совпадение
                        {
                            contentList.Add(new Content(contentIndex, rows[i][tag.ColumnIndex] as string));
                            break;
                        }
                    }
            }

            return contentList;
        }
    }

}
