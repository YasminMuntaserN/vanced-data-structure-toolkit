using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Create a dictionary for translating words from one language to another.

        Output:

        Hello in Spanish: Hola

        Goodbye in Spanish: Adiós
     */
    public class Q3
    {
        /*  private static string ConvertToSpanish(string word)
          {
              Dictionary<char, string> englishToSpanish = new Dictionary<char, string>
                  {
                      { 'A', "A" }, { 'B', "B" }, { 'C', "C" }, { 'D', "D" }, { 'E', "E" }, { 'F', "F" },
                      { 'G', "G" }, { 'H', "H" }, { 'I', "I" }, { 'J', "J" }, { 'K', "K" }, { 'L', "L" },
                      { 'M', "M" }, { 'N', "N" }, { 'O', "O" }, { 'P', "P" }, { 'Q', "Q" }, { 'R', "R" },
                      { 'S', "S" }, { 'T', "T" }, { 'U', "U" }, { 'V', "V" }, { 'W', "W" }, { 'X', "X" },
                      { 'Y', "Y" }, { 'Z', "Z" },
                      { 'Á', "Á" }, { 'É', "É" }, { 'Í', "Í" }, { 'Ó', "Ó" }, { 'Ú', "Ú" },
                      { 'Ñ', "Ñ" }
                  };
              StringBuilder result = new();

              for (int i = 0; i < word.Length; i++)
              {
                  word = word.ToUpper();
                  result.Append(i == 0 ? englishToSpanish[word[i]] : englishToSpanish[word[i]].ToLower());
              }
               return result.ToString();

          }
          public static void Question()
          {
               Console.WriteLine($" Hello in Spanish: {ConvertToSpanish("Hello")}");
               Console.WriteLine($" Hello in Goodbye: {ConvertToSpanish("Goodbye")}");
          }*/

        public static void Question()
        {
            Dictionary<string, string> englishToSpanish = new Dictionary<string, string>
            {
                { "Hello", "Hola" },
                { "Goodbye", "Adiós" }
            };

            Console.WriteLine($" Hello in Spanish: {englishToSpanish["Hello"]}");
            Console.WriteLine($" Hello in Goodbye: {englishToSpanish["Goodbye"]}");

        }
    }
}
