using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    /*
     Return Multiple Values from a Function
     Problem: Create a function that returns a student's name, age, and grade.
     */
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Grade { get; set; }
    }
    public class Q1
    {
         static (string Name, int Age, float Grade) StudentDetails(Student student)
            => (student.Name, student.Age, student.Grade);
      
        public static void Question()
        {
            var Student = new Student() {Name = "Yasmin" ,Age =20 ,Grade =50.0f};
            var details =StudentDetails(Student);
            Console.WriteLine($"Name: {details.Name}, Age: {details.Age}, Grade: {details.Grade}");
        }
    }
}
