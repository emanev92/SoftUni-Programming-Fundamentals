using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Mixed_Phones
{
    class Program


    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phoneBook = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                var tokens = input.Split(" : ".ToCharArray(), 
                    StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                long number = 0;
                if (long.TryParse(firstElement, out number))
                {
                    phoneBook[secondElement] = number;
                }
                else if (long.TryParse(secondElement, out number))
                {
                    phoneBook[firstElement] = number;
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in phoneBook)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
