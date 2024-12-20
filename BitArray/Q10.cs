using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
     Perform Bitwise AND Between Two BitArrays
     Description:
    Write a function that takes two BitArray objects of equal length and returns a new BitArray that is the result of a bitwise AND operation.
     */
    public class Q10
    {
        public static void Question()
        {
            BitArray bits1 = new BitArray(new bool[] { true, false, true, false });
            BitArray bits2 = new BitArray(new bool[] { true, true, true, false });

            BitArray result = bits1.And(bits2);

            Console.WriteLine(string.Join(" ", bits1.Cast<bool>().Select(b => b ? '1' : '0')));
            Console.WriteLine(string.Join(" ", bits2.Cast<bool>().Select(b => b ? '1' : '0')));
            Console.WriteLine("-------------------");
            Console.WriteLine(string.Join(" ", result.Cast<bool>().Select(b => b ? '1' : '0')));
        }
    }
}
