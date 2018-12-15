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
        /// <param name="plan">План</param>
        /// <param name="workingTime">Рабочий день</param>
        /// <param name="startWorkingTime">Начало работы</param>
        /// <param name="req_Intelligence">Требованиия к интеллекту</param>
        /// <param name="req_Charm">Требованиия к обаянию</param>
        /// <param name="req_PhysicalDevelopment">Требованиия к физической силе</param>
        public FinalJob(string professionName, int salary, int plan, int workingTime, int startWorkingTime, int req_Intelligence, int req_Charm, int req_PhysicalDevelopment)
        {
            ProfessionName = professionName;
            Salary = salary;
            Plan = plan;

            WorkingTime = workingTime;
            StartWorkingTime = startWorkingTime;

            //Требования
            Req_Intelligence = req_Intelligence;
            Req_Charm = req_Charm;
            Req_PhysicalDevelopment = req_PhysicalDevelopment;
        }
    }
}
