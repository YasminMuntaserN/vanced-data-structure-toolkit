using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Find the length of the longest consecutive sequence in an array.

        Example:
        Input: [100, 4, 200, 1, 3, 2]
        Output: 4 (sequence: [1, 2, 3, 4])
     */
    public class Q10
    {
        private static (int, List<int>) LongestConsecutive(int[] arr)
        {
            HashSet<int> hs = new HashSet<int>(arr.OrderBy(x => x));
            List<int> longestSequence = new List<int>();
            int longestStreak = 0;

            foreach (var item in hs)
            {
                if (!hs.Contains(item - 1))
                {
                    int currentNum = item;
                    List<int> currentSequence = new List<int> { currentNum };

                    while (hs.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentSequence.Add(currentNum);
                    }

                    if (currentSequence.Count > longestStreak)
                    {
                        longestStreak = currentSequence.Count;
                        longestSequence = new List<int>(currentSequence);
                    }
                }
            }

            return (longestStreak, longestSequence);
        }

        public static void Question()
        {
            (int, List<int>) result = LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });
            Console.WriteLine($" {result.Item1} Sequence: [{string.Join(", ", result.Item2)}]");
        }
    }
}
