using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Smallest_Element_in_Array
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(nums.Min());

        }
    }
}
