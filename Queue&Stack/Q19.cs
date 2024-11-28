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
    Problem: Implement a queue using two stacks.
    Example:
    Operations: Enqueue(1), Enqueue(2), Dequeue(), Dequeue()
    Output: 1 , 2

    Key Points:
    Use one stack to store incoming elements and the other for dequeuing.
 */

    public class QueueWithTwoStacks
    {
        private Stack<int> inbox = new Stack<int>();
        private Stack<int> outbox = new Stack<int>();

        public void Enqueue(int x)
        {
            inbox.Push(x);
        }

        public int Dequeue()
        {
            while (inbox.Count > 0)
            {
                outbox.Push(inbox.Pop());
            }

            return outbox.Pop();
        }
    }
    public class Q19
    {

        public static void Question()
        {
            QueueWithTwoStacks queue = new QueueWithTwoStacks();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
 }
