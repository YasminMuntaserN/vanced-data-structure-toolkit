using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    //Use a queue to manage printer jobs.
    public class Q04
    {
        public static void Question() {
            Queue<string> jobs = new Queue<string>();

            jobs.Enqueue("Jop1");
            jobs.Enqueue("Jop2");
            jobs.Enqueue("Jop3");

            while (jobs.Count > 0)
            {
                Console.WriteLine($"Printing: {jobs.Dequeue()}");
            }
            Console.WriteLine("All jobs processed.");
        }
     
    }
}
