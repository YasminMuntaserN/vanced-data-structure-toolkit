using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
    Check If Set Contains Multiple Ranges
    Problem: Check if a SortedSet contains elements from multiple specified ranges.

    Example:
    Input: set = [1, 2, 3, 4, 5], ranges = [(1, 2), (4, 5)]
    Output: True


    Key Points:
    Use GetViewBetween for each range and check if all elements exist.
    */
    public class Q11
    {
     /* public static bool ContainsAllRanges(SortedSet<int> set, (int, int)[] Ranges)
        {
            foreach (var range in Ranges)
            {
                if (set.GetViewBetween(range.Item1, range.Item2).Count == 0) return false;
            }
            return true;
        }*/
       public static bool ContainsAllRanges(SortedSet<int> set, (int, int)[] Ranges)
        =>Ranges.All(range => set.GetViewBetween(range.Item1, range.Item2).Count > 0);
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{ContainsAllRanges(sortedSet, new (int, int)[] { (1, 2), (4, 5) })}"); 
        }
    }
}
