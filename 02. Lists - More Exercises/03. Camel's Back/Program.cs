using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main()
        {
            var buildings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var camelsBack = int.Parse(Console.ReadLine());

            var rounds = 0;

            if (camelsBack == buildings.Count)
            {
                Console.WriteLine("already stable: {0}", string.Join(" ", buildings));

            }

            else
            {
                while (camelsBack != buildings.Count)
                {
                    buildings.RemoveAt(buildings.Count - 1);
                    buildings.RemoveAt(0);
                    rounds++;
                }

                Console.WriteLine("{0} rounds", rounds);
                Console.WriteLine("remaining: {0}", string.Join(" ", buildings));
            }
        }
    }
}
