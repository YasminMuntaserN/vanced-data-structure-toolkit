using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;


//Simulate a customer service system where customers are served in the order they arrive
namespace Queue_Stack
    {
    public class Q09
    {
        private static Queue<string> customers = new Queue<string>();

        private static void InitializeCustomers()
        {
            for (int i = 0; i < 4; i++)
            {
                customers.Enqueue($"Customer {i + 1}");
            }
        }

        public static void Question()
        {
            InitializeCustomers();
            Console.WriteLine("Service Process started...\n");

            while (customers.Count > 0)
            {
                Console.WriteLine($"Serving: {customers.Dequeue()}");

                Console.WriteLine(customers.Count > 0 ?
                    "Remaining customers: " + string.Join(", ", customers) + "\n" :
                    "No more customers left.\n");
            }
            Console.WriteLine("Service Process ended.");
        }
    }
}