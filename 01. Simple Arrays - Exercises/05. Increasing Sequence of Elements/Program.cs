using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areAllEqual = true;
            int previous = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] <= previous)
                {
                    areAllEqual = false;
                    break;
                }

                previous = nums[i];
            }


            if (areAllEqual)
            {
                Console.WriteLine("Yes");

            }

            else
            {
                Console.WriteLine("No");

            }

        }
    }
}
