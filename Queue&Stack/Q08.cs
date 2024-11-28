using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Given a set of tasks with a specific order, simulate the order of execution using a queue.
namespace Queue_Stack
    {
        public class Q08
        {
            private static Queue<string> Tasks = new Queue<string>();

            private static void InitializeTasks()
            {
                for (int i = 0; i <4 ; i++)
                {
                    Tasks.Enqueue($"Task{i + 1}");  
                }
            }

            public static void Question()
            {
                 InitializeTasks();
                Console.WriteLine("Task execution started...\n");

                while (Tasks.Count > 0)
                {
                    Console.WriteLine($"Processing: {Tasks.Dequeue()}");  

                    Console.WriteLine(Tasks.Count > 0 ?
                        "Remaining Tasks: " + string.Join(", ", Tasks) + "\n" :
                        "No more tasks left.\n");
                }

                Console.WriteLine("Task execution ended.");
            }
        }
    }
