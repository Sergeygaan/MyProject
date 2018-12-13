﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    public class Basic_Work
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
        /// Требование к интеллекту
        /// </summary>
        public int IntelligenceRequirement;

        /// <summary>
        /// Рабочее время
        /// </summary>
        public int WorkingTime;

        public Basic_Work(string professionName, int salary, int intelligenceRequirement, int workingTime)
        {
            ProfessionName = professionName;
            Salary = salary;
            IntelligenceRequirement = intelligenceRequirement;
            WorkingTime = workingTime;
        }
    }
}
