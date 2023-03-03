using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        // Define a constructor that takes three parameters
        public Employee(string firstName, string lastName, string position)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
        }

        // Define a constructor that takes two parameters and chains to the previous constructor
        public Employee(string firstName, string lastName) : this(firstName, lastName, "Employee")
        {
        }
    }
}
