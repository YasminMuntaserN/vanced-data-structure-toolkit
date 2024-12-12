using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /*
        Flight Seat Reservations
        Problem: Store seat availability for multiple flights where each flight has a different number of seats.
   */
    public class Q5
    {
        public static void Question()
        {
            Random random = new Random();

            string[][] jaggedArray = new string[4][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {

                int days = random.Next(1, 7); 
                jaggedArray[i] = new string[days];

                for (int j = 0; j < days; j++)
                {
                    jaggedArray[i][j] = random.Next(0, 2) == 1 ? "available" : "unavailable"; 
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($" Flight {i + 1}  with Seats  count  {jaggedArray[i].Length}: {String.Join(" , ",jaggedArray[i])}");
            }

        }
    }
}