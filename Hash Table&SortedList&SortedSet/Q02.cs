using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
        Sort and Remove Duplicates from a List
        Description: Given a list with duplicate values, use a SortedSet to remove duplicates and sort it.
     */
    public class Q02
    {

        public static void Question()
        {
            List<int> numbers = new List<int> {3 ,7 ,7 ,5, 5, 3, 8, 8, 5, 2, 3, 1 };
            
            SortedSet<int> list = new SortedSet<int>(numbers);

            Console.WriteLine($"\n Orginal List: {string.Join("," , numbers)}");

            Console.WriteLine($"\n uniqe and sorted List: {string.Join(",", list)}");



        }
    }
}
