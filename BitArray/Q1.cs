using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
     Light Control System
     Task: Represent the state of lights in a smart home system with 8 lights.
    Update the status of specific lights and turn all lights off at once.
     */
    public class Q1
    {
        static void PrintAll(BitArray bits)
        {
            Console.WriteLine("Light Status:");
            for (int i = 0; i < bits.Count; i++)
            {
                Console.WriteLine($"Light {i + 1}: {(bits[i] ? "ON" : "OFF")}");
            }
        }

        public static void Question()
        {
            BitArray bits = new BitArray(8);

            for (int i=0; i < bits.Count; i++)
            {
                if (i % 2 == 0)
                {
                    Task.Delay(1000).Wait();
                    bits[i] = true;
                }
            }
            PrintAll(bits);

            Console.WriteLine("\nTurning all lights ON...");
            bits.SetAll(true);

            PrintAll(bits);
        }

    }
}
