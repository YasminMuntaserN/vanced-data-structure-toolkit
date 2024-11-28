using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
     Check if a given string is a palindrome using a stack.
    Input: "madam"
    Output: true
    Input: "hello"
    Output: false

     */
    public class Q27
    {
        // without stack
        private static bool Palindrome(string s)
          =>  s.Take(s.Length / 2).SequenceEqual(
                (s.Skip(s.Length % 2 == 0 ? s.Length / 2 : (s.Length / 2) + 1).Reverse()));
      
        private static bool Palindrome2(string s)
        {
            Stack<char> stack = new Stack<char>(s.Take(s.Length/2));
           
            int len = s.Length % 2 == 0 ? s.Length / 2 : (s.Length / 2) +1;
            
            for (int i = len; i< s.Length; i++)
                if (stack.Pop() != s[i])  return false;   
          
            return true;
        }

        public static void Question()
        {
            Console.WriteLine($"madam : {Palindrome("madam")}");
            Console.WriteLine($"hello : {Palindrome("hello")}");

            Console.WriteLine($"madam : {Palindrome2("madam")}");
            Console.WriteLine($"hello : {Palindrome2("hello")}");
        }
    }

}
