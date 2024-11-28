using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    //Implement undo functionality in a calculator.
    public class Q03
    {
        public static void Question() {
            Stack<string> Operations = new Stack<string>();

            Operations.Push("Operation1");
            Operations.Push("Operation2");
            Operations.Push("Operation3");

            Console.WriteLine($" Now you will make  undo to this operation:{Operations.Peek()}  ");
            Operations.Pop();
            Console.WriteLine($"The previous operation:{Operations.Peek()}  ");
        }
     
    }
}
