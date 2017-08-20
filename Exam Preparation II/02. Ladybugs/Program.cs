using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Ladybugs
{
    public class Program
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var ladybug = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();


            var field = new int[size];

            foreach (var ladybugIndex in ladybug)
            {
                if (ladybugIndex < 0 || ladybugIndex >= size)
                {
                    continue;
                }

                field[ladybugIndex] = 1;
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;

                }

                var tokens = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var length = int.Parse(tokens[2]);

                if (currentIndex < 0 || currentIndex >= size)
                {
                    continue;
                }

                if (field[currentIndex] == 0)
                {
                    continue;
                }

                field[currentIndex] = 0;
                var position = currentIndex;

                while (true)
                {
                  

                    if (direction == "right")
                    {
                        position += length;
                    }
                    else
                    {
                        position -= length;
                    }

                    if (position < 0 || position >= size)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }

                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", field));

        }
    }
}
