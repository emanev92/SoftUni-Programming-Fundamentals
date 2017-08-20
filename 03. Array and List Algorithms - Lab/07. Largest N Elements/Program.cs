using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
             .Split(' ')
             .Select(int.Parse)
             .ToList();

            var input = int.Parse(Console.ReadLine());

            nums.Sort();
            nums.Reverse();

            var result = new List<int>();

            for (int i = 0; i < input; i++)
            {
                result.Add(nums[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
