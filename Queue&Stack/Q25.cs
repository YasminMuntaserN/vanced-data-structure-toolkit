using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    public class Q25
    {
        /*
         Problem: Reverse a given string using a stack.
        Input: "hello"
        Output: "olleh"
        Key Idea: Push each character onto the stack, then pop them off to get the reversed string. 
         */

        private static string Reverse(string s)
        {
            Stack<char> stack = new Stack<char>(s);
            StringBuilder str = new();
            while (stack.Count > 0) str.Append(stack.Pop());

            return str.ToString();
        }
        private static string Reverse2(string s) =>
            string.Join("", new Stack<char>(s).Select(x => x.ToString()));
          


        public static void Question()
        {
            Console.WriteLine(Reverse("hello"));
            Console.WriteLine(Reverse2("hello"));

        }
    }
}
