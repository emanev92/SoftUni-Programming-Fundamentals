﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Char_Rotation
{
    class Program
    {
        static void Main()
        {
            string charValues = Console.ReadLine();
            int[] intValues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char[] result = new char[intValues.Length];
            for (int i = 0; i < intValues.Length; i++)
            {
                
                if (intValues[i] % 2 == 0)
                {
                    result[i] = (char)(charValues[i] - intValues[i]);
                }
                else
                {                               
                    result[i] = (char)(charValues[i] + intValues[i]);
                }
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
