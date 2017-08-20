using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());

                Console.WriteLine("Before:");
                Console.WriteLine("a =" + ' ' + first);
                Console.WriteLine("b =" + ' ' + second);
                Console.WriteLine("After:");
                Console.WriteLine("a =" + ' ' + second);
                Console.WriteLine("b =" + ' ' + first);

            }
    }
}
