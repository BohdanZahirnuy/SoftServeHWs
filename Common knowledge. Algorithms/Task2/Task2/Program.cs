using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Task: The little boy has a set of N cubes (5 ≤ N ≤ 500).
/// Different stairs can be made from these cubes. The stairs have steps of different sizes,
/// following in ascending order of this size (note that the stairs cannot have two identical steps).
/// Each ladder must have at least two steps and each step must consist of at least one cube.
/// 
/// Explanation: I wrote an algorithm that works correctly but is not time optimized. 
/// So please enter numbers from 6 to 40, because you will have to wait a long time if you enter a larger number.
/// 
/// Additionally: If you want to see all combinations of different "stairs", you should use method "PrintCombos".
/// </summary>
namespace Task2
{
    class Program
    {
        static List<string> combos = new List<string>(); //variable that contains combos of different "stairs"
        static void AddCombo(List<int> nums)
        {
            string s = ConvertIntItemsIntoString(nums);
            if (!combos.Contains(s))
            {
                combos.Add(s);
            }
        }
        public static void PrintCombos()
        {
            foreach (string combo in combos)
            {
                Console.WriteLine(combo);
            }
        }
        public static int ListSum(List<int> nums)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                sum += num;
            }
            return sum;
        }
        static List<int> ListCopy(List<int> nums)
        {
            List<int> tempList = new List<int>();
            foreach (int num in nums)
            {
                tempList.Add(num);
            }
            return tempList;
        }
        public static string ConvertIntItemsIntoString(List<int> nums)
        {
            string s = "";
            nums.Sort();
            foreach (int num in nums)
            {
                s += num.ToString();
            }
            return s;
        }
        public static List<int> DecomposeFirst(int num)
        {
            List<int> nums = new List<int>();
            int counter = 0;
            while (ListSum(nums) < num)
            {
                ++counter;
                nums.Add(counter);
            }
            nums.RemoveAt(nums.Count - 1);

            for (int i = nums.Count - 1; i > 0; i--)
            {
                int lastItem = num - ListSum(nums);
                if (nums.Contains(lastItem))
                {
                    nums.Remove(nums[i]);
                }
                else
                {
                    nums.Add(lastItem);
                    break;
                }
            }
            AddCombo(nums);
            return nums;
        }
        public static List<int> OtherDecompositions(List<int> nums)
        {
            List<int> tempNums = new List<int>();
            if (nums.Count == 2)
            {
                return tempNums;
            }
            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums.Contains(nums[i] + nums[j]))
                    {
                        continue;
                    }
                    else
                    {

                        tempNums = ListCopy(nums);
                        tempNums[j] += tempNums[i];
                        tempNums.Remove(tempNums[i]);
                        AddCombo(tempNums);
                        OtherDecompositions(tempNums);
                    }
                }
            }
            return nums;
        }

        static void Main(string[] args)
        {
            int num;
            List<int> nums = new List<int>();
            Console.Write("Enter number N ( 5 <N < 40):");
            int.TryParse(Console.ReadLine(), out num);
            nums = DecomposeFirst(num);
            nums = OtherDecompositions(nums);
            Console.WriteLine("Q = {0}", combos.Count);
            // PrintCombos(); 
            Console.ReadKey();
        }
    }
}
