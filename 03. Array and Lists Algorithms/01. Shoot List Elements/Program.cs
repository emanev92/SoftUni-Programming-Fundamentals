using System;
using System.Collections.Generic;
using System.Linq;
class ShootListElements
{
    static void Main()
    {
        var input = new List<int>();

        var inputLine = Console.ReadLine();

        var lastNumber = 0;

        while (inputLine != "stop")
        {
            if (inputLine == "bang" && input.Count == 0)
            {
                Console.WriteLine($"nobody left to shoot! last one was {lastNumber}");
                return;
            }
            if (inputLine != "bang")
            {
                input.Insert(0, Convert.ToInt32(inputLine));
            }

            if (inputLine == "bang")
            {

                var average = input.Average();

                for (int i = 0; i < input.Count; i++)
                {
                    if (input[i] <= average)
                    {
                        lastNumber = input[i];
                        Console.WriteLine($"shot {input[i]}");
                        input.Remove(input[i]);
                        break;
                    }
                }
                for (int i = 0; i < input.Count; i++)
                {
                    input[i] = input[i] - 1;
                }
            }

            inputLine = Console.ReadLine();
        }
        if (inputLine == "stop" && input.Count > 0)
        {
            Console.WriteLine($"survivors: {string.Join(" ", input)}");
        }
        if (inputLine == "stop" && input.Count == 0)
        {
            Console.WriteLine($"you shot them all. last one was {lastNumber}");
        }
    }
}