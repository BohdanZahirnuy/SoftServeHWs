using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTask1
{
    class Class1
    {
        static void Main()
        {
            string checkPattern = @"^\d{4}\\\d{2}\\\d{2} \d{2}:\d{2}$";
            string pattern = @"^(1[0-9]{3}|200|[0-9]{1}|201[0-3])\\(0[0-9]{1}|1[0-2]{1})\\([0-2]{1}[0-9]{1}|[3]{1}[0]{1}) ([0-1]{1}[0-9]{1}|[2]{1}[0-3]{1}):([0-5]{1}[0-9]{1}|[6][0])$";

            Console.WriteLine(@"Enter date in format yyyy\mm\dd hh:mm");
            string date = Console.ReadLine();

            if (Regex.IsMatch(date, checkPattern))
            {

                if (Regex.IsMatch(date, pattern))
                {
                    Console.WriteLine("This date is between 1000 and 2013 year");

                }
                else
                {
                    Console.WriteLine("This date is not between 1000 and 2013 year");
                }
            }
            else
            {
                Console.WriteLine(@"Incorrect format. Please write in format yyyy\mm\dd hh:mm");
                Console.WriteLine(@"Example: 2012\12\12 12:12");
            }
            Console.ReadKey();
        }
    }
}
