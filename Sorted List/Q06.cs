using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
        Problem: Count the number of elements greater than a given value in a SortedSet.

        Example:
        Input: set = [1, 2, 3, 4, 5], value = 3
        Output: 2


        Key Points:

        Use GetViewBetween to create a subset.
     */
    public class Q06
    {
        public static int ElementsGreaterThanValue(SortedSet<int> set, int value)
           =>set.GetViewBetween( value+1 , set.Max).ToList().Count();
        public static void Question()
        {
            SortedSet<int> sortedSet = new SortedSet<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine($"{ElementsGreaterThanValue(sortedSet ,3)}"); 
        }
    }
}
