using System;
using System.Collections.Generic;

namespace ConsoleApplication16
{
    class Program
    {
        public static void Main()
        {
            Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputParams = input.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                int firstValue = -1;
                string currentKey = inputParams[0];
                if (int.TryParse(inputParams[1], out firstValue))
                {
                    if (!dictionary.ContainsKey(currentKey))
                    {
                        dictionary[currentKey] = new List<int>();
                    }
                    for (int i = 1; i < inputParams.Length; i++)
                    {
                        dictionary[currentKey].Add(int.Parse(inputParams[i]));
                    }
                }
                else
                {
                    string otherKey = inputParams[1];
                    if (dictionary.ContainsKey(otherKey))
                    {
                        dictionary[currentKey] = new List<int>(dictionary[otherKey]);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var entry in dictionary)
            {
                Console.WriteLine("{0} === {1}", entry.Key, string.Join(", ", entry.Value));
            }

        }
    }
}