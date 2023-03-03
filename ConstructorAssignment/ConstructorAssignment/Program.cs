using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable
            const string companyName = "ABC Corp";

            // Create a variable using the keyword "var"
            var employee = new Employee("John", "Doe", "Manager");

            // Output the employee's information to the console
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}, Position: {employee.Position}");

            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
