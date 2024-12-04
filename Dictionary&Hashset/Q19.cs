using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Determine if two arrays have no common elements.

        Example:
        Input: nums1 = [1, 2, 3], nums2 = [4, 5, 6]
        Output: True

        Key Points:
        Use a HashSet to check for common elements.
     */
    public class Q19
    {
        private static bool HaveNoCommonElements(int[] nums1, int[] nums2)
          =>!nums1.Any(num => new HashSet<int>(nums2).Contains(num));
      
        public static void Question()
        {
            Console.WriteLine($"{HaveNoCommonElements(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 })}");
        }
    }
}
