using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int firstLetter = 0; firstLetter < n; firstLetter++)
            {
                for (int secondLetter = 0; secondLetter < n; secondLetter++)
                {
                    for (int thirdLetter = 0; thirdLetter < n; thirdLetter++)
                    {
                        char letter1 = (char)('a' + firstLetter);
                        char letter2 = (char)('a' + secondLetter);
                        char letter3 = (char)('a' + thirdLetter);

                        Console.WriteLine("{0}{1}{2}", letter1,letter2, letter3 );
                    }
                }
            }
        }
    }
}
