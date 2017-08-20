using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentWord = input[i];

                if (currentWord.Length == 1)
                {
                    char letter = currentWord[0];

                    if (letter >= 'A' || letter  <= 'Z')
                    {
                        count++;

                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
