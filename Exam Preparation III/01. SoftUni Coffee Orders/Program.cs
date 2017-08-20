using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.SoftUni_Coffee_Orders
{
    class Program
    {
        static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            decimal totalPrice = 0M;

            for (int i = 0; i < input; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = int.Parse(Console.ReadLine());

                var price = ((DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * (long)capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
