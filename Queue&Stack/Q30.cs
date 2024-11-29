using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
     Problem: Remove the minimum number of invalid parentheses to make the string valid.

    Example:
    Input: "(()))"
    Output: "()" or "(())"

    Key Points:
    Use a stack to track mismatched parentheses.
     */
    public class Q30
    {
        /*  private static string InvalidParentheses(string s)
          {
              StringBuilder result = new();
              Stack<char> stack = new Stack<char>();
              foreach (char c in s)
              {
                  if (c == '(') stack.Push('(');

                  if (c == ')' && stack.Contains('('))
                   {
                      result.Append(stack.Pop());
                  }
              }
              foreach (var c in result.ToString()) result.Append(')');
              return result.ToString();
          }*/
        static string RemoveInvalidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            HashSet<int> invalidIndices = new HashSet<int>();


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        invalidIndices.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }


            while (stack.Count > 0)
            {
                invalidIndices.Add(stack.Pop());
            }


            char[] result = new char[s.Length - invalidIndices.Count];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!invalidIndices.Contains(i))
                {
                    result[index++] = s[i];
                }
            }


            return new string(result);
        }

        public static void Question()
        {
           // Console.WriteLine($"(())) => {InvalidParentheses("(()))")}");
           // Console.WriteLine($"(())) => {InvalidParentheses("(()))")}");

            Console.WriteLine($"(())) => {RemoveInvalidParentheses("(()))")}");
            Console.WriteLine($"(())) => {RemoveInvalidParentheses("(()))")}");
        }
    }
}
