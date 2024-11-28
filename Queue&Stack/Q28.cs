using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
     Problem: Evaluate a postfix expression using a stack.

    Example:
    Input: "231*+9-"
    Output: -4

    Key Points:
    Push numbers onto the stack.
    Perform operations using the top two elements for each operator.
     
     */
    public class Q28
    {
        private static int EvaluatePostfix(string s)
        {
             Dictionary<char, Func<int, int, int>> operations = new Dictionary<char, Func<int, int, int>>()
             {
                { '+', (a, b) => a + b },
                { '-', (a, b) => a - b },
                { '*', (a, b) => a * b },
                { '/', (a, b) => a / b }
             };

        Stack<int> stack = new Stack<int>();

            foreach (char c in s)
            {
                if (operations.ContainsKey(c))
                {
                    int b = stack.Pop();  
                    int a = stack.Pop(); 
                    stack.Push(operations[c](a, b));
                }
                else
                    stack.Push(int.Parse(c.ToString()));
            }

            return stack.Pop();
        }
        public static void Question()
        {
            Console.WriteLine($"231*+9- : {EvaluatePostfix("231*+9-")}");
        }
    }
}
