using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Average_Character_Delimiter
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            int sum = 0;
            int count = 0;
            foreach (var letter in input)
            {
                if (letter == ' ') continue;
                sum += letter;
                ++count;
            }
            char average = (char)(sum / count);
            //'c' - 'a' = 2 + 'A' = 'C'
            if ((average >= 'a' && average <= 'z')) average = (char)(average - 'a' + 'A');
            string[] words = input.Split(' ');
            string result = string.Join(average.ToString(), words);
            Console.WriteLine(result);
        }

    }
}