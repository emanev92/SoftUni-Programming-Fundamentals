using System;
using System.Collections.Generic;



namespace _02.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var negatives = 0;

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 0)
                {
                    negatives++;
                }
            }

            Console.WriteLine(negatives);

        }
    }
}
