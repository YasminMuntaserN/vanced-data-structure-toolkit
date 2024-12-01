using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Dictionary_Hashset
{
    /*
     Store Book Information
        Problem: Store information about books (Title, Author) using their ISBN as the key.

        Note: Use Dictionary and Tuple.

        Output:

        ISBN: 978-3-16-148410-0, Title: The Great Gatsby, Author: F. Scott Fitzgerald

        ISBN: 978-1-61-729494-5, Title: C# in Depth, Author: Jon Skeet
     */
    public class Q2
    {
        public static void Question() {

        Dictionary<string, (string Title, string Author)> books = new Dictionary<string, (string, string)>
        {
            { "978-3-16-148410-0", ("The Great Gatsby", "F. Scott Fitzgerald") },
            { "978-1-61-729494-5", ("C# in Depth", "Jon Skeet") }
        };

            foreach (var book in books)
            {
                Console.WriteLine($"ISBN: {book.Key}, Title: {book.Value.Title}, Author: {book.Value.Author}");
            }
        }
    }
}
