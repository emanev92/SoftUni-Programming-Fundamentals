using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _04.Happiness_Index
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var patternHappy = @"(?<happy>[:;c*\(\[][\)D*\]}:;])";
            var patternSad = @"(?<sad>[:D;\)\]][(:[{c;])";

            var happy = new Regex(patternHappy)
                .Matches(input)
                .Cast<Match>()
                .Select(x => x.Value)
                .Where(x => x[0] != x[1])
                .ToList();

            var sad = new Regex(patternSad)
                .Matches(input)
                .Cast<Match>()
                .Select(x => x.Value)
                .Where(x => x[0] != x[1])
                .ToList();

            int happyCount = happy.Count;
            int sadCount = sad.Count;
            double happinessIndex = Math.Round((double)happyCount / sadCount, 2);

            var status = string.Empty;
            if (happinessIndex >= 2)
            {
                status = ":D";
            }
            else if (happinessIndex > 1)
            {
                status = ":)";
            }
            else if (happinessIndex == 1)
            {
                status = ":|";
            }
            else
            {
                status = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:f2} {status}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
        }
    }
}
