using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < input.Count; i++)
                {
                    int compare = 0;
                    compare = input[i - 1].CompareTo(input[i]);

                    if (compare == 1)
                    {
                        var temp = input[i - 1];
                        input[i - 1] = input[i];
                        input[i] = temp;
                        swapped = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", input));

        }
    }
}
