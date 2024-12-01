using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Find the majority element in an array (element appearing more than n/2 times).

        Example:
        Input: [3, 2, 3]
        Output: 3

        Key Points:

        Use a dictionary to count frequencies.
     */
    public class Q11
    {
        private static Dictionary<int, int> CountFrequency(int[] num) =>
              num.GroupBy(ch => ch).ToDictionary(g => g.Key, g => g.Count());
    
        public static void Question()
        {
            int[] arr = new int[] { 3, 2, 3 };
            var majorityElement = CountFrequency(arr)
                         .Where(g => g.Value > arr.Length / 2)
                         .Select(g => g.Key)
                         .FirstOrDefault();

            Console.WriteLine($"Majority Element: {majorityElement}");
        }
    }
}
