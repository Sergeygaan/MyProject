using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    public class FinalJob
    {       
        /// <summary>
        /// Название профессии
        /// </summary>
        public string ProfessionName;

        /// <summary>
        /// Зарплата
        /// </summary>
        public float Salary;

        /// <summary>
        /// Требование к плану работы
        /// </summary>
        public int PlanWork;

        /// <summary>
        /// Рабочее время
        /// </summary>
        public int WorkingTime;

        /// <summary>
        /// Требования
        /// </summary>
        public int IntelligenceRequirement;

        public FinalJob(string professionName, float salary, int planWork, int workingTime, int intelligenceRequirement)
        {
            ProfessionName = professionName;
            Salary = salary;
            PlanWork = planWork;
            WorkingTime = workingTime;
            IntelligenceRequirement = intelligenceRequirement;
        }
    }
}
