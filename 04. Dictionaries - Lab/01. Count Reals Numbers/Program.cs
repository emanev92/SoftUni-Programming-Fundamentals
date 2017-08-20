using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Count_Reals_Numbers
{
    class Program
    {
        static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
                
            var result = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                double parsedNum = double.Parse(num);
                    
                    if (result.ContainsKey(parsedNum))
                {
                    result[parsedNum]++;
                }

                else
                {
                    result[parsedNum] = 1 ;
                }
            }

            foreach (var num in result.Keys)
            {
                Console.WriteLine($"{num} -> {result[num]}");
            }
        }
    }
}
