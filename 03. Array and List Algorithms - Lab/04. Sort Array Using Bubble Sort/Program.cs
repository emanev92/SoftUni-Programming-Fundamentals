using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Sort_Array_Using_Bubble_Sort
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    var current = nums[i];
                    var next = nums[i + 1];

                    if (current > next)
                    {

                        nums[i + 1] = current;
                        nums[i] = next;

                        swapped = true;
                    }
                }

            } while (swapped);

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
