using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == i)
                {
                    Console.Write(nums[i] + " ");
                    
                }
            }
            Console.WriteLine();
        }
    }
}
