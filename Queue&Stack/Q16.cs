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
        Problem: Rotate a queue by K positions.

        Example:
        Input: Queue = [1, 2, 3, 4, 5], K = 2
        Output: Queue = [3, 4, 5, 1, 2]
     */
    public class Q16
    {
        /* public static void Question()
         {
            int k = 2;
             Queue<int> QueueNumbers = new Queue<int>(new[] { 1, 2, 3, 4, 5});
            Console.WriteLine($"Original Queue: {string.Join(" ,", QueueNumbers)}");

            for (int i = 0; i < k; i++)
            {
                QueueNumbers.Enqueue(QueueNumbers.Dequeue());
            }

             Console.WriteLine($"Rotate a queue by K positions: {string.Join(" ,", QueueNumbers)}");
         }*/
        public static void Question()
        {
            int k = 2;
            Queue<int> QueueNumbers = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Original Queue: {string.Join(" ,", QueueNumbers)}");


            List<int> result = new List<int>(QueueNumbers);
            result  = result.Skip(k).Concat(result.Take(k)).ToList();
            foreach (var num in result)
            {
                QueueNumbers.Dequeue(); 
                QueueNumbers.Enqueue(num);
            }

            Console.WriteLine($"Rotate a queue by K positions: {string.Join(" ,", QueueNumbers)}");

        }
    }
}
