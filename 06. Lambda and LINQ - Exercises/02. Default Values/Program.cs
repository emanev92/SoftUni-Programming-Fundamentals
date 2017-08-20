using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Default_Values
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, string>();

            while(input != "end")
            {
                var tokens = input.Split(new[] { ' ', '>', '-' }, StringSplitOptions.RemoveEmptyEntries);

                dictionary[tokens[0]] = tokens[1];

                input = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unchanged = dictionary.Where(x => x.Value != "null")
               .OrderByDescending(x => x.Value.Length);

            var changed = dictionary.Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var kvp in unchanged)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            foreach (var kvp in changed)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
            
        }
    }
}
