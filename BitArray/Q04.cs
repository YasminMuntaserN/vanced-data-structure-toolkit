using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
        Scheduling Tasks
        Task: Represent a weekly schedule with BitArray (7 days). Check which days are free.
     */
    public class Q04
    {
        public static void Question()
        {
            List<string> weekDays = new List<string>
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
            Random random = new Random();
            BitArray bits = new BitArray(7);

            for (int i=0; i < bits.Count; i++)
            {
                bits[i]= random.Next(0,2)==1 ?true:false;
            }
            
            Console.WriteLine(" Scheduling Tasks :");
            
            for (int i = 0; i < bits.Count; i++)
            {
                Console.WriteLine($" {weekDays[i]} {(bits[i] ? "Free " : "Busy")}");
            }

        }

    }
}
