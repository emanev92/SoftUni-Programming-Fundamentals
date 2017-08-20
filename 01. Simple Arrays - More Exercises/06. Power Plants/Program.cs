using System;
using System.Collections.Generic;
using System.Linq;


namespace _06.Power_Plants
{
    class Program
    {
        static void Main()
        {
            var power = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var day = -1;

            for (int i = 0; i < power.Length; i++)
            {
                if (power[i] > 0)
                {
                    power[i]++;
                }

                for (int j = 0; j < power.Length; j++)
                {
                    if (power[j] != 0)
                    {
                        power[j]--;
                    }
                }

                day++;
                var sum = 0;

                for (int j = 0; j < power.Length; j++)
                {
                    sum += power[j];
                }

                if (sum > 0)
                {
                    if (i == power.Length - 1)
                    {
                        for (int k = 0; k < power.Length; k++)
                        {
                            if (power[k] > 0)
                            {
                                power[k]++;
                            }
                        }

                        i = -1;
                    }
                    continue;
                }

                else
                {
                    Console.WriteLine("survived {0} days ({1} seasons)", day + 1, day / power.Length);
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
