﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Program
    {
        static void Main() 
        {
            var input = Console.ReadLine();

            var regex = new Regex("([1]?[0-9JQKA])([SHDC])");

            MatchCollection matchedCards = regex.Matches(input);

            var validCards = new List<string>();

            foreach (Match card in matchedCards)
            {
                var power = 0;

                if (int.TryParse(card.Groups[1].Value, out power))
                {

                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                validCards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
