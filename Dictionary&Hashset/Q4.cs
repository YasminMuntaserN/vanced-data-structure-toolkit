using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Count Word Frequencies in a Text
        Problem: Count the frequency of each word in a given text.

        Input: "hello world hello universe"

        Output:
        hello: 2
        world: 1
        ﻿universe: 1
     */
    public class Q4
    {
          private static Dictionary<string, int> CountFrequency(string word)
          {
            Dictionary<string ,int> englishToSpanish = new Dictionary<string, int>();
           
            foreach (string str in word.Split(" "))
            {
                if (englishToSpanish.ContainsKey(str)) englishToSpanish[str]++;
                else englishToSpanish[str] = 1;
            }
           
            return englishToSpanish;

          }
          public static void Question()
          {
            foreach (var kv in CountFrequency("hello world hello universe"))
            {
                Console.WriteLine($"{kv.Key} : {kv.Value}");
            }
          }


    }
}
