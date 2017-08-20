using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace _01.Register_Users
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var registry = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var username = tokens[0];
                var registeredDate = DateTime.ParseExact(tokens[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                
                    registry[username] = registeredDate;
                

                input = Console.ReadLine();
            }

            var orderedUsernames = registry.Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value);
                
                 

            foreach (var user in orderedUsernames)
            {
                Console.WriteLine("{0}", user.Key);
            };
        }
    }
}
