using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tuples
{
    /*
       Simplified Address Representation
        Problem: Use tuples to represent and display a person's address.

        Output: Address: 123 Main St, Springfield, IL, 62704
     */
    public class Q5
    {
        public static void Question()
        {
            var address = (Street: "123 Main St", City: "Springfield", State: "IL", Zip: "62704");
            Console.WriteLine($"Address: {address.Street}, {address.City}, {address.State}, {address.Zip}");
        }
    }
}