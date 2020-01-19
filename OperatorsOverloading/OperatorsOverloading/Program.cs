using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OperatorsOverloading
{
    class Program
    {
        static void Main()
        {
            Clock clock1 = new Clock(10, 10, 10);
            Clock clock2 = new Clock(10, 10, 11);
            Console.WriteLine("clock1>clock2: " + (clock1 > clock2));
            Console.WriteLine("clock1<clock2: " + (clock1 < clock2));
            Console.WriteLine("clock1>=clock2: " + (clock1 >= clock2));
            Console.WriteLine("clock1<=clock2: " + (clock1 <= clock2));
            Console.WriteLine("clock1==clock2: " + (clock1 == clock2));
            Console.WriteLine("clock1!=clock2: " + (clock1 != clock2));

            Timer timer1 = new Timer(5, 5, 6);
            Timer timer2 = new Timer(5, 5, 6);
            Console.WriteLine("timer1>timer2: " + (timer1 > timer2));
            Console.WriteLine("timer1<timer2: " + (timer1 < timer2));
            Console.WriteLine("timer1>=timer2: " + (timer1 >= timer2));
            Console.WriteLine("timer1<=timer2: " + (timer1 <= timer2));
            Console.WriteLine("timer1==timer2: " + (timer1 == timer2));
            Console.WriteLine("timer1!=timer2: " + (timer1 != timer2));

            Clock clock = clock1 + timer1;
            Console.WriteLine("Clock hours:{0}, Clock minutes:{1}, Clock Seconds:{2}", clock.Hours, clock.Minutes, clock.Seconds);
            clock = clock1 - timer1;
            Console.WriteLine("Clock hours:{0}, Clock minutes:{1}, Clock Seconds:{2}", clock.Hours, clock.Minutes, clock.Seconds);

            Console.ReadKey();
        }
    }
}
