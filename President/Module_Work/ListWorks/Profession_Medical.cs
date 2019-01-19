using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Medical : IProfession
    {
        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        public int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Medical;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        private List<Basic_Work> _list_Profession;

        public Profession_Medical()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Obstetrician, 310, 45, 0, 0),
                new Basic_Work(Lang.Doctor, 360, 35, 20, 0),
                new Basic_Work(Lang.Geneticist, 370, 40, 0, 0),
                new Basic_Work(Lang.Dermatologist, 320, 45, 0, 0),
                new Basic_Work(Lang.Nutritionist, 300, 35, 25, 0),
                new Basic_Work(Lang.Immunologist, 400, 45, 0, 0),
                new Basic_Work(Lang.Cardiologist, 320, 55, 0, 0),
                new Basic_Work(Lang.HeartSurgeon, 600, 60, 0, 10),
                new Basic_Work(Lang.Beautician, 600, 50, 45, 0),
                new Basic_Work(Lang.SpeechTherapist, 350, 30, 50, 0),
                new Basic_Work(Lang.Masseur, 360, 15, 0, 25),
                new Basic_Work(Lang.Neurologist, 300, 40, 0, 0),
                new Basic_Work(Lang.Ophthalmologist, 300, 35, 0, 0),
                new Basic_Work(Lang.Pediatrician, 360, 35, 30, 0),       
                new Basic_Work(Lang.Psychologist, 210, 20, 0, 0),
                new Basic_Work(Lang.Dentist, 350, 40, 0, 10),
                new Basic_Work(Lang.Therapist, 400, 45, 0, 0),
                new Basic_Work(Lang.Pharmacist, 200, 15, 0, 0),
                new Basic_Work(Lang.MedicalAssistant, 350, 25, 0, 35)
            };
        }

        public List<Basic_Work> ListProfession()
        {
            return _list_Profession;
        }

        public string ProfessionName()
        {
            return _professionName;
        }
    }
}