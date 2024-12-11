using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /*
     Problem: Store sales data for a company across different regions for various quarters.
        Example:
        Input:

        Region 1: [10000, 12000, 11000]
        Region 2: [15000, 16000]
        Region 3: [9000, 9500, 9800, 10200]
     
    Output: Display quarterly sales for each region.
     */

    public class Q2
    {
        public static void Question()
        {
            int[][] jaggedArray = {
            new int[] { 10000, 12000, 11000},
            new int[] {15000, 16000},
            new int[] { 9000, 9500, 9800, 10200 }
        };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"\n Region {i} :  ");
                Console.WriteLine(string.Join(", ", jaggedArray[i]));
            }
        }
    }
}
