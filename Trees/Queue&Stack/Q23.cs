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
        Problem: Clone a queue such that the original queue remains unchanged.

        Example:
        Input: Queue = [1, 2, 3, 4]
        Output: Clone = [1, 2, 3, 4]

        Key Points:
        Use recursion to clone the queue while keeping the original intact.
    */
    public class Q23
    {
        private static Queue<int> CloneQueue(Queue<int> originalQueue , Queue<int> _CloneQueue)
        {
            if ( originalQueue.Count == 0)
                return _CloneQueue;

            _CloneQueue.Enqueue(originalQueue.Dequeue());
            return CloneQueue(originalQueue , _CloneQueue);  

        }
        public static void Question()
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });
            Queue<int> _CloneQueue = new Queue<int>();

            Console.WriteLine($"Original Queue: {string.Join(",", queue)}");
            /*
             Instead of modifying the original queue during recursion,
             I am passing a copy of the original queue (new Queue<int>(queue)).
             This ensures the original queue remains unchanged 
             */
            CloneQueue(new Queue<int>(queue), _CloneQueue);

            Console.WriteLine($"Cloned Queue: {string.Join(",", _CloneQueue)}");

            Console.WriteLine($"Original Queue After Cloning: {string.Join(",", queue)}");
        }
    }
}