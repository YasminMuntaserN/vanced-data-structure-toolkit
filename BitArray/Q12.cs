using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bit_Array
{
    /*
        Create a BitArray from an Integer
        Description: Write a function that takes an integer and returns a BitArray representing its binary digits.
     */
    public class Q12
    {
        
        static BitArray Binary(int num)
        {
            /* BitArray bits = new BitArray(8); 
             int i = 0;

             while (num > 0)
             {
                 bits[i] = (num & 1) == 1;
                 num >>= 1; 
                 i++;
             }

             return bits;*/
            return new BitArray(new[] { num });
        }
        public static void Question()
        {
            BitArray bits1 = Binary(5);
            Console.WriteLine($"{5} ={string.Join(" ", bits1.Cast<bool>().Select(b => b ? '1' : '0'))}");


            BitArray bits2 = Binary(7);
            Console.WriteLine($"{7} ={string.Join(" ", bits2.Cast<bool>().Select(b => b ? '1' : '0'))}");

        }
    }
}
