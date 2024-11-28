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
        Problem: Rearrange a queue such that all even numbers appear before odd numbers while maintaining their order.

        Example:
        Input: Queue = [1, 2, 3, 4, 5,6]
        Output: Queue = [2, 4, 6, 1, 3, 5]


        Key Points:

        Use two additional queues to separate even and odd elements.
        Combine them back into the original queue.
 */
    public class Q22
    {
        /*   private static Queue<int> SpletingQueue(Predicate<int> operation, Queue<int> orginalQueue)
           {
               Queue<int> queue = new Queue<int>();

               foreach (int item in orginalQueue)
               {
                   if (operation(item))
                       queue.Enqueue(item);
               }
               return queue;
           }

           public static void Question()
           {
               Queue<int> queue = new Queue<int>([1, 2, 3, 4, 5, 6]);

               Queue<int> OddQueue = SpletingQueue(x => x % 2 != 0, queue);
               Queue<int> EvenQueue = SpletingQueue(x => x % 2 == 0, queue);

               queue = new Queue<int>(EvenQueue.Concat(OddQueue));

               Console.WriteLine($"{string.Join(",", queue)}");
           }
       }
        */
       
        private static Queue<int> RearrangeQueue(Queue<int> originalQueue)
        {
            Queue<int> evenQueue = new Queue<int>();
            Queue<int> oddQueue = new Queue<int>();

            foreach (int item in originalQueue)
            {
                if (item % 2 == 0)
                    evenQueue.Enqueue(item);
                else
                    oddQueue.Enqueue(item);
            }

            return new Queue<int>(evenQueue.Concat(oddQueue));
        }

        public static void Question()
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            queue = RearrangeQueue(queue);

            Console.WriteLine($"{string.Join(",", queue)}");
        }
    }
}