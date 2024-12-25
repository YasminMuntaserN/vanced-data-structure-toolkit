using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
     Copy Hashtable to Another Hashtable
     Description:
     Write a program to copy all key-value pairs from one Hashtable to another.
     */
    public class Q01
    {
        static void Print(Hashtable Hashtable)
        {
            foreach (DictionaryEntry entry in Hashtable)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

        public static void Question()
        {
            Hashtable hashtable1 = new Hashtable
            {
                { "key1", "value1" },
                { "key2", "value2" },
                { "key3", "value3" }
            };

            //  Hashtable hashtable2 = new Hashtable(hashtable1); 


            Hashtable Hashtable2 = new Hashtable();
            foreach (DictionaryEntry entry in hashtable1)
            {
                Hashtable2.Add(entry.Key, entry.Value);
            }

            Console.WriteLine("\n hashtable1 contents:");
            Print(hashtable1);
            Console.WriteLine("\n Hashtable2 contents:");
            Print(Hashtable2);


        }
    }
}
