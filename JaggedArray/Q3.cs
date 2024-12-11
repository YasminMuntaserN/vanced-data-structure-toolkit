using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /*
   * Dynamic Seating Arrangement in a Classroom
   Problem: Each row in a classroom has a different number of seats. Store the seating arrangement and access each seat dynamically.
   */
    public class Q3
    {
        public static void Question()
        {
            Random random = new Random();

            int[][] jaggedArray = new int[4][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {

                int seats = random.Next(1, 10); 
                jaggedArray[i] = new int[seats];

                for (int j = 0; j < seats; j++)
                {
                    jaggedArray[i][j] = j + 1; 
                }
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"\n class {i+1} :  ");
                Console.WriteLine(string.Join(", ", jaggedArray[i]));
            }

        }
    }
}