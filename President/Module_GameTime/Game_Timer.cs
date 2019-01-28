using Module_Character;
using Module_GameTime;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ThePresident
{
    public class Game_Timer : IDisposable
    {
        public static int TimePassedGameSecond = 0; 

        private Thread _thread;
        private int _timerSleep = 1000;
        private Random random = new Random();

        /// <summary>
        /// Уменьшение параметров
        /// </summary>
        private int _reductionParameters = 0;

        private int _need = 20;

        public Game_Timer()
        {
            _thread = new Thread(() =>
            {
                while (true)
                {
                    //try
                    //{
                        Game_Time.AddTime(60);

                        if (_reductionParameters >= 3)
                        {
                            int maxNeeds = _need + GameCharacter.NeedsStudy + GameCharacter.NeedsWork;

                            int randomFood = random.Next(1, maxNeeds);
                            int randomMood = random.Next(1, maxNeeds);
                            int randomHealth = random.Next(1, maxNeeds);

                            GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);

                            _reductionParameters = 0;
                        }

                        Decrease_Intelligence();
                        Decrease_Charm();
                        Decrease_PhysicalDevelopment();
                    //}
                    //catch (Exception error)
                    //{
                    //    MessageBox.Show(error.Message);
                    //}

                    _reductionParameters += 1;

                    TimePassedGameSecond += 1;

                    Thread.Sleep(_timerSleep);
                }
            });
            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Dispose()
        {
            _thread.Abort();
            _thread = null;
        }

        
        private int _step_Intelligence = 0;
        private int _restrictions_Intelligence = 5;

        /// <summary>
        /// Понижение интеллекта со временем
        /// </summary>
        private void Decrease_Intelligence()
        {
            _step_Intelligence += 1;

            if(_step_Intelligence >= _restrictions_Intelligence)
            {
                _restrictions_Intelligence = random.Next(10, 30);

                _step_Intelligence = 0;

                GameCharacter.Set("Intelligence", -1);
            }
        }

        private int _step_Charm = 0;
        private int _restrictions_Charm = 5;

        /// <summary>
        /// Понижение обаяния со временем
        /// </summary>
        private void Decrease_Charm()
        {
            _step_Charm += 1;

            if (_step_Charm >= _restrictions_Charm)
            {
                _restrictions_Charm = random.Next(10, 30);

                _step_Charm = 0;

                GameCharacter.Set("Charm", -1);
            }
        }

        private int _step_PhysicalDevelopment = 0;
        private int _restrictions_PhysicalDevelopment = 5;

        /// <summary>
        /// Понижение физической силы со временем
        /// </summary>
        private void Decrease_PhysicalDevelopment()
        {
            _step_PhysicalDevelopment += 1;

            if (_step_PhysicalDevelopment >= _restrictions_PhysicalDevelopment)
            {
                _restrictions_PhysicalDevelopment = random.Next(10, 30);

                _step_PhysicalDevelopment = 0;

                GameCharacter.Set("PhysicalDevelopment", -1);
            }
        }
    }
}
