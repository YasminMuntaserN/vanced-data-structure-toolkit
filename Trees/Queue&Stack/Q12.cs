using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
        Problem: Check if a queue is a palindrome (same forwards and backwards).

        Example:
        Input: Queue = [1, 2, 3, 2, 1]
        Output: True
     */
    public class Q12
    {
        public static void Question()
        {
            Queue<int> QueueNumbers = new Queue<int>(new[] { 1, 2, 3, 2, 1 });

            Stack<int> StackNumbers = new Stack<int>(QueueNumbers);

            Console.WriteLine($"Original Queue: {string.Join(" ,", QueueNumbers)}");
            Console.WriteLine($"Reversed Queue: {string.Join(" ,", StackNumbers)}");

            Console.WriteLine($"IsPalindromeQueue: {QueueNumbers.All(q => q == StackNumbers.Pop())}");
        }
    }
}
