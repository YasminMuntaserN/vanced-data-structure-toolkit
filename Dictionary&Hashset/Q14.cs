using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Find Words That Can Be Typed Using One Row of Keyboard

        Problem: Return all words that can be typed using one row of a QWERTY keyboard.

        Example:
        Input: ["Hello", "Alaska", "Dad", "Peace"]
        Output: ["Alaska", "Dad"]

     */
    public class Q14
    {
        private static bool CheckIfSameRow(string word)
        {
            Dictionary<char, int> keyboardRows = new Dictionary<char, int>()
        {
            {'Q', 1}, {'W', 1}, {'E', 1}, {'R', 1}, {'T', 1}, {'Y', 1}, {'U', 1}, {'I', 1}, {'O', 1}, {'P', 1},
            {'A', 2}, {'S', 2}, {'D', 2}, {'F', 2}, {'G', 2}, {'H', 2}, {'J', 2}, {'K', 2}, {'L', 2},
            {'Z', 3}, {'X', 3}, {'C', 3}, {'V', 3}, {'B', 3}, {'N', 3}, {'M', 3}
        };

            if (string.IsNullOrWhiteSpace(word))
                return false;

            int firstRow = keyboardRows[char.ToUpper(word[0])];

            return word.All(c => keyboardRows[char.ToUpper(c)] == firstRow);
        }

        public static void Question()
        {
            string[] words = { "Hello", "Alaska", "Dad", "Peace" };
            var oneRowWords = words.Where(word => CheckIfSameRow(word)).ToList();

            Console.WriteLine($"Words that can be typed using one row: {string.Join(", ", oneRowWords)}");
        }
    }
}
