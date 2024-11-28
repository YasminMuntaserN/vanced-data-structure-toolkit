using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
            Ticketing System Simulation
            Problem: Simulate a ticketing system where customers are served in the order they arrive. When a customer’s ticket is processed, the next ticket is queued for service.
            Output:
            Ticket 101 issued.
            Ticket 102 issued.
            Ticket 103 issued.
            Ticket 104 issued.
            Ticket 105 issued.

            Ticketing System Simulation Started...
            Processing Ticket: 101
            Remaining Tickets: 102, 103, 104, 105
            Processing Ticket: 102
            Remaining Tickets: 103, 104, 105
            Processing Ticket: 103
            Remaining Tickets: 104, 105
            Processing Ticket: 104
            Remaining Tickets: 105
            Processing Ticket: 105
            No more tickets in the queue.

            Ticketing System Simulation Ended.
     
     
     */

    public static class QueueExtensions
    {
        // Extension method to add new ticket and print issuance
        public static void AddNew(this Queue<int> que, int Value)
        {
            que.Enqueue(Value);
            Console.WriteLine($"Ticket {Value} issued.");
        }
    }
    public class Q06
    {
        public static void Question()
        {
            Queue<int> Tickets = new Queue<int>();

            Tickets.AddNew(101);
            Tickets.AddNew(102);
            Tickets.AddNew(103);
            Tickets.AddNew(104);
            Tickets.AddNew(105);

            Console.WriteLine($" Ticketing System Simulation Started....");

            while (Tickets.Count > 0)
            {
                Console.WriteLine($"Processing Ticket: {Tickets.Dequeue()} ");
                Console.WriteLine(Tickets.Count != 0 ? $" Processing Ticket: {string.Join(" , ", Tickets)} "
                                                     : " No more tickets in the queue.");
            }
            Console.WriteLine(" Ticketing System Simulation Ended..");
        }
     
    }
}
