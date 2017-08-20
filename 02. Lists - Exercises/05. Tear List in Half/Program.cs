using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Tear_List_in_Half
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var rightHalf = new List<int>();
            var leftHalf = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                leftHalf.Add(input[i]);
            }

            for (int i = input.Count / 2; i < input.Count; i++)
            {
                rightHalf.Add(input[i]);
            }

            var result = new List<int>();

            for (int i = 0; i < leftHalf.Count; i++)
            {
                result.Add(rightHalf[i] / 10);
                result.Add(leftHalf[i]);
                result.Add(rightHalf[i] % 10);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
