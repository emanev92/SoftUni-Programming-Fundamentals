using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Odd_Occurrences
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();
                

            var result = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!result.ContainsKey(input))
                {

                }
            }
        }
    }
}
