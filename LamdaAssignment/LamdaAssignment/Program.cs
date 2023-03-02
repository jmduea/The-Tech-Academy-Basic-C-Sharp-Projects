using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of at least 10 employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe"},
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe"},
                new Employee { Id = 3, FirstName = "Bob", LastName = "Smith"},
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson"},
                new Employee { Id = 5, FirstName = "Alice", LastName = "Jones"},
                new Employee { Id = 6, FirstName = "Mike", LastName = "Brown"},
                new Employee { Id = 7, FirstName = "Joe", LastName = "Garcia"},
                new Employee { Id = 8, FirstName = "Karen", LastName = "Williams"},
                new Employee { Id = 9, FirstName = "David", LastName = "Davis"},
                new Employee { Id = 10, FirstName = "Steve", LastName = "Wilson"}
            };

            // Use a foreach loop to create a new list of all employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // Output the list of employees with the first name "Joe" to the console
            Console.WriteLine("Employees with the first name Joe (foreach loop): ");
            foreach (Employee joe in joes)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}");
            }

            // Use a lambda expression to create a new list of all employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Output the list of "Joe" employees to the console
            Console.WriteLine("\nEmployees with the first name Joe (lambda expression):");
            foreach (Employee joe in joesLambda)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName}");
            }

            // Use a lambda expression to create a new list of all employees with an Id number greater than 5
            List<Employee> idGreaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

            // Output the list of employees with Id numbers greater than 5 to the console
            Console.WriteLine("\nEmployees with Id > 5:");
            foreach (Employee employee in idGreaterThan5)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} (Id: {employee.Id})");
            }

            // Keep the console window open until the user presses a key
            Console.ReadKey();
        }
    }
}
