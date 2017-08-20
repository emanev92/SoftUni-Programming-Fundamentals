using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


namespace _01.Sino_The_Walker
{
    public class Program
    {
        public static void Main()
        {
            var timeFormat = @"hh\:mm\:ss";
            var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);

            var stepsNeeded = int.Parse(Console.ReadLine()); 
            var secondsPerStep = int.Parse(Console.ReadLine());

            var secondsInADay = 60 * 60 * 24;
            var totalSeconds = (int) (((double)stepsNeeded * secondsPerStep) % secondsInADay);

            var timeNeeded = leavingTime.Add(new TimeSpan(0, 0, totalSeconds));

            Console.WriteLine("Time Arrival: " + timeNeeded.ToString(timeFormat) );
        }
    }
}
