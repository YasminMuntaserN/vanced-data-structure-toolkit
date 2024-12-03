using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Find Missing Number in an Array
        Problem: Find the missing number in an array of size n containing numbers from 0 to n.

        Example:
        Input: [3, 0, 1]
        Output: 2

        Key Points:
        Use a dictionary to track presence of numbers.
     */
    public class Q15
    {
        private static int FindMissingNumber(int[] arr)
        {
            Dictionary<int, bool> numberPresence = arr.ToDictionary(x => x, x => true);

            for (int i = 0; i < arr.Length; i++)
            {
                if (!numberPresence.ContainsKey(i))
                {
                    return i; 
                }
            }
            return 0;
        }

        public static void Question()
        {
            var Missing = FindMissingNumber(new int[] { 3, 0, 1 });
            Console.WriteLine($"Missing Number : {Missing}");
        }
    }
}
