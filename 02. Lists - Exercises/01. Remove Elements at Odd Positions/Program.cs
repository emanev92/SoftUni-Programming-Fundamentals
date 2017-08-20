using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Lists___Exercisses
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(input[i]);
                }
            }
            Console.WriteLine(String.Join("", result));
        
        }
    }
}
