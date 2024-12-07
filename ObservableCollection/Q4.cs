using ObservableCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservableCollection
{
    /*
        Task Management System
        Problem: Manage a list of tasks dynamically, allowing addition, removal, and status updates.
     */

    public class TaskToDo
    {
        public string Name { get; set; }
        public string Status { get; set; } = "Pending";

        public override string ToString() => $"{Name} - Status: {Status}";
    }

    public class Q4
    {
        public static void Question()
        {
            MyObservableCollection<TaskToDo> Tasks = new MyObservableCollection<TaskToDo>();

            Console.WriteLine("\n\nToday You must finish all these Tasks:");
            Tasks.Add(new TaskToDo { Name = "Complete React Fundamentals" });
            Tasks.Add(new TaskToDo { Name = "Solve LeetCode Problem" });
            Tasks.Add(new TaskToDo { Name = "English Language Improvement" });
            Tasks.Add(new TaskToDo { Name = "Walk 10,000 Steps per Day" });

            DisplayTasks(Tasks);

            Console.WriteLine("\nFirst Task Processing...");
            Task.Delay(1000).Wait();
            Tasks[0].Status = "Completed";
            Tasks.RemoveAt(0);

            Console.WriteLine("\nSecond Task Processing...");
            Task.Delay(1000).Wait();
            Tasks[0].Status = "Completed";
            Tasks.RemoveAt(0);

            Console.WriteLine($"\nSwapping priority: '{Tasks[0].Name}' will be done after '{Tasks[1].Name}'...");
            Tasks.Move(0, 1);

            Console.WriteLine("\nThird Task Processing...");
            Task.Delay(1000).Wait();
            Tasks[0].Status = "Completed";
            Tasks.RemoveAt(0);

            Console.WriteLine("\nFinal Task Processing...");
            Task.Delay(1000).Wait();
            Tasks[0].Status = "Completed";
            Tasks.RemoveAt(0);

            Console.WriteLine("\n\nAll Tasks Completed!");
            DisplayTasks(Tasks);
        }

        private static void DisplayTasks(MyObservableCollection<TaskToDo> tasks)
        {
            Console.WriteLine("\nCurrent Tasks in List:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks left!");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
