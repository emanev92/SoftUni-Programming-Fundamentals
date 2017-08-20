using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    public class SoldierInfo
    {
        public int LastActivity { get; set; }
        public string LegionName { get; set; }
        public string Type { get; set; }
        public long Count { get; set; }
        public int Order { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var soldiers = new List<SoldierInfo>();
            var activities = new Dictionary<string, int>();
            var order = 0;
            var orders = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', '-', '=', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = int.Parse(input[0]);
                var legionName = input[1];

                if(!activities.ContainsKey(input[1]) || activities[legionName] < lastActivity)
                {
                    activities[legionName] = lastActivity;
                }

                order++;

                if (!orders.ContainsKey(legionName) || orders[legionName] > order)
                {
                    orders[legionName] = order;
                }

                

                soldiers.Add(new SoldierInfo
                {
                    LastActivity = activities[legionName],
                    LegionName = legionName,
                    Type = input[2],
                    Count = long.Parse(input[3]),
                    Order = order

                });
            }

            foreach (var soldierInfo in soldiers)
            {
                soldierInfo.LastActivity = activities[soldierInfo.LegionName];
                soldierInfo.Order = orders[soldierInfo.LegionName];
            }

            var command = Console.ReadLine();

            if (command.Contains("\\"))
            {
                var commandParts = command.Split('\\');
                var activity = int.Parse(commandParts[0]);
                var soldierType = commandParts[1];

                var result = soldiers.Where(s => s.Type == soldierType && s.LastActivity < activity)
                    .GroupBy(s => s.LegionName)
                    .Select(grs => new
                    {
                        LegionName = grs.Key,
                        Count = grs.Sum(s => s.Count),
                        Order = grs.Min(s => s.Order)

                    })
                    .OrderByDescending(s => s.Count)
                    .ThenBy(s => s.Order)
                    .ToList();

                foreach (var info in result)
                {
                    Console.WriteLine($"{info.LegionName} -> {info.Count}");
                }
            }
            else
            {
                var soldierType = command;

                var result = soldiers.Where(s => s.Type == soldierType)
                    .GroupBy(s => s.LegionName)
                    .Select(gr => new
                    {
                        LegionName = gr.Key,
                        LastActivity = gr.Max(s => s.LastActivity),
                        Order = gr.Min(s => s.Order)
                    })
                    .OrderByDescending(s => s.LastActivity)
                    .ThenBy(s => s.Order)
                    .ToList();


                foreach (var info in result)
                {
                    Console.WriteLine($"{info.LastActivity} : {info.LegionName}");
                }
            }



        }

    }
}
