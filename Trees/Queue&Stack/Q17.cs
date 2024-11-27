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
        Problem: Merge two sorted queues into a single sorted queue.

        Example:
        Input: Queue1 = [1, 3, 5], Queue2 = [2, 4, 6]
        Output: Merged Queue = [1, 2, 3, 4, 5, 6]

        Key Points:
        Use two queues and merge their elements in sorted order.
        Compare the front elements and enqueue the smaller one.
     */
    public class Q17
    {
        public static void Question()
        {
            Queue<int> QueueNumbers1 = new Queue<int>(new[] { 1, 3, 5 });
            Queue<int> QueueNumbers2 = new Queue<int>(new[] { 2, 4, 6 });
            List<int> list = QueueNumbers1.Concat(QueueNumbers2).ToList();
            Console.WriteLine($"List : {string.Join(" ,", list)}");

             list.Sort();
            Queue<int> result = new Queue<int>(list);


            Console.WriteLine($"Sorted Queue: {string.Join(", ", result)}");


        }
    }
}
