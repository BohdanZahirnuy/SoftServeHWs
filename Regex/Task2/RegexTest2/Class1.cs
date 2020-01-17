using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTask2
{
    class Class1
    {
        static void Main()
        {
            string partOfPattern = @"(0x\d{2}|0x\d{1}[A-F]{1}|0x[A-F]{1}[A-F]{1}|0x[A-F]{1}\d{1}|[0-1]{1}\d{2}|[2]{1}[0-4]{1}\d{1}|[2]{1}[5]{1}[0-5]{1})";
            string pattern = @"^(" + @partOfPattern + @"\.){3}" + @partOfPattern + @"$";

            Console.WriteLine(@"Enter IPv4 adress: ");
            string text = Console.ReadLine();



            if (Regex.IsMatch(text, pattern))
            {
                Console.WriteLine("Correctly");

            }
            else
            {
                Console.WriteLine("It is not a IPv4 adress!");
            }


            Console.ReadKey();
        }
    }
}
