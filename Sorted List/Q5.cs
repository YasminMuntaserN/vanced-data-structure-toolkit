using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
        Problem: Find all elements in a SortedSet less than a given value.

        Example:
        Input: set = [1, 2, 3, 4, 5], value = 4
        Output: [1, 2, 3]


        Key Points:
        Use GetViewBetween to get a subset.
     */
    public class Q5
    {
        public static List<int> ElementsLessThanValue(SortedSet<int> set, int value)
           =>set.GetViewBetween(set.Min,  value-1).ToList();
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{string.Join(", ", ElementsLessThanValue(sortedSet ,4))}"); 
        }
    }
}
