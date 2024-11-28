using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
     Problem: Check if a given string has balanced parentheses.

    Input: "({[]})" or "({[)]}"
    Output: true for "({[]})" and false for "({[)]}"
    Key Idea: Use a stack to keep track of opening brackets and ensure they are closed in the correct order.
     */
    public class Q26
    {
        private static bool BalancedParentheses(string s)
        {
            Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            { '[', ']' },
            { '{', '}' },
            { '(', ')' }
        };
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s)
            {
                if (brackets.ContainsKey(ch))
                {
                    stack.Push(ch);
                }
                else if (brackets.ContainsValue(ch))
                {
                    if (stack.Count == 0 || brackets[stack.Pop()] != ch)
                        return false;
                }
            }
            return stack.Count == 0;
        }
        public static void Question()
        {
            Console.WriteLine($"({{[]}}) :{BalancedParentheses("({[]})")} ");
            Console.WriteLine($"({{[)]}} :{BalancedParentheses("({[)]}")} ");
        }
    }
}
