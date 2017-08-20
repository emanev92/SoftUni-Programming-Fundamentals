using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Largest_Element_in_Array
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var elements = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                elements.Add(currentNumber);
            }

            Console.WriteLine(elements.Max());
        }
    }
}
