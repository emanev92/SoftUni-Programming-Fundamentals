using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Ordered_Banking_System
{
    class Program
    {
        public static void Main()
        {
            var bankAccounts = new Dictionary<string, Dictionary<string, decimal>>();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = tokens[0];
                var account = tokens[1];
                var sum = decimal.Parse(tokens[2]);

                if (!bankAccounts.ContainsKey(bank))
                {
                    bankAccounts.Add(bank, new Dictionary<string, decimal>());

                }

                if (!bankAccounts[bank].ContainsKey(account))
                {
                    bankAccounts[bank].Add(account, 0);
                }

                bankAccounts[bank][account] += sum;

                input = Console.ReadLine();

            }

            var orderedBankAccounts = bankAccounts.OrderByDescending(x => x.Value.Sum(acc => acc.Value))
                .ThenByDescending(x => x.Value.Max(acc => acc.Value));

            foreach (var kvp in orderedBankAccounts)
            {
                foreach (var bank in kvp.Value.OrderByDescending(acc => acc.Value))
                {
                    
                        Console.WriteLine($"{bank.Key} -> {bank.Value} ({kvp.Key})");
                }
            }
        }
    }
}
