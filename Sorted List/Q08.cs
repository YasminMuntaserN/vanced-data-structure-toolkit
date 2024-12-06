using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
    Problem: Find all elements in a SortedSet that are outside a given range [low, high].

    Example:
    Input: set = [1, 2, 3, 4, 5], range = [2, 4]
    Output: [1, 5]


    Key Points:
    Use GetViewBetween and remove the range from the set.
    */
    public class Q08
    {
        public static List<int> RemoveInSpecifiedRange(SortedSet<int> set, (int value1, int value2) Range)
        {
            var list = set.GetViewBetween( Range.value1 , Range.value2);
            return set.Where(x=>!list.Contains(x)).ToList();
            // return set.Except(inRange).ToList();
        }
      
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            var list= RemoveInSpecifiedRange(sortedSet, (2, 4));
            Console.WriteLine($"{string.Join(" , ",list )}"); 
        }
    }
}
