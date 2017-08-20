using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Shellbound
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regionName = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var tokens = input.Split(' ');
                var town = tokens[0];
                var size = int.Parse(tokens[tokens.Length - 1]);

                if (!regionName.ContainsKey(town))
                {
                    regionName[town] = new HashSet<int>();
                    regionName[town].Add(size);

                }

                regionName[town].Add(size);
                input = Console.ReadLine();
            }

            foreach (var region in regionName)
            {
                long sum = 0;

                foreach (var shell in region.Value)
                {
                    sum += shell;
                }

                if (region.Value.Count > 1)
                {
                    sum -= (sum / region.Value.Count);
                }

                Console.WriteLine($"{region.Key} -> {string.Join(", ", region.Value)} ({sum})");
            }
        }
    }
}
