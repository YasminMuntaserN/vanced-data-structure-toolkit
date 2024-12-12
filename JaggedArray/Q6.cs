using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    /*
        Survey Responses
        Problem: Store survey responses where each respondent answers a different number of questions.
   */
    public class Q6
    {
        public static void Question()
        {
            Random random = new Random();

            bool[][] jaggedArray = new bool[4][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {

                int days = random.Next(1, 7); 
                jaggedArray[i] = new bool[days];

                for (int j = 0; j < days; j++)
                {
                    jaggedArray[i][j] = random.Next(0,2)==1 ? true :false; 
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"\n Respondent {i + 1} (Questions answered: {jaggedArray[i].Length}) results :\n {String.Join(" , ",jaggedArray[i])}");
            }

        }
    }
}