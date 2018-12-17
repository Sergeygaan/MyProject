using Module_Character;
using Module_GameTime;
using System;
using System.Threading;

namespace ThePresident
{
    class GameTimer : IDisposable
    {
        public static int TimePassedGameSecond = 0; 

        private Thread _thread;
        private int _timerSleep = 1000;
        private Random random = new Random();

        public GameTimer()
        {
            _thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        GameTime.AddTime(1);

                        int randomFood = random.Next(0, 2);
                        int randomMood = random.Next(0, 2);
                        int randomHealth = random.Next(0, 2);

                        GameCharacter.ReducingNeeds(randomFood, randomMood, randomHealth);
                    }
                    catch (Exception error)
                    {
                        //MessageBox.Show(error.Message);
                    }

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
