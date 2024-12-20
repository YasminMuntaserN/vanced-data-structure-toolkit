using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
     Convert a BitArray to an Integer
    Description:
    Write a function to convert a BitArray (representing binary digits) into an integer.
     */
    public class Q11
    {
        
        static int Integer(BitArray bits)
        {
            int result = 0;

            for (int i = 0; i < bits.Length; i++)
            {
                // result += bits[i] ? (int)Math.Pow(2 ,i) : 0;
                result += bits[i] ? 1 << i : 0;
            }

            return result;
        }
        public static void Question()
        {
            BitArray bits1 = new BitArray(new bool[] { true, false, true, false });
            Console.WriteLine(string.Join(" ", bits1.Cast<bool>().Select(b => b ? '1' : '0')));
            Console.WriteLine($"= {Integer(bits1)}");


            BitArray bits2 = new BitArray(new bool[] { true, true, true, false });
            Console.WriteLine(string.Join(" ", bits2.Cast<bool>().Select(b => b ? '1' : '0')));
            Console.WriteLine($"= {Integer(bits2)}");

        }
    }
}
