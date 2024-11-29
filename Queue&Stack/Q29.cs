using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
     Problem: Evaluate a mathematical expression containing +, -, (, ) without * or /.

    Example:
    Input: "1 + (2 - 3)"
    Output: 0

    Key Points:
    Use a stack to handle parentheses and maintain the current sum.
     */
    public class Q29
    {
        public static int EvaluateExpression(string s)
        {
            Stack<int> stack = new Stack<int>();
            int number = 0;
            char sign = '+';

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];

                if (char.IsDigit(ch))
                {
                    number = int.Parse(ch.ToString());
                }

                if (ch == '(')
                {
                    int j = i, brackets = 1;
                    while (brackets > 0)
                    {
                        i++;
                        if (s[i] == '(') brackets++;
                        if (s[i] == ')') brackets--;
                    }
                    string sub = s.Substring(j + 1, i - j - 1);
                    number = EvaluateExpression(sub); 
                }

                if (!char.IsDigit(ch) && ch != ' ' || i == s.Length - 1)
                {
                    if (sign == '+') stack.Push(number);
                    else if (sign == '-') stack.Push(-number);

                    sign = ch;
                    number = 0;
                }
            }

            int result = 0;
            while (stack.Count > 0) result += stack.Pop();
            return result;
        }

        public static void  Question()
        {
            Console.WriteLine($"1 + (2 - 3) = { EvaluateExpression("1 + (2 - 3)")}");
        }
    }

}
