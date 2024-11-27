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
          Problem: Rearrange elements in a queue alternately in increasing and decreasing order.

          Example:
          Input: Queue = [1, 2, 3, 4, 5, 6]
          Output: Queue = [1, 6, 2, 5, 3, 4]
          Key Points:

          Split the queue into two halves.
          Merge the halves alternately.
       */

    public class Q20
    {
        public static void Question()
        {
            Queue<int> Queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 });

            List<int> list1 = new List<int>(Queue.Take(Queue.Count / 2)).OrderBy(x => x).ToList();
            List<int> list2 = new List<int>(Queue.Skip(Queue.Count / 2)).OrderByDescending(x => x).ToList(); 

            Queue.Clear();
            for (int i = 0; i < list1.Count; i++)
            {
                Queue.Enqueue(list1[i]);
                Queue.Enqueue(list2[i]);
            }

            Console.WriteLine($"Rearranged Queue: {string.Join(" ,", Queue)}");
        }
    }

}
