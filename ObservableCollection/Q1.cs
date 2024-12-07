using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    /*
     Dynamic List of Students in a Classroom
     Problem: Maintain and display a dynamic list of students in a classroom.

     Example: Add, remove, or replace students in real-time, and notify changes to event so you can use it to change UI.
     
     */
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id : {Id} | Name : {Name} | Age : {Age}   ";
        }
    }
    public class Q1
    {
        public static void Question()
        {
            MyObservableCollection<Student> Students = new MyObservableCollection<Student>();

            Students.Add(new Student() { Id = 1, Name = "Ali kamal", Age = 25 });
            Students.Add(new Student() { Id = 2, Name = "Sara kamal", Age = 22 });
            Students.Add(new Student() { Id = 3, Name = "Jalal Ahmed", Age = 26 });
            Students.Add(new Student() { Id = 4, Name = "Reem kamal", Age = 21 });

            Students.RemoveAt(1);

            Students.Insert(0, new Student() { Id = 5, Name = "Dana moh", Age = 22 });

            Students[1] = new Student() { Id = 6, Name = "moh", Age = 22 }; 
            
            Students.Move(0, 2);


            Console.WriteLine("All Students : ");
            foreach (var Student in Students)
            {
                Console.WriteLine(Student);
            }
        }
    }
}
