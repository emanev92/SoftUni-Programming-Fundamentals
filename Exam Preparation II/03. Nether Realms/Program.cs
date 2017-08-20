using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

    class Program
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var result = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var health = demon.Where(s => !char.IsDigit(s) && s != '+'  && s != '-' && s != '*' && s != '/' && s != '.');

                var totalHealth = 0;

                foreach (var h in health)
                {
                    totalHealth += h;
                }

                var regex = new Regex(@"-?\d+\.?\d*");

                var matches = regex.Matches(demon);

                var demage = 0.0;

                foreach (Match match in matches)
                {
                    var currentNum = double.Parse(match.Value);

                    demage += currentNum;
                }

                var modifiers = demon.Where(s => s == '*' || s == '/');

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        demage *= 2;
                    }
                    else
                    {
                        demage /= 2;
                    }
                }

                    result.Add(demon, new Demon
                    {
                        Name = demon,
                        Health = totalHealth,
                        Damage = demage
                    });
                }

                foreach (var demon in result)
                {
                    var demon1 = demon.Value;
                    Console.WriteLine($"{demon.Key} - {demon1.Health} health, {demon1.Damage:F2} damage");
                }
            }
        }
    }
}
