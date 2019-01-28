using Module_Work.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Work
{
    class Profession_Creative : IProfession
    {
        /// <summary>
        /// Стаж работы в данной
        /// </summary>
        private int WorkExperience = 0;

        /// <summary>
        /// Стаж работы в военной области
        /// </summary>
        private string _professionName = Lang.Creative;

        /// <summary>
        /// Список всех профессий в данной области
        /// </summary>
        public List<Basic_Work> _list_Profession;

        public Profession_Creative()
        {
            _list_Profession = new List<Basic_Work>
            {
                new Basic_Work(Lang.Actor, 300, 0, 60, 0),
                new Basic_Work(Lang.Animator, 150, 0, 10, 0),
                new Basic_Work(Lang.Architect, 700, 85, 25, 0),
                new Basic_Work(Lang.BrandDesigner, 520,  55, 0 ,0),
                new Basic_Work(Lang.DJ, 100, 0, 5, 0),
                new Basic_Work(Lang.FashionDesigner, 190, 0, 15, 0),
                new Basic_Work(Lang.Conductor, 140, 0, 10, 0),
                new Basic_Work(Lang.SoundProducer, 170, 5, 10, 0),
                new Basic_Work(Lang.Illustrator, 300, 25, 0, 0),
                new Basic_Work(Lang.Stuntman, 600, 0, 10, 65),
                new Basic_Work(Lang.Projectionist, 130, 0, 0, 0),
                new Basic_Work(Lang.Cameraman, 510, 40, 20, 0),
                new Basic_Work(Lang.Critic, 100, 0, 0, 0),
                new Basic_Work(Lang.Designer, 120, 10, 10 , 0),
                new Basic_Work(Lang.Multiplier, 150, 0, 10, 0),
                new Basic_Work(Lang.Translator, 450, 60, 25, 0),
                new Basic_Work(Lang.Writer, 130, 10, 10, 0),
                new Basic_Work(Lang.Producer, 180, 15, 15, 0),
                new Basic_Work(Lang.Restorer, 300, 40, 30, 0),
                new Basic_Work(Lang.Stylist, 350, 0, 60, 0),
                new Basic_Work(Lang.Screenwriter, 250, 35, 25, 0),
                new Basic_Work(Lang.TattooArtist, 150, 0, 0, 0),
                new Basic_Work(Lang.Photographer, 150, 0, 0, 0),
                new Basic_Work(Lang.FashionModel, 150, 0, 15, 0),
                new Basic_Work(Lang.Jeweler, 340, 15, 35, 10),
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