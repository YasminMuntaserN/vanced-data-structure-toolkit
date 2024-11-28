using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
            Simulate vehicles waiting at a traffic signal.
            Vehicles are processed in the order they arrive (FIFO), and after processing, the next vehicle moves up.
            Vehicles arrive in the following order:
            "Car 1";
            "Truck 1"
            "Bike 1"
            "Bus 1"

            Traffic Signal Simulation Started...
            Car 1 has passed the signal.
            Vehicles waiting: Truck 1, Bike 1, Bus 1
            Truck 1 has passed the signal.
            Vehicles waiting: Bike 1, Bus 1
            Bike 1 has passed the signal.
            Vehicles waiting: Bus 1
            Bus 1 has passed the signal.
            No vehicles waiting.
            Traffic Signal Simulation Ended.
     
     
     */
    public class Q05
    {
        public static void Question() {
            Queue<string> vehicles = new Queue<string>();

            vehicles.Enqueue("Car 1");
            vehicles.Enqueue("Truck 1");
            vehicles.Enqueue("Bike 1");
            vehicles.Enqueue("Bus 1");

            Console.WriteLine($"Traffic Signal Simulation Started...");

            while (vehicles.Count > 0)
            {
                Console.WriteLine($"{vehicles.Dequeue()} has passed the signal.");
                Console.WriteLine(vehicles.Count != 0 ? $"has passed the signal {string.Join(" , ", vehicles)} " :"No vehicles waiting.");
            }
            Console.WriteLine("Traffic Signal Simulation Ended..");
        }
     
    }
}
