using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_Statistics
{
    public class Main_Statistics
    {     
        /// <summary>
        /// Текст отображаемый в статистике
        /// </summary>
        public string Text;

        /// <summary>
        /// Значение параметра
        /// </summary>
        public int Value;

        public Main_Statistics(string text, int value)
        {
            Text = text;
            Value = value;
        }
    }
}
