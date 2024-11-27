using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
     Sort elements in a queue in ascending order.
    Example:
    Input: Queue = [5, 1, 3, 2, 4]
    Output: Queue = [1, 2, 3, 4, 5]
     */
    public class Q14
    {
        public static void Question()
        {
            Queue<int> QueueNumbers = new Queue<int>(new[] { 5, 1, 3, 2, 4 });
            List<int> list = new List<int>(QueueNumbers);
            list.Sort();
            Queue<int> SortedQueue = new Queue<int>(list);


            Console.WriteLine($"Original Queue: {string.Join(" ,", QueueNumbers)}");
            Console.WriteLine($"Reversed Queue: {string.Join(" ,", SortedQueue)}");
        }
    }
}
