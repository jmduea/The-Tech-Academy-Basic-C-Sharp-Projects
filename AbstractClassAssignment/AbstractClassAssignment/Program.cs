using System;


namespace AbstractClassAssignment
{
    abstract class Person
    {
        // Add two properties to Person - firstName and lastName
        public string firstName { get; set; }
        public string lastName { get; set; }

        // Add a method called SayName
        public abstract void SayName();
    }

    // Define a class called Employee which inherits from the Person class
    class Employee : Person
    {
        // Implement the SayName method in the Employee class
        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {firstName} {lastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with a first name of "Sample and a last name of "Employee"
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Employee"
            };

            // Call the overridden SayName method on the Employee object, which will output the employee's name to the console
            employee.SayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
