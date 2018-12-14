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
        public int Salary;

        /// <summary>
        /// План на пол года
        /// </summary>
        public int Plan;

        /// <summary>
        /// Текущее выполнение плана
        /// </summary>
        public int WorkPlan;

        /// <summary>
        /// Рабочее время
        /// </summary>
        public int WorkingTime;

        /// <summary>
        /// Начало рабочего дня
        /// </summary>
        public int StartWorkingTime;

        /// <summary>
        /// Требования
        /// </summary>
        public int IntelligenceRequirement;

        public FinalJob(string professionName, int salary, int plan, int workingTime, int startWorkingTime, int intelligenceRequirement)
        {
            ProfessionName = professionName;
            Salary = salary;
            Plan = plan;

            WorkingTime = workingTime;
            StartWorkingTime = startWorkingTime;

            IntelligenceRequirement = intelligenceRequirement;
        }
    }
}
