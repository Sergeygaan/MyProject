using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Training
{
    public class CurrentStudy
    {
        /// <summary>
        /// Период обучения
        /// </summary>
        public int PeriodStudy;

        /// <summary>
        /// Название образования
        /// </summary>
        public string NameStudy;

        /// <summary>
        /// Ограничение интеллекта данного образования
        /// </summary>
        public int RestrictionsIntellect;

        /// <summary>
        /// Необходимый план
        /// </summary>
        public int Plan;

        /// <summary>
        /// Текущее выполнение плана
        /// </summary>
        public int StudyPlan;

        /// <summary>
        /// Текущее образование
        /// </summary>
        /// <param name="nameStudy">Период обучения</param>
        /// <param name="periodStudy">Название образования</param>
        /// <param name="restrictionsIntellect">Ограничение интеллекта данного образования</param>
        public CurrentStudy(string nameStudy, int periodStudy, int restrictionsIntellect, int plan)
        {
            NameStudy = nameStudy;

            PeriodStudy = periodStudy;
            Plan = plan;
            RestrictionsIntellect = restrictionsIntellect;
        }
    }
}
