﻿using Module_Character;
using Module_Event;
using Module_GameTime;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ThePresident
{
    class GameTimer : IDisposable
    {
        public static int TimePassedGameSecond = 0; 

        private Thread _thread;
        private int _timerSleep = 100;
        private Random random = new Random();

        /// <summary>
        /// Уменьшение параметров
        /// </summary>
        private int _reductionParameters = 0;

        public GameTimer()
        {
            _thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        GameTime.AddTime(60);

                        if (_reductionParameters >= 5)
                        {
                            int maxNeeds = 2 + GameCharacter.NeedsStudy + GameCharacter.NeedsWork;

                            int randomFood = random.Next(1, maxNeeds);
                            int randomMood = random.Next(1, maxNeeds);
                            int randomHealth = random.Next(1, maxNeeds);

                            GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);

                            _reductionParameters = 0;
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }

                    _reductionParameters += 1;

                    TimePassedGameSecond += _timerSleep;

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
    }
}
