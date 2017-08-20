using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Hornet_Wings
{
    public class Program
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var metersTraveled = (wingFlaps / 1000) * distance;
            var flaps = wingFlaps / 100;

            var secondsPassed = (wingFlaps / endurance) * 5;
            var result = flaps + secondsPassed;

            Console.WriteLine($"{metersTraveled:F2} m.");
            Console.WriteLine($"{result} s.");
        }
    }
}
