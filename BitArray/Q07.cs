using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
        Traffic Light Simulation
        Task: Use a BitArray to represent the state of traffic lights at 3 intersections (Red, Yellow, Green). Change the light for one intersection.
    */
    public class Q07
    {
        static void PrintTrafficLight(BitArray lights)
        {
            List<string> colors = new List<string>
            {
                "Red",
                "Yellow",
                "Green"
            };

            for (int i = 0; i < lights.Count; i++)
            {
                Console.WriteLine($"{colors[i],-7} : {(lights[i] ? "ON" : "OFF")}");
            }
        }

        public static void Question()
        {
            BitArray trafficLights = new BitArray(3);
            List<string> actions = new List<string> { "Stop", "Ready", "Go" };

            for (int i = 0; i < trafficLights.Count; i++)
            {
                Console.WriteLine($"\n********** {actions[i]} **********");

                trafficLights.SetAll(false);  
                Task.Delay(1000).Wait();      
                trafficLights[i] = true;      

                Console.WriteLine("Traffic Light State:");
                PrintTrafficLight(trafficLights);
            }
        }
    }
}