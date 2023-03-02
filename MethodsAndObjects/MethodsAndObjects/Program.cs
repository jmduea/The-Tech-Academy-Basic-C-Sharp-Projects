using System;


namespace MethodsAndObjects
{
    // Define a class called Person with two properties - FirstName and LastName
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Define a method called SayName that writes the full name to the console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }

    // Define a class called Employee which inherits from the Person class
    class Employee : Person
    {
        // Add a new property to Employee called Id
        public int Id { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with a first name of "Sample" and a last name of "Student"
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 123456
            };

            // Call the SayName method on the Employee object, which will output the first and last name
            employee.SayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
