using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
    Find Smallest and Largest Element
    Problem: Find the smallest and largest element in a SortedSet.

    Example:
    Input: [4, 2, 5, 1, 3]
    Output: Smallest: 1, Largest: 5


    Key Points:
    Use Min and Max properties.
     */
    public class Q02
    {
        public static (int, int) ElementsInRange(int[] arr)
        {
            SortedSet<int> result = new SortedSet<int>(arr);
            return (result.Min, result.Max);
        }

        public static void Question()
        {
            (int, int) result = ElementsInRange(new int[] { 4, 2, 5, 1, 3 });
            Console.WriteLine($"Min = {result.Item1}, Max = {result.Item2}"); 
        }
    }
}
