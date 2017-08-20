using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Charity_Marathon
{
    public class Program
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var avarageLaps = int.Parse(Console.ReadLine());
            var length = long.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var money = double.Parse(Console.ReadLine());

            capacity = capacity * days;

            runners = Math.Min(capacity, runners);

            long totalMeters = runners * length * avarageLaps;
            long totalKM = totalMeters / 1000;

            double totalMoney = totalKM * money;

            Console.WriteLine($"Money raised: {totalMoney:F2}");


        }
    }
}
