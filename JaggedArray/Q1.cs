using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    public class Q1
    {
        public static void Question()
        {
            int[][] jaggedArray = {
            new int[] { 90, 85, 88},
            new int[] { 76, 80},
            new int[] { 92, 93, 89, 85 }
        };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"\n Student {i+1} Marks :");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+ "  ");
                }
            }
        }
    }
}
