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
        /// Индекс категории
        /// </summary>
        public int IndexCategory = -1;

        /// <summary>
        /// Название индустрии
        /// </summary>
        public string IndustryName;

        /// <summary>
        /// Название профессии
        /// </summary>
        public string ProfessionName;

        /// <summary>
        /// Начальный базовый оклад
        /// </summary>
        public int Salary_Start;

        /// <summary>
        /// Финальный оклад
        /// </summary>
        public int Salary_End;

        /// <summary>
        /// Повышение квалификации
        /// </summary>
        public int Salary_Coefficient;

        /// <summary>
        /// Востребованность
        /// </summary>
        public int Salary_Demand;

        /// <summary>
        /// План на пол года
        /// </summary>
        public int Plan;

        /// <summary>
        /// Текущее выполнение плана
        /// </summary>
        public int WorkPlan;

        /// <summary>
        /// Требование к интеллекту
        /// </summary>
        public int Req_Intelligence;

        /// <summary>
        /// Требование к обаянию
        /// </summary>
        public int Req_Charm;

        /// <summary>
        /// Требование к физической силе
        /// </summary>
        public int Req_PhysicalDevelopment;

        /// <summary>
        /// ВЫпавшая работа
        /// </summary>
        /// <param name="professionName">Название работы</param>
        /// <param name="salary">Оклад</param>
        /// <param name="CoefficientSalary">Добавочная часть к окладу</param>
        /// <param name="plan">План</param>
        /// <param name="workingTime">Рабочий день</param>
        /// <param name="startWorkingTime">Начало работы</param>
        /// <param name="req_Intelligence">Требованиия к интеллекту</param>
        /// <param name="req_Charm">Требованиия к обаянию</param>
        /// <param name="req_PhysicalDevelopment">Требованиия к физической силе</param>
        public FinalJob(int indexCategory,string industryName, string professionName, int salaryStart, int coefficientSalary, int demandSalary, int salaryEnd, int plan, int req_Intelligence, int req_Charm, int req_PhysicalDevelopment)
        {
            IndexCategory = indexCategory;
            IndustryName = industryName;
            ProfessionName = professionName;

            Salary_Start = salaryStart;
            Salary_End = salaryEnd;
            Salary_Coefficient = coefficientSalary;
            Salary_Demand = demandSalary;

            Plan = plan;

            //Требования
            Req_Intelligence = req_Intelligence;
            Req_Charm = req_Charm;
            Req_PhysicalDevelopment = req_PhysicalDevelopment;
        }
    }
}
