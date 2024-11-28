using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*Problem: Generate binary numbers from 1 to N using a queue.
        Example:
        Input: N = 5
        Output: ["1", "10", "11", "100", "101"]
    */
    public class Q13
    {

        private static Queue<string> InitializeBinaryNumbers(int n)
        {
            Queue<string> nums = new Queue<string>();

            for (int i = 1; i <= n; i++)
            {
                nums.Enqueue($"{Convert.ToString(i ,2)}");
            }
            return nums;
        }
        public static void Question()
        {
            Queue<string> nums = InitializeBinaryNumbers(5);
            Console.WriteLine($"[{string.Join(" , " , nums)}]");
        }
    }
}
