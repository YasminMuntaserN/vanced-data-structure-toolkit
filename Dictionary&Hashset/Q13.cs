using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Find All Unique Elements
        Problem: Return all unique elements from an array.

        Example:
        Input: [1, 2, 2, 3, 4, 5, 3]
        Output: [1, 4, 5]
     */
    public class Q13
    {
        private static Dictionary<int, int> CountFrequency(int[] num) =>
              num.GroupBy(ch => ch).ToDictionary(g => g.Key, g => g.Count());
    
        public static void Question()
        {
            var majorityElement = CountFrequency(new int[] { 1, 2, 2, 3, 4, 5, 3 })
                         .Where(g => g.Value == 1)
                         .Select(g => g.Key).ToList();

            Console.WriteLine($" unique elements : {string.Join(" ," , majorityElement)}");
        }
    }
}
