using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tuples
{
    /*
        Return Success or Failure from a Function
        Problem: Write a function that check the student mark and returns success status and the mark value.
     */
    public class Q4
    {
        static (int Mark, string Status) IsSuccess((string Name, int Mark) student)
            => student.Mark switch
            {
                > 0 and <= 50 => (student.Mark, "Fail"),
                > 50 and <= 60 => (student.Mark, "Acceptable"),
                > 60 and <= 80 => (student.Mark, "Good"),
                > 80 and <= 90 => (student.Mark, "Excellent"),
                > 90 and <= 100 => (student.Mark, "Hero :)"),
                _ => (student.Mark, "Invalid Mark")
            };

        public static void Question()
        {
            List<(string Name, int Mark)> Students = new List<(string, int)>
            {
                ("Jamal", 50),
                ("Omar", 90),
                ("Ali", 40),
                ("Noor", 80),
                ("Sara", 65),
            };

            foreach (var Student in Students)
            {
                Console.WriteLine($"Student: {Student.Name}, Result: {IsSuccess(Student)}");
            }

        }
    }
}