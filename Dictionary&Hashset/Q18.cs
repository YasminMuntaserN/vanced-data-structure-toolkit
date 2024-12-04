using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Find all numbers missing from the range 1 to n in an array.

        Example:
        Input: [4, 3, 2, 7, 8, 2, 3, 1]
        Output: [5, 6]


        Key Points:
        Use a HashSet to track existing numbers.
     */
    public class Q18
    {
        private static List<int> FindMissingNumbers(int[] nums)
          => Enumerable.Range(1, nums.Length).Except(new HashSet<int>(nums)).ToList();

        public static void Question()
        {
            Console.WriteLine($" {string.Join(",", FindMissingNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }))}");
        }
    }
}
