using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Array_Contains_Element
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

            if (nums.Contains(input))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
