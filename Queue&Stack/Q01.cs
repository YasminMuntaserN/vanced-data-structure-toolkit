using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    //Use a stack to implement a browser's back button functionality.

    public class Q01
    {
        public static void Question()
        {
            Stack<string> Pages = new Stack<string>();

            Pages.Push("Page1");
            Pages.Push("Page2");
            Pages.Push("Page3");

            while (Pages.Count > 0)
            {
                Console.Write($" Now you Are in :{Pages.Peek()}  ");
                Pages.Pop();
                if(Pages.Count != 0) 
                Console.WriteLine($" The previous Page of it: {Pages.Peek()} ");
            }
            Console.WriteLine(" There is no more previous Pages");

        }
    }
}
