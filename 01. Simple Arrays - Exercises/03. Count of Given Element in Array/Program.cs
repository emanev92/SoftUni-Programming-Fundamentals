using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            nums.Sort();
            var counter = 0;

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (number == nums[i])
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
