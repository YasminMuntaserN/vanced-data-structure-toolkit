using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table_SortedList_SortedSet
{
    /*
     Schedule Tasks Based on Priority
    Description: Implement a task scheduler where tasks have priorities, and you need to process them in order of priority.
    */

    class Task
    {
        public string TaskName { get; set; }
        public int Priority {  get; set; }

        public override string ToString()
        {
            return $"\nTaskName : {TaskName} ,Priority : {Priority}";
        }
    }

    class TaskComparer : IComparer<Task>
    {
        public int Compare(Task x, Task y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            int PriorityComparison = x.Priority.CompareTo(y.Priority);
            if (PriorityComparison == 0)
                return PriorityComparison;

            return x.TaskName.CompareTo(y.TaskName);
        }
    }

    public class Q12
    {
        public static void Question()
        {
            SortedSet<Task> Tasks = new SortedSet<Task>(new TaskComparer())
            {
                new Task(){TaskName ="Task1" , Priority =1 },
                new Task(){TaskName ="Task2" , Priority =2 },
                new Task(){TaskName ="Task3" , Priority =2 },
                new Task(){TaskName ="Task4" , Priority =3 },
                new Task(){TaskName ="Task1" , Priority =4 },
            };

            Console.WriteLine($"Next showtime::{string.Join("", Tasks)}");
        }
    }
}