using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
            .Split(' ')
            .ToList();

            var first = nums[0];
            var last = nums[nums.Count - 1];

            nums.Reverse();

            nums[0] = first;
            nums[nums.Count - 1] = last;

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
