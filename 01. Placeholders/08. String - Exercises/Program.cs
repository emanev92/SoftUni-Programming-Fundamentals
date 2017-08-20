using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.String___Exercises
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var sentance = tokens[0].Trim();
                var elements = tokens[1].Trim().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";

                    sentance = sentance.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(sentance);

                input = Console.ReadLine();
            }
        }
    }
}
