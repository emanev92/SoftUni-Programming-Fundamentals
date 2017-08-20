using System;
using System.Collections.Generic;
using System.Linq;


namespace _10.Balistics_Training
{
    class Program
    {
        static void Main()
        {
            var coordinates = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var target = Console.ReadLine()
                .Split(' ');


            var result = new int[2];

            for (int i = 0, j = 1; i < target.Length; i++, j++)
            {
                if (target[i] == "up")
                {
                    result[1] += int.Parse(target[j]);
                }

                else if (target[i] == "down")
                {
                    result[1] -= int.Parse(target[j]);
                }

                else if (target[i] == "left")
                {
                    result[0] -= int.Parse(target[j]);
                }

                else if (target[i] == "right")
                {
                    result[0] += int.Parse(target[j]);
                }
            }

            Console.WriteLine("firing at [{0}, {1}]", result[0], result[1]);

            if (result[0] == coordinates[0] && result[1] == coordinates[1])
            {
                Console.WriteLine("got 'em!");
            }

            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}
