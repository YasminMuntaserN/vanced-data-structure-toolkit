using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    //Problem: Store the grades of students using their names as keys, and retrieve Bob's Info using student name.
   
    public class Q1
    {
        public static void Question() {
            Dictionary<string, int> studentsGrades = new Dictionary<string, int>
            {
                { "Dana", 30 },
                { "Bob", 50 },
                { "Taha", 80 }
            };
            Console.WriteLine($"Bob Grade :{studentsGrades["Bob"]}");
        }
    }
}
