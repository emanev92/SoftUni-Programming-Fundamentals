using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Equal_Sequence_of_Elements_in_Array
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
            

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1])
                {
                    areAllEqual = false;
                    break;
                }

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
