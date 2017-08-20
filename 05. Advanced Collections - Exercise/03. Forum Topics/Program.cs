using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Forum_Topics
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dictionary = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                var tokens = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = tokens[0];

                if (!dictionary.ContainsKey(topic))
                {
                    dictionary[topic] = new HashSet<string>();

                    for (int i = 1; i < tokens.Length; i++)
                    {
                        dictionary[topic].Add(tokens[i]);
                    }
                }

                
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            var wantedTags = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var item in dictionary)
            {
                var topic = item.Key;
                var tags = item.Value;
                var counter = 0;
                for (int i = 0; i < wantedTags.Count; i++)
                {
                    if (item.Value.Contains(wantedTags[i]))
                    {
                        counter++;
                        
                    }

                    if (wantedTags.Count == counter)
                    {
                        Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                    }
                }
            }
        }
    }
}