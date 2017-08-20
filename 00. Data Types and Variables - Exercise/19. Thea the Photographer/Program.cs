using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pictures = int.Parse(Console.ReadLine());
            var filterTime = decimal.Parse(Console.ReadLine());
            var goodPictures = long.Parse(Console.ReadLine());
            var uploadTime = decimal.Parse(Console.ReadLine());

            var filteredPictrures =(int) Math.Ceiling(pictures * ((double)goodPictures / 100.0));
            var timeForAllPictures = pictures * (long)filterTime;
            var cloudTime = filteredPictrures * (long)uploadTime;
            var totalTime = (ulong)(cloudTime + timeForAllPictures);

            Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(@"d\:hh\:mm\:ss"));



        }
    }
}
