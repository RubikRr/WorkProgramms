﻿using EduPlans.Db.Сontexts.Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduPlans.Db.Models.Binding
{
    [Table("edu_plan_competencies")]
    public class EduPlanCompetencies
    {
        public int Id { get; set; }
        [Column("competency_id")]
        public int CompetencyId { get; set; }

        [Column("edu_plan_id")]
        public int EduPlanId { get; set; }

        public EduPlanCompetencies(string competencyCode, int eduPlanId)
        {
            using (CompetenceContext cc = new CompetenceContext())
            {
                CompetencyId = cc.GetCompetenceId(competencyCode);
            }
            EduPlanId = eduPlanId;
        }
        public EduPlanCompetencies() { }
    }
}
