using System;


namespace Operators
{   
    // Define a class called Employee
    class Employee
    {
        // Add properties for Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload the "==" operator to compare the Id property of two Employee objects
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // If both employees are null, or both Ids are 0, return true
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            // If one employee is null, or both Ids are different, return false
            if (employee1 is null || employee2 is null || employee1.Id != employee2.Id)
            {
                return false;
            }

            // If the Ids are the same, return true
            return true;
        }

        // Overload the "!=" operator to check for inequality using the "==" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }

        public override bool Equals(object obj)
        {
            // Check if obj is an Employee object
            if (!(obj is Employee))
            {
                return false;
            }

            // Cast obj to employee and compare the Id property
            Employee other = (Employee)obj;
            return this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            // Use the Id property to generate a unique hash cod
            return this.Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee employee1 = new Employee()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Doe"
            };

            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}");
            Console.WriteLine($"employee1.GetHashCode() == employee2.GetHashCode(): {employee1.GetHashCode() == employee2.GetHashCode()}");

            Console.ReadLine();
        }
    }
}
