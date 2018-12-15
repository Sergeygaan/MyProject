using System;
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
        /// Рабочее время
        /// </summary>
        public int WorkingTime;

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
        /// Класс, хранящий в себе параметры профессий
        /// </summary>
        /// <param name="professionName">Название профессии</param>
        /// <param name="salary">Зарплата</param>
        /// <param name="workingTime">Рабочее время</param>
        /// <param name="req_Intelligence">Требования к интеллекту</param>
        /// <param name="req_Charm">Требования к  обаянию</param>
        /// <param name="req_PhysicalDevelopment">Требования к физической силе</param>
        public Basic_Work(string professionName, int salary, int workingTime, int req_Intelligence, int req_Charm, int req_PhysicalDevelopment)
        {
            ProfessionName = professionName;
            Salary = salary;
            WorkingTime = workingTime;

            //Требования
            Req_Intelligence = req_Intelligence;
            Req_Charm = req_Charm;
            Req_PhysicalDevelopment = req_PhysicalDevelopment;
        }
    }
}
