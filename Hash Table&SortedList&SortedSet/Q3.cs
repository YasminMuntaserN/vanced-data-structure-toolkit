using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
        Find Missing Numbers in a Range
        Description: Given a range of numbers, find the missing numbers by comparing with a SortedSet.
     */
    public class Q3
    {

        public static void Question()
        {
            List<int> numbers = new List<int> { 3, 7, 7, 5, 5, 3, 8, 8, 5, 2, 3, 1 };
            SortedSet<int> uniqueNumbers = new SortedSet<int>(numbers);
            var rangeNumbers = Enumerable.Range(1, numbers.Max());
            var missingNumbers = rangeNumbers.Except(uniqueNumbers);

            Console.WriteLine($"\nOriginal List: {string.Join(", ", numbers)}");
            Console.WriteLine($"\nUnique and Sorted List: {string.Join(", ", uniqueNumbers)}");
            Console.WriteLine($"\nMissing Numbers in the List: {string.Join(", ", missingNumbers)}");
    }
    }
}
