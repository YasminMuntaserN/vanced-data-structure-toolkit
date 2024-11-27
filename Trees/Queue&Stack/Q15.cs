using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
        Problem: Interleave the first half of a queue with the second half.

        Example:
        Input: Queue = [1, 2, 3, 4, 5, 6]
        Output: Queue = [1, 4, 2, 5, 3, 6]
     */
    public class Q15
    {
         public static void Question()
         {
             Queue<int> QueueNumbers = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
             Stack<int> StackNumbers1 = new Stack<int>(QueueNumbers.Take(QueueNumbers.Count/2));
             Stack<int> StackNumbers2 = new Stack<int>(QueueNumbers.Skip(QueueNumbers.Count / 2));
             Queue<int> result = new Queue<int>();


             while (StackNumbers1.Count > 0)
             {
                 result.Enqueue(StackNumbers2.Pop());
                 result.Enqueue(StackNumbers1.Pop());
             }
             Console.WriteLine($"Original Queue: {string.Join(" ,", QueueNumbers)}");
             Console.WriteLine($"First Stack: {string.Join(" ,", StackNumbers1)}");
             Console.WriteLine($"Secound Stack: {string.Join(" ,", StackNumbers2)}");
             Console.WriteLine($"result : {string.Join(" ,", result.Reverse())}");
         }
    }
}
