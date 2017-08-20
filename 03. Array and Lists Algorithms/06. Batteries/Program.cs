using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Batteries
{
    class Program
    {
        public static void Main()
        {
            var capacity = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var usage = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var hours = int.Parse(Console.ReadLine());

            double[] output = new double[capacity.Length];

            for (int i = 0; i < capacity.Length; i++)
            {
                var currentCapacity = capacity[i] - usage[i] * hours;

                if (currentCapacity > 0)
                {
                    var percentage = (currentCapacity * 100.0) / capacity[i];
                    output[i] = percentage;
                    capacity[i] = currentCapacity;
                }
                else
                {
                    output[i] = Math.Ceiling(capacity[i] / usage[i]) * -1;
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                if (output[i] > 0.0)
                {
                    Console.WriteLine($"Battery {i + 1}: {capacity[i]:F2} mAh ({output[i]:F2})%");
                }

                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {output[i] * -1} hours)");
                }
            }
        }
    }
}
