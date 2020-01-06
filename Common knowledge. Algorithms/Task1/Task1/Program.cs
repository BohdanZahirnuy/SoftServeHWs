using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Task: Find the minimal positive integer number Q so that the product of digits of Q is exactly equal to N.
/// </summary>
namespace Task1
{
    class Program
    {
        public static List<int> AlgorithmFunc(int num, List<int> digitsOut)
        {
            for (int i = 9; i > 0; i--) // a cycle in which we walk through all the digits from 0 to 9
            {
                if (i == 1) // if the number is prime or contains a prime number in itself
                {
                    digitsOut.Clear();
                    digitsOut.Add(-1);
                    return digitsOut;
                }
                if (num < 10) 
                {
                    digitsOut.Add(num);
                    digitsOut.Sort();
                    return digitsOut;
                }
                if (num % i == 0)
                {
                    num /= i;
                    digitsOut.Add(i);
                    i = 9;
                }
            }
            return digitsOut;
        }
        static void Main(string[] args)
        {
            int num;
            List<int> digits = new List<int>();
            Console.Write("Enter N (0 <= N <= 109): ");
            int.TryParse(Console.ReadLine(), out num);
            digits = AlgorithmFunc(num, digits);
            Console.Write("Q = ");
            foreach (int n in digits)
            {
                Console.Write(n);
            }
            Console.ReadKey();

        }
    }
}
