using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    //Convert a decimal number to binary using a stack.

    public class BinaryConversion
    {
        public int DecimalNumber { get; set; }
        public string BinaryDigit { get; set; }

        public override string ToString()
        {
            return $"Decimal: {DecimalNumber}, Binary digit: {BinaryDigit}";
        }
    }
    public class Q02
    {
        public static void Question()
        {
            int num = 255;
            Stack<Object> conversion = new Stack<Object>();

            Console.WriteLine($"Decimal number: {num}");
            while (num > 0)
            {
                conversion.Push(new BinaryConversion  { DecimalNumber = num, BinaryDigit = Convert.ToString(num % 10, 2) });
                num /= 10;
            }
            Console.WriteLine($"Binary representation: ");
            while (conversion.Count > 0)
            {
                Console.WriteLine(conversion.Pop().ToString());  
            }
        }
    }
}
