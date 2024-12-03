using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Identify duplicate elements in an array.

        Example:
        Input: [1, 2, 3, 4, 2, 5, 6, 1]
        Output: [1, 2]
     */
    public class Q12
    {
        private static Dictionary<int, int> CountFrequency(int[] num) =>
              num.GroupBy(ch => ch).ToDictionary(g => g.Key, g => g.Count());
    
        public static void Question()
        {
            var duplicateElement = CountFrequency(new int[] { 1, 2, 3, 4, 2, 5, 6, 1 })
                         .Where(g => g.Value == 2)
                         .Select(g => g.Key).ToList();

            Console.WriteLine($"Duplicate elements: {string.Join(" ,", duplicateElement)}");
        }
    }
}
