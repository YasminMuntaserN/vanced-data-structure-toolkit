using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
        Manage Unique Flight Times
        Description: Organize flight times for a day in chronological order without duplicates.
     */

    public class Q09
    {
        public static void Question()
        {
            SortedSet<DateTime> FlightTimes = new SortedSet<DateTime>()
            {
                new DateTime(2024, 12, 22, 10, 0, 0),
                new DateTime(2024, 12, 24, 10, 0, 0),
                new DateTime(2024, 12, 25, 10, 0, 0),
                new DateTime(2024, 12, 22, 10, 0, 0), // Duplicate value
            };

            Console.WriteLine($"flight times :{string.Join("\n", FlightTimes)}");
        }
    }
}