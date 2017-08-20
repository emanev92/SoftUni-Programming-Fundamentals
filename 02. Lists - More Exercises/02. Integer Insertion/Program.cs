using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();
            

            while (input != "end")
            {
                int firstDigit = (input.ToString()[0]) - 48;

                nums.Insert(firstDigit, int.Parse(input));

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));

        }
    }
}

