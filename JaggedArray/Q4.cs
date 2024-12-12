using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /*
  Daily Sales for Different Products
  Problem: Store the sales for different products, where each product has varying daily sales.
   */
    public class Q4
    {
        public static void Question()
        {
            string[] productNames = { "Laptop", "Smartphone", "Headphones", "Camera", "Tablet" };
            Random random = new Random();

            int[][] jaggedArray = new int[productNames.Length][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {

                int days = random.Next(1, 7); 
                jaggedArray[i] = new int[days];

                Console.WriteLine($" \n{productNames[i]} (Sales for {days} days):");
                for (int j = 0; j < days; j++)
                {
                    jaggedArray[i][j] = random.Next(100, 1000);
                    Console.WriteLine($"   Day {j + 1}: ${jaggedArray[i][j]}");
                }
            }

            Console.WriteLine("\n Overall Sales Summary ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($" Product {i + 1} : {jaggedArray[i].Sum():c} ");
            }

        }
    }
}