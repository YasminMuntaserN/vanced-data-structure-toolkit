using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


//Simulate a web server that processes requests in the order they arrive.
namespace Queue_Stack{
    public class Q10
    {
        private static Queue<string> Requests = new Queue<string>();

        private static void InitializeRequests()
        {
            for (int i = 0; i < 4; i++)
            {
                Requests.Enqueue($"Request {i + 1}");
            }
        }

        public static void Question()
        {
            InitializeRequests();
            Console.WriteLine("Request Process started...\n");

            while (Requests.Count > 0)
            {
                Console.WriteLine($"Requesting: {Requests.Dequeue()}");

                Console.WriteLine(Requests.Count > 0 ?
                    "Remaining Requests: " + string.Join(", ", Requests) + "\n" :
                    "No more Requests left.\n");

                Thread.Sleep(2000);

            }
            Console.WriteLine("Request Process ended.");
        }
    }
}