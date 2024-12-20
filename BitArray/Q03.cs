using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
        Optimizing Space in Large Data
        Task: Use BitArray to track which seats (1,000 seats) in a theater are booked.
     */
    public class Q03
    {
        static void DisplaySeatStatuses(BitArray seats)
        {
            Console.WriteLine("Seat Booking Statuses:");
            for (int i = 0; i < seats.Count; i++)
            {
                Console.WriteLine($"Seat {i + 1}: {(seats[i] ? "Booked" : "Available")}");
            }
        }

        public static void Question()
        {
             BitArray seats = new BitArray(1000, false);


            seats[0] = true; 
            seats[100] = true;
            seats[20] = true; 
            seats[330] = true; 
            seats[500] = true;
            seats[900] = true;

            DisplaySeatStatuses(seats);
        }

    }
}
