using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
        User Survey Results
        Task: Store the responses of 5 questions (Yes/No) for a survey of 10 users.
     */
    public class Q2
    {
        static BitArray generateSurveyResponses()
        {
            Random random = new Random();
            BitArray surveyResponses = new BitArray(5);
            for (int i = 0; i < surveyResponses.Count; i++)
            {
                surveyResponses[i] = random.Next(2) == 1;
            }
           return surveyResponses;
        }


        static void PrintAnswers(BitArray bits)
        {
            for (int i = 0; i < bits.Count; i++)
            {
                Console.Write($"{(bits[i] ? "Yes" : "No")}\t");
            }
        }

        public static void Question()
        {
            BitArray bits = new BitArray(10);

            for (int i = 0; i < bits.Count; i++)
            {
                BitArray surveyResponses = generateSurveyResponses();
                Console.Write($"\n User {i + 1}  :  ");
                PrintAnswers(surveyResponses);
            }

        }
    }
}
