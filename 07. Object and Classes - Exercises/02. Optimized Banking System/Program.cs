using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.Optimized_Banking_System
{
    class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var info = new List<BankAccount>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = tokens[0];
                var accountName = tokens[1];
                var accBalance = decimal.Parse(tokens[2]);

                var bankAcc = new BankAccount();

                bankAcc.Name = accountName;
                bankAcc.Bank = bank;
                bankAcc.Balance = accBalance;

                info.Add(bankAcc);
                

                input = Console.ReadLine();
            }

            var result = info.OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (var bank in result)
            {
                Console.WriteLine($"{bank.Name} -> {bank.Balance} ({bank.Bank})");
            }
        }
    }
}
