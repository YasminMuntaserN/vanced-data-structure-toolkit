using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Problem: Implement a phonebook where you can store and retrieve contact numbers using names.

        Output:
        Alice's Phone: 123-456-7890
        Bob's Phone: 987-654-3210
     */
    public class Q05
    {
          public static void Question()
          {
            Dictionary<string, string> englishToSpanish = new Dictionary<string, string>
            {
                { "Alice's", "123-456-7890" },
                { "Bob's", "987-654-3210" }
            };
            foreach (var kv in englishToSpanish)
            {
                Console.WriteLine($"{kv.Key}  Phone : {kv.Value}");
            }
          }


    }
}
