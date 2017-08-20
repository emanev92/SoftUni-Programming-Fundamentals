using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Lambada_Expressions
{
    class Program
    {
        public static void Main()
        {
            var lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();

            var input = Console.ReadLine();

            while (input != "lambada")
            {
                var tokens = input.Split(new[] { ' ', '=', '.', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 1)
                {
                    var selector = tokens[0];
                    var selectorObject = tokens[1];
                    var property = tokens[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions.Add(selector, new Dictionary<string, string>());

                    }

                    lambadaExpressions[selector][selectorObject] = property;
                }

                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(selector => selector.Key, selector => selector.Value
                        .ToDictionary(selectorObject => selector.Key, selectorObject => selectorObject.Key + "." + selectorObject.Value));
                }
                 
                input = Console.ReadLine();
            }

            foreach (var kvp in lambadaExpressions)
            {
                foreach (var selectorObject in kvp.Value)
                {
                    Console.WriteLine($"{kvp.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
