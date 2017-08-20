using System;
using System.Collections.Generic;
using System.Linq;



namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < nums.Count / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = nums.Count - 1 - i;

                var temp = nums[leftIndex];
                nums[leftIndex] = nums[rightIndex];
                nums[rightIndex] = temp;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
