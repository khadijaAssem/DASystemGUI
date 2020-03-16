using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Commands
{
    class TimerTickCMD
    {
        private static int seconds = 0;
        private static int minutes = 0;
        private static int hours = 0;

        public static string tick()
        {
            try
            {
                seconds++;
                if (seconds > 60)
                {
                    minutes++;
                    seconds = 0;
                    if (minutes > 60)
                    {
                        hours++;
                        minutes = 0;
                    }
                }
                string Hours = hours.ToString();
                string Minutes = minutes.ToString();
                string Seconds = seconds.ToString();
                if (hours < 10)
                    Hours = "0" + hours.ToString();
                if (minutes < 10)
                    Minutes = "0" + minutes.ToString();
                if (seconds < 10)
                    Seconds = "0" + seconds.ToString();
                return Hours + " : " + Minutes + " : " + Seconds;
            }
            catch(Exception E)
            {
                throw E;
            }
        }
    }
}
