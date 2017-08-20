using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, long>> fileByRoot = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, string> fileByName = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('\\');

                var root = input[0];

                string[] file = input[input.Length - 1].Split( ';');

                var name = file[0];
                long size = long.Parse(file[1]);
                var extension = name.Split('.')[name.Split('.').Length - 1];



                 if (!fileByRoot.ContainsKey(root))
                {
                    fileByRoot[root] = new Dictionary<string, long>();

                }

                fileByRoot[root][name] = size;
                fileByName[name] = extension;
            }

            string[] queryParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var queryExtension = queryParams[0];
            var queryRoot = queryParams[2];

            Dictionary<string, long> results = new Dictionary<string, long>();

            if (fileByRoot.ContainsKey(queryRoot))
            {

                foreach (var result in fileByRoot[queryRoot])
                {
                    if (fileByName[result.Key] == queryExtension)
                    {
                        results.Add(result.Key, result.Value);
                    }
                }
            }
            if (results.Count > 0)
            {
                foreach (var file in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
