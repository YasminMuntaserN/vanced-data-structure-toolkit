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
        Problem: Implement a priority queue where elements with higher priority are dequeued first.

        Example:
        Input: Enqueue(10, 1), Enqueue(5, 3), Enqueue(20, 2), Dequeue()
        Output: 5 (highest priority first)

        Key Points:
        Use a sorted data structure like a SortedList or a SortedDictionary to maintain priorities.
        Dequeue elements based on the priority value.
    */

    public class PriorityQueue
    {
        SortedList<int, Queue<int>> priorityQueue = new SortedList<int, Queue<int>>();


        public void Enqueue(int data, int value)
        {
            if (!priorityQueue.ContainsKey(value))
            {
                priorityQueue[value] = new Queue<int>();
            }
            priorityQueue[value].Enqueue(data);
        }

        public int Dequeue()
        {


            if (priorityQueue.Count == 0)
                return 0;

            var highestPriority = priorityQueue.First();

            Console.WriteLine($"[{string.Join(",", highestPriority.Value)}] " +
                                $",{string.Join(",", highestPriority.Key)} ");

            int dequeuedValue = highestPriority.Value.Dequeue();

            if (highestPriority.Value.Count == 0)
            {
                priorityQueue.Remove(highestPriority.Key);
            }

            return dequeuedValue;
        }
    }
    public class Q21
    {

        public static void Question()
        {
            PriorityQueue queue = new PriorityQueue();

            queue.Enqueue(6, 2);
            queue.Enqueue(3, 1);
            queue.Enqueue(8, 2);
            queue.Enqueue(10, 1);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}