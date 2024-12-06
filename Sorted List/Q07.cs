using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
    Problem: Remove all elements within a specified range from a SortedSet.

    Example:
    Input: set = [1, 2, 3, 4, 5], range = [2, 4]
    Output: [1, 5]

    Key Points:
    Use GetViewBetween and Clear to remove the range.
    */
    public class Q07
    {
        public static void RemoveInSpecifiedRange(SortedSet<int> set, (int value1 ,int value2) Range)
           =>set.GetViewBetween( Range.value1 , Range.value2).Clear();
      
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            RemoveInSpecifiedRange(sortedSet, (2, 4));
            Console.WriteLine($"{string.Join(" , ",sortedSet )}"); 
        }
    }
}
