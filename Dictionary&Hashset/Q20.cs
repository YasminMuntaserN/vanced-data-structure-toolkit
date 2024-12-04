using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Check if a sentence contains every letter of the English alphabet at least once.

        Example:

        Input: "The quick brown fox jumps over the lazy dog"
        Output: True

        Key Points:
        Use a HashSet to store unique letters.
     */
    public class Q20
    {
        private static bool IsPangram(string sentence)
           => new HashSet<char>(sentence.ToLower().Where(char.IsLetter)).Count == 26;
        public static void Question()
        {
            Console.WriteLine($"{IsPangram("The quick brown fox jumps over the lazy dog")}");
        }
    }
}
