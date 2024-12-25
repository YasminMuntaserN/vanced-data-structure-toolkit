using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
     Manage Tags in a Blogging Platform
     Description: In a blogging platform, authors can add tags to their posts. Maintain a list of all unique tags in alphabetical order.
     */

    public class Q10
    {
        public static void Question()
        {
            SortedSet<string> tages = new SortedSet<string>()
            {
                "life",
                "laugh",
                "music",
                "coding",
                "Enjoy",
                "life",
            };

            Console.WriteLine($"flight times :{string.Join("\n", tages)}");
        }
    }
}