using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
        Check for Duplicate Entries in Real-Time
        Problem: Detect duplicates as data is added.
     */
    public class Q07
    {
        private static string IfDuplicate(HashSet<int> hs , int value )
        {
            return hs.Add(value) ? $"New Value : {value}" : $"Duplicate detected: {value}";
        }

        public static void Question()
        {
            HashSet<int> hs = new HashSet<int>();
            
            foreach(var item in new int[] { 1, 2, 1, 3, 1, 4 })
                    Console.WriteLine(IfDuplicate(hs ,item));
        }


    }
}
