using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
        Problem: Find the middle element of a queue without modifying it.

        Example:
        Input: Queue = [1, 2, 3, 4, 5]
        Output: 3

        Key Points:
        Use a list to access the middle index.
    */
    public class Q24
    {
        private static int Middle(Queue<int> queue) => new List<int>(queue)[queue.Count / 2];

        public static void Question()
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            Console.WriteLine($" Queue: {string.Join(",", queue)}");

            Console.WriteLine($" Middle Index.: {Middle(queue)}");

            Console.WriteLine($"Original Queue After get Middle Index to Ensure that it not modifying : {string.Join(",", queue)}");
        }
    }
}