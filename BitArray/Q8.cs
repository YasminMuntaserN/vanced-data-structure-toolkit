using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Array
{
    /*
        Voting System
       Task: Use a BitArray to record votes (yes/no) for a decision in a committee of 8 members. Count the number of "yes" votes.
    */
    public class Q8
    {
        public static void Question()
        {
            BitArray votes = new BitArray(8);
            byte yesCount = 0;
            for (int i = 0; i < votes.Count; i++)
            {
                votes[i] = new Random().Next(0, 2) == 1 ? true : false ;
                Console.WriteLine($"Person{i+1,-7} : {(votes[i] ? "Yes" : "No")}");
                if (votes[i]) yesCount++;
            }

            Console.WriteLine($"the number of yes votes.{yesCount}");
        }
    }
}