using System;
using System.Collections.Generic;
using System.Linq;

namespace DecodeRadioFrequencies
{
    class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split()
                .ToArray();

            var result = new List<char>();

            for (int i = 0; i < nums.Length; i++)
            {
                var splitByPoint = nums[i].Split('.').Select(int.Parse).ToArray();

                for (int k = 0; k < splitByPoint.Length; k++)
                {
                    if (splitByPoint[k] != 0)
                    {
                        result.Insert(i, (char)splitByPoint[k]);
                    }
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join("", result));
        }
    }
}