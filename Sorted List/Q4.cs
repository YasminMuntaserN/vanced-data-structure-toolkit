using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
    Problem: Remove all elements from a SortedSet that are greater than a specified value.

    Example:
    Input: set = [1, 2, 3, 4, 5], value = 3
    Output: [1, 2, 3]


    Key Points:
    Use GetViewBetween to create a range and then replace the set.
     */
    public class Q4
    {
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{string.Join(", ", sortedSet.GetViewBetween(sortedSet.Min ,3))}"); 
        }
    }
}
