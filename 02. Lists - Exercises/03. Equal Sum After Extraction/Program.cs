using System;
using System.Collections.Generic;
using System.Linq;


namespace _03.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main()
        {
            var first = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var second = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < first.Count; i++)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    if (first[i] == second[j])
                    {
                        second.RemoveAll(item => item == second[j]);
                    }
                }
    
            }

            if (first.Sum() == second.Sum())
            {
                Console.WriteLine("Yes. Sum: {0}", second.Sum());
            }

            else
            {
                Console.WriteLine("No. Diff: {0}", Math.Abs(first.Sum() - second.Sum()));
            }
        }
    }
}
