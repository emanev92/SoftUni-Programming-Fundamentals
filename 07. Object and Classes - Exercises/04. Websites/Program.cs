using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Websites
{
    public class Websites
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var tempResult = new List<Websites>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var hosts = tokens[0];
                var domain = tokens[1];
                var queries = tokens.Skip(2).ToList();

                var newWebsites = new Websites();

                newWebsites.Host = hosts;
                newWebsites.Domain = domain;
                newWebsites.Queries = queries;

                tempResult.Add(newWebsites);

                input = Console.ReadLine();

            }


            foreach (var website in tempResult)
            {

                if (website.Queries.Count > 0)
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=");
                    int count = 0;
                    foreach (var query in website.Queries)
                    {
                        Console.Write($"[{query}]");
                        count++;
                        if (count < website.Queries.Count())
                        {
                            Console.Write("&");
                        }

                    }
                }
                else
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}");
                }

                Console.WriteLine();
            }
        }
    }
}
