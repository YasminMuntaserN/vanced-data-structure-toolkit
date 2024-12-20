using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
        Count the Number of True Bits / False Bits in a BitArray
       Description:Write a function to count the number of true values and false values in a BitArray.
    */
    /* public class Q9
    {
       static (int TrueCount , int FalseCount) Count(BitArray bits)
        {
            int TrueCount =0 ,  FalseCount= 0;

            for (int i = 0; i < bits.Count; i++)
                if (bits[i]) TrueCount++; else FalseCount++;
            
            return (TrueCount, FalseCount);
        }
        public static void Question()
        {
            BitArray bits = new BitArray(8);
           
            Random random = new Random();

            for (int i = 0; i < bits.Count; i++)
                bits[i] = random.Next(0, 2) == 1;

            var result = Count(bits);
            Console.WriteLine($"the number of True : {result.TrueCount} ,False :{result.FalseCount} ");
        }*/


    public class Q09()
    {
        public static void Question()
        {
            BitArray bits = new BitArray(8);
            Random random = new Random();

            for (int i = 0; i < bits.Count; i++)
                bits[i] = random.Next(0, 2) == 1;

            int trueCount = bits.Cast<bool>().Count(b => b);
            int falseCount = bits.Count - trueCount;

            Console.WriteLine($"\nThe number of True: {trueCount}, False: {falseCount}");
        }
    }
}
