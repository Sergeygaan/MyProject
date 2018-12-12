using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Basic_Work
    {
        /// <summary>
        /// Название профессии
        /// </summary>
        public string ProfessionName;

        /// <summary>
        /// Коэфицент профессии
        /// </summary>
        public float PayrollRatio;

        /// <summary>
        /// Требование к интеллекту
        /// </summary>
        public int IntelligenceRequirement;

        /// <summary>
        /// Рабочее время
        /// </summary>
        public int WorkingTime;

        public Basic_Work(string professionName, float payrollRatio, int intelligenceRequirement, int workingTime)
        {
            ProfessionName = professionName;
            PayrollRatio = payrollRatio;
            IntelligenceRequirement = intelligenceRequirement;
            WorkingTime = workingTime;
        }
    }
}
