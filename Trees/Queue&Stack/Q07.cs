using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack
{
    /*
       Problem: Use a stack for backtracking My Day.

        Output:
        Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.
        Backtracking...
        Back to: Go Home
        Back to: Go to Cafe
        Back to: Go To Work
        Back to: Go to Super Market
        Back to: Go to Gaz Station
        Back to: Start     
     
     
     */
    public class Q07
    {
        public static void BacktrackingSteps(Stack<string> steps)
        {
            while (steps.Count > 0)
            {
                Console.WriteLine($" Back to: {steps.Pop()}");
            }
        }

        public static void Question()
        {
            Stack<string> steps = new Stack<string>();

            steps.Push("Start");
            steps.Push("Go to Gaz Station");
            steps.Push("Go to Super Market");
            steps.Push("Go To Work");
            steps.Push("Go to Cafe");
            steps.Push("Go Home");


            Console.WriteLine(string.Join(" -> " , steps.Reverse()));

            Console.WriteLine("Backtracking...");

            BacktrackingSteps(steps);
        }
    }
}
