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
                new Basic_Work(Lang.Obstetrician, 100, 0, 0, 0),
                new Basic_Work(Lang.Doctor, 100, 0, 0, 0),
                new Basic_Work(Lang.Geneticist, 100, 0, 0, 0),
                new Basic_Work(Lang.Dermatologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Nutritionist, 100, 0, 0, 0),
                new Basic_Work(Lang.Immunologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Cardiologist, 100, 0, 0, 0),
                new Basic_Work(Lang.HeartSurgeon, 100, 0, 0, 0),
                new Basic_Work(Lang.Beautician, 100, 0, 0, 0),
                new Basic_Work(Lang.SpeechTherapist, 100, 0, 0, 0),
                new Basic_Work(Lang.Masseur, 100, 0, 0, 0),
                new Basic_Work(Lang.Neurologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Ophthalmologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Pediatrician,100, 0, 0, 0),       
                new Basic_Work(Lang.Psychologist, 100, 0, 0, 0),
                new Basic_Work(Lang.Dentist, 100, 0, 0, 0),
                new Basic_Work(Lang.Therapist, 100, 0, 0, 0),
                new Basic_Work(Lang.Pharmacist, 100, 0, 0, 0),
                new Basic_Work(Lang.MedicalAssistant,100, 0, 0, 0),
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