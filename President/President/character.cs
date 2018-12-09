using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    public class Character
    {
        #region Основные параметры

        /// <summary>
        /// Переменная, хранящая значение голода персонажа
        /// </summary>
        public int Food { get; set; } = 100;

        /// <summary>
        /// Переменная, хранящая значение настроения персонажа
        /// </summary>
        public int Mood { get; set; } = 100;

        /// <summary>
        /// Переменная, хранящая значение здоровья персонажа
        /// </summary>
        public int Health { get; set; } = 100;

        #endregion

        #region Вспомогательные параметры

        /// <summary>
        /// Переменная, хранящая значение физического развития персонажа
        /// </summary>
        public int PhysicalDevelopment { get; set; } = 100;

        /// <summary>
        /// Переменная, хранящая значение харизмы персонажа
        /// </summary>
        public int Charisma { get; set; } = 100;

        /// <summary>
        /// Переменная, хранящая значение интеллекта персонажа
        /// </summary>
        public int Intelligence { get; set; } = 100;

        #endregion
    }
}
