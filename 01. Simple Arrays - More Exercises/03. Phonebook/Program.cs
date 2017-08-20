using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Phonebook
{
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');
            var input = Console.ReadLine();

            while (input != "done")
            {

                PrintElement(names, numbers, input);
                input = Console.ReadLine();
            }
            
        }

        private static void PrintElement(string[] names, string[] numbers, string input)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == input)
                {
                    Console.WriteLine("{0} -> {1}", names[i], numbers[i]);
                }
            }
        }
    }
}
