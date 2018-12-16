using Module_Character;
using Module_GameTime;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ThePresident
{
    class GameTimer : IDisposable
    {
        private Thread _thread;
        private int _timerSleep = 2500;
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
