using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Exam_Shopping
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stockings = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var tokens = input.Split(' ');
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!stockings.ContainsKey(tokens[1]))
                {
                    stockings[product] = 0;
                }

                stockings[product] += quantity;


                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "exam time")
            {
                var tokens = input.Split(' ');
                var product = tokens[1];
                var quantity = int.Parse(tokens[2]);

                if (!stockings.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }

                else
                {

                    if (stockings[product] == 0)
                    {
                        Console.WriteLine($"{product} out of stock");
                    }
                    else
                    {
                        stockings[product] -= quantity;

                        if (stockings[product] < 0)
                        {
                            stockings[product] = 0;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var stock in stockings)
            {
                if (stock.Value > 0)
                {
                    Console.WriteLine($"{stock.Key} -> {stock.Value}");
                }
            }
        }
    }
}
