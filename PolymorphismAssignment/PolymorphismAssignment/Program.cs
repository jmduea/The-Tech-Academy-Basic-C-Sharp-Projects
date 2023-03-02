using System;


namespace PolymorphismAssignment
{
    // Define an interface called IQuittable
    interface IQuittable
    {
        void Quit();
    }

    // Define a class called Person
    class Person
    {
        // Add two properties to Person - firstName and lastName
        public string firstName { get; set; }
        public string lastName { get; set; }
    }

    // Define a class called Employee which inherits from the Person class and implements the IQuittable interface
    class Employee : Person, IQuittable
    {
        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit the company.");
        }

        // Implement the SayName method
        public void SayName()
        {
            Console.WriteLine($"Employee Name: {firstName} {lastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with a first name of "Sample" and a last name of "Employee"
            Employee employee = new Employee
            {
                firstName = "Sample",
                lastName = "Employee"
            };

            // Create an object of type IQuittable using the Employee object
            IQuittable quittableEmployee = employee;

            // Call the Quit method on the IQuittable object, which will output that the employee has quit the company to the console
            quittableEmployee.Quit();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
