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
        Find Common Characters in Strings
        Problem: Find all common characters between multiple strings.

        Example:
        Input: ["bella", "label", "roller"]
        Output: ["e", "l", "l"]
     */
    public class Q16
    {
        private static List<Dictionary<char, int>> GetCharacterFrequencies(string[] words)
        {
            List<Dictionary<char, int>> list = new List<Dictionary<char, int>>();
            foreach (string word in words)
            {
                Dictionary<char, int> CharCount = word
                           .GroupBy(c => c)
                           .ToDictionary(g => g.Key, g => g.Count());
                list.Add(CharCount);
            }

            return list;
        }

        private static List<string> FindCommonCharacters(string[] words)
        {
            List<Dictionary<char, int>> charFrequencyList = GetCharacterFrequencies(words);

            List<string> result = new List<string>();

            foreach (var key in charFrequencyList[0].Keys)
            {
                int minFrequency = charFrequencyList.Min(dict => dict.ContainsKey(key) ? dict[key] : 0);

                for (int i = 0; i < minFrequency; i++)
                {
                    result.Add(key.ToString());
                }
            }

            return result;
        }
        public static void Question()
        {
            List<string> output = FindCommonCharacters(new string[] { "bella", "label", "roller" });
            Console.WriteLine($"Output: [{string.Join(", ", output)}]");
        }
    }
}