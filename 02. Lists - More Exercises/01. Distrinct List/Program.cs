using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Lists___More_Exercisses
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .Distinct()
                .ToList()));
        }
    }
}
