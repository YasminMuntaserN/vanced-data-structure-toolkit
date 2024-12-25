using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
     Manage Reserved Seats in a Theater
     Description: In a theater booking system, keep track of reserved seat numbers, ensuring no duplicates and ordered seat numbers.
     */

    public class Q13
    {
        public static void Question()
        {
            SortedSet<int> Seats = new SortedSet<int> ()
            {
                24,
                25,
                34,
                20,
                21,
                30,
            };

            Console.WriteLine($"{string.Join("\n", Seats)}");
        }
    }
}