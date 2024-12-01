using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Count the frequency of each character in a string.

        Example:
        Input: "hello"
        Output: { 'h': 1, 'e': 1, 'l': 2, 'o': 1 }
     */
    public class Q09
    {
        private static Dictionary<char, int> CountFrequency(string word) =>
              word.GroupBy(ch => ch).ToDictionary(g => g.Key, g => g.Count());
    
        public static void Question()
        {
                Console.WriteLine(string.Join(" ", CountFrequency("hello")));
        }
    }
}
