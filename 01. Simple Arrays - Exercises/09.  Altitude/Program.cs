using System;
using System.Collections.Generic;
using System.Linq;


namespace _09.Altitude
{
    class Program
    {
        static void Main()
        {
            string[] commands = Console.ReadLine().Split(' ').ToArray();
            double altitude = double.Parse(commands[0]);

            for (int i = 0; i < commands.Length; i++)
            {
                if (i % 2 != 0 && commands[i] == "up")
                {
                    altitude += double.Parse(commands[i + 1]);
                }
                else if (i % 2 != 0 && commands[i] == "down")
                {
                    altitude -= double.Parse(commands[i + 1]);
                    if (altitude <= 0)
                    {
                        break;
                    }

                }
            }

            if (altitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
