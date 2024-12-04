using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
    Problem: Find all elements in the first array that are not in the second array.

    Example:
    Input: nums1 = [1, 2, 3, 4], nums2 = [3, 4, 5, 6]
    Output: [1, 2]

    Key Points:
    Use a HashSet to store the second array's elements for quick lookups.
     */
    public class Q17
    {
        private static List<int> UniqeElement(int[] nums1 , int[] nums2)
          => nums1.Except(new HashSet<int>(nums2)).ToList();
        public static void Question()
        {
            var list = UniqeElement(new int[] { 1, 2, 3, 4 } , new int[] { 3, 4, 5, 6 });
            Console.WriteLine($" {string.Join(",",list ) }");
        }
    }
}
