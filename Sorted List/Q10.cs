using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
    Problem: Count the number of elements in a SortedSet less than or equal to a given value.

    Example:
    Input: set = [1, 2, 3, 4, 5], value = 3
    Output: 3

    Key Points:
    Use GetViewBetween and check the size of the subset.
    */
    public class Q10
    {
        public static int CountNumberLessValue(SortedSet<int> set, int value)
            => set.GetViewBetween(set.Min, value).ToList().Count();
      
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{CountNumberLessValue(sortedSet,3)}"); 
        }
    }
}
