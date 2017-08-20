using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Serialize_String
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var charPosition = new Dictionary<string, List<string>>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!charPosition.ContainsKey(input[i].ToString())) 
                {
                    charPosition[input[i].ToString()] = new List<string>();
                }

                charPosition[input[i].ToString()].Add(i.ToString());
            }

            foreach (var token in charPosition)
            {
                Console.WriteLine("{0}:{1}", token.Key.ToString(), string.Join("/", token.Value));
            }
            
        }
    }
}
