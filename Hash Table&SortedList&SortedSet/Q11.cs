using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
     Autocomplete Suggestions in a Search Feature
     Description: Implement an autocomplete feature where users type a prefix, and the program suggests words starting with that prefix in alphabetical order.
     */

    public class Q11
    {
        static List<string> Autocomplete(string prefix)
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

            return tages.Where(x => x.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public static void Question()
        {
            Console.WriteLine($"flight times :{string.Join("\n", Autocomplete("l"))}");
        }
    }
}