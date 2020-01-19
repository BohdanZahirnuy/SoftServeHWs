using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloading
{
    public class Clock
    {
        private int hours;
        private int minutes;
        private int seconds;
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0)
                {
                    hours = value;
                }
                else
                {
                    throw new Exception("value cannot be negative!");
                }
            }
        }
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

        public Clock(int Hours, int Minutes, int Seconds)
        {
            this.Hours = Hours;
            this.Minutes = Minutes;
            this.Seconds = Seconds;
        }
        public int ConvertToSeconds()
        {
            int result = hours * 3600 + minutes * 60 + seconds;
            return result;
        }
        public static bool operator >(Clock clock1, Clock clock2)
        {
            int clock1Seconds = clock1.ConvertToSeconds();
            int clock2Seconds = clock2.ConvertToSeconds();
            if (clock1Seconds > clock2Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Clock clock1, Clock clock2)
        {
            int clock1Seconds = clock1.ConvertToSeconds();
            int clock2Seconds = clock2.ConvertToSeconds();
            if (clock1Seconds < clock2Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Clock clock1, Clock clock2)
        {
            int clock1Seconds = clock1.ConvertToSeconds();
            int clock2Seconds = clock2.ConvertToSeconds();
            if (clock1Seconds >= clock2Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Clock clock1, Clock clock2)
        {
            int clock1Seconds = clock1.ConvertToSeconds();
            int clock2Seconds = clock2.ConvertToSeconds();
            if (clock1Seconds <= clock2Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Clock clock1, Clock clock2)
        {
            int clock1Seconds = clock1.ConvertToSeconds();
            int clock2Seconds = clock2.ConvertToSeconds();
            if (clock1Seconds == clock2Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Clock clock1, Clock clock2)
        {
            int clock1Seconds = clock1.ConvertToSeconds();
            int clock2Seconds = clock2.ConvertToSeconds();
            if (clock1Seconds != clock2Seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Clock operator +(Clock clock, Timer timer)
        {
            int clockSeconds = clock.ConvertToSeconds();
            int timerSeconds = timer.ConvertToSeconds();
            int resultSeconds = clockSeconds + timerSeconds;
            int newClockHours = resultSeconds / 3600;
            int newClockMinutes = (resultSeconds - newClockHours * 3600) / 60;
            int newClockSeconds = resultSeconds - newClockHours * 3600 - newClockMinutes * 60;
            return new Clock(newClockHours, newClockMinutes, newClockSeconds);

        }
        public static Clock operator -(Clock clock, Timer timer)
        {
            int clockSeconds = clock.ConvertToSeconds();
            int timerSeconds = timer.ConvertToSeconds();
            int resultSeconds = clockSeconds - timerSeconds;

            if (resultSeconds >= 0)
            {
                int newClockHours = resultSeconds / 3600;
                int newClockMinutes = (resultSeconds - newClockHours * 3600) / 60;
                int newClockSeconds = resultSeconds - newClockHours * 3600 - newClockMinutes * 60;
                return new Clock(newClockHours, newClockMinutes, newClockSeconds);
            }
            else
            {
                return null;
            }

        }

    }
}
