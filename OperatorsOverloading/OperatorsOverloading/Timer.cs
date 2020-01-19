using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    public class Timer
    {

        private int minutes;
        private int seconds;
        private int miliseconds;

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value >= 0)
                {
                    minutes = value;
                }
                else
                {
                    throw new Exception("value cannot be negative!");
                }
            }
        }
        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value >= 0)
                {
                    seconds = value;
                }
                else
                {
                    throw new Exception("value cannot be negative!");
                }
            }
        }
        public int Miliseconds
        {
            get
            {
                return miliseconds;
            }
            set
            {
                if (value >= 0)
                {
                    miliseconds = value;
                }
                else
                {
                    throw new Exception("value cannot be negative!");
                }
            }
        }

        public Timer(int Minutes, int Seconds, int Miliseconds)
        {
            this.Minutes = Minutes;
            this.Seconds = Seconds;
            this.Miliseconds = Miliseconds;

        }
        public int ConvertToSeconds()
        {
            int result = minutes * 60 + seconds + miliseconds / 1000;
            return result;
        }
        public int ConvertToMiliSeconds()
        {
            int result = minutes * 6000 + seconds * 1000 + miliseconds;
            return result;
        }
        public static bool operator >(Timer timer1, Timer timer2)
        {
            long timer1Miliseconds = timer1.ConvertToMiliSeconds();
            long timer2Miliseconds = timer2.ConvertToMiliSeconds();
            if (timer1Miliseconds > timer2Miliseconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <(Timer timer1, Timer timer2)
        {
            long timer1Miliseconds = timer1.ConvertToMiliSeconds();
            long timer2Miliseconds = timer2.ConvertToMiliSeconds();
            if (timer1Miliseconds < timer2Miliseconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >=(Timer timer1, Timer timer2)
        {
            long timer1Miliseconds = timer1.ConvertToMiliSeconds();
            long timer2Miliseconds = timer2.ConvertToMiliSeconds();
            if (timer1Miliseconds >= timer2Miliseconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <=(Timer timer1, Timer timer2)
        {
            long timer1Miliseconds = timer1.ConvertToMiliSeconds();
            long timer2Miliseconds = timer2.ConvertToMiliSeconds();
            if (timer1Miliseconds <= timer2Miliseconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator ==(Timer timer1, Timer timer2)
        {
            long timer1Miliseconds = timer1.ConvertToMiliSeconds();
            long timer2Miliseconds = timer2.ConvertToMiliSeconds();
            if (timer1Miliseconds == timer2Miliseconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Timer timer1, Timer timer2)
        {
            long timer1Miliseconds = timer1.ConvertToMiliSeconds();
            long timer2Miliseconds = timer2.ConvertToMiliSeconds();
            if (timer1Miliseconds != timer2Miliseconds)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
