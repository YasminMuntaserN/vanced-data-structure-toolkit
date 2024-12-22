using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
        Track Unique Items in a Shopping Cart
        Description: Keep track of unique items in a shopping cart and sort them alphabetically.
     */

    public class Q8
    {
        public static void Question()
        {
            SortedSet<string> products = new SortedSet<string>()
            {
                "Apple",
                "Banana",
                "Orange",
                "Apple"
            };

            Console.WriteLine($"Products :{string.Join(" , ", products)}");
        }
    }
}