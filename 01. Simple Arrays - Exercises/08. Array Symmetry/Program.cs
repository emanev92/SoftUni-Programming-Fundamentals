using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.Array_Symmetry
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');

            bool isSymetric = true;

            for (int i = 0; i < input.Length / 2; i++)
            {
                string firstWord = input[i];
                string secondWord = input[input.Length - 1 - i];

                if (firstWord != secondWord)
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
