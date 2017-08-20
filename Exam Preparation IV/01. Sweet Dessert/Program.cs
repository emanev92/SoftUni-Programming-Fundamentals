using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    public class Program
    {
        public static void Main()
        {
            var money = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests / 6m);

            var priceAll = portions * (2 * bananaPrice) + portions * (4 * eggPrice) + portions * ((decimal)0.2 * berriesPrice);


            if (money >= priceAll)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceAll:F2}lv.");
            }
            else
            {
                var neededMoney = priceAll - money;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:F2}lv more.");
            }
        }
    }
}
