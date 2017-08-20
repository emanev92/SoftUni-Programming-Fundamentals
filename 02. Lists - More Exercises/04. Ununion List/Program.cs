using System;
using System.Collections.Generic;
using System.Linq;


namespace UnunionList
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToList();

                for (int j = 0; j < list.Count; j++)
                {
                    if (numbers.Contains(list[j]))
                    {
                        numbers.RemoveAll(x => x == list[j]);
                    }
                    else
                    {
                        numbers.Add(list[j]);

                    }
                }
            }
            numbers.Sort();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}