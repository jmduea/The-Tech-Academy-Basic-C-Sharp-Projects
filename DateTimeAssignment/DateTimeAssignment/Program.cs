using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the current date and time
            DateTime now = DateTime.Now;

            // Print the current date and time to the console
            Console.WriteLine($"Current date and time: {now}");

            // Ask the user for a number of hours
            Console.Write("Enter a number of hours: ");

            // Read the user's input and convert it to an integer
            int hours;
            if (!int.TryParse(Console.ReadLine(), out hours))
            {
                // If the user enters an invalid number, print an error message to the console
                Console.WriteLine("Invalid number of hours. Exiting program...");
                return;
            }

            // Calculate the date and time X hours from now
            DateTime futureTime = now.AddHours(hours);

            // Print the future date and time to the console
            Console.WriteLine($"In {hours} hours, it will be {futureTime}");

            // Wait for the user to press a key before closing the console window
            Console.ReadKey();
        }
    }
}
