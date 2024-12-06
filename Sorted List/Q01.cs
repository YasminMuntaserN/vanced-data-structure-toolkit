using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_List
{
    /*
     Problem: Find all elements in a SortedSet within a given range [low, high].

    Example:
    Input: set = [1, 2, 3, 4, 5], low = 2, high = 4
    Output: [2, 3, 4]

    Key Points:
    Use GetViewBetween to get a subset within the range.
     
     */
    public class Q01
    {
        public static List<int> ElementsInRange(int []arr ,int low, int high)
          => new SortedSet<int>(arr).GetViewBetween(low, high).ToList();  
      
        public static void Question()
        {
            Console.WriteLine(string.Join(", ", ElementsInRange(new int[] { 1, 2, 3, 4, 5 } ,2,4)));
        }
    }
}
