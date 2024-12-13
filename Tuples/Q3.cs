using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    /*
        Store and Compare Employee Details
        Problem: Use tuples to store employee names and salaries, and compare them.
     */
    public class Q3
    {
        static (string Name, int Salary) GetEmployeeWithHigherSalary((string Name, int Salary) employee1, (string Name, int Salary) employee2)
            => employee1.Salary > employee2.Salary ? employee1 : employee2;

        static void DisplayEmployeesBySalary(List<(string Name, int Salary)> employees)
        {
            foreach (var employee in employees.OrderBy(e => e.Salary))
            {
                Console.WriteLine($"Name: {employee.Name}, Salary: {employee.Salary}");
            }
        }

        public static void Question()
        {
            List<(string Name, int Salary)> employees = new List<(string, int)>
            {
                ("Jamal", 500),
                ("Omar", 300),
                ("Ali", 400)
            };

            var case1 = GetEmployeeWithHigherSalary(employees[0], employees[1]);
            Console.WriteLine($"{case1.Name} has a higher salary.");

            var case2 = GetEmployeeWithHigherSalary(employees[1], employees[2]);
            Console.WriteLine($"{case2.Name} has a higher salary.");

            Console.WriteLine("\nOrdered Employees by Salary:");
            DisplayEmployeesBySalary(employees);
        }
    }
}