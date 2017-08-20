using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Flatten_Dictionary
{
    class Program
    {
        public static void Main()
        {
            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(' ');

                if (tokens[0] != "flatten")
                {
                    var key = tokens[0];
                    var innerKey = tokens[1];
                    var innerValue = tokens[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }

                    dictionary[key][innerKey] = innerValue;

                }

                else
                {
                    var key = tokens[1];

                    dictionary[key] = dictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }


                input = Console.ReadLine();
            }

            var orderedDictionary = dictionary.OrderByDescending(x => x.Key.Length);

            foreach (var kvp in orderedDictionary)
            {
                Console.WriteLine($"{kvp.Key}");

                var innerDictionary = kvp.Value.Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length);

                var flattenedValues = kvp.Value.Where(x => x.Value == "flattened");

                var count = 1;

                foreach (var a in innerDictionary)
                {
                    Console.WriteLine($"{count}. {a.Key} - {a.Value}");
                    count++;
                }

                foreach (var a in flattenedValues)
                {
                    Console.WriteLine($"{count}. {a.Key}");
                    count++;
                }


            }
        }
    }
}
