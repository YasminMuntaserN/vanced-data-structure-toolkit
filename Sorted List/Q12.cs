using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
        Real-Time Leaderboard
        Problem: Track players’ scores in a game, sorted by player names.
    */
    public class Q12
    {
        public static void Question()
        {
            SortedList<string, int> list = new SortedList<string, int>
            {
                {"Yasmin",1000},
                {"Alaa",1000},
                {"Bana",1000},
                {"Reem",1000},
            };

            foreach (var player in list)
            {
                Console.WriteLine($"{player.Key} , {player.Value}");
            }
        }
    }
}
