using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Count_Occurrences_of_Larger_Number_in_Array
{
    class Program
    {
        static void Main()
        {
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var number = double.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (number < nums[i])
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
