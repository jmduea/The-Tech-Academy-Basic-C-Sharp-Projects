using System;

namespace PackageExpress
{
    class PackageExpress
    {
        static void Main(string[] args)
        {
            while (true) // keep the program running until user decides to exit
            {
                Console.WriteLine("Welcome to Package Express. Please follow the instructions below."); // print welcome statement

                Console.Write("Please enter the package weight as a number (ex:50): ");
                double weight = Convert.ToDouble(Console.ReadLine()); // ask user for the package weight and store it in a double variable

                if (weight > 50) // check if the weight is greater than 50
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Would you like to ship a different package? (Enter yes or no)"); // print that the package is too heavy and ask the user if they want to ship a different package
                    string response = Console.ReadLine().ToLower(); // store the response in a string variable converted to lowercase
                    if (response == "yes") continue; // if the user wants to ship a different package, return to the start of the program
                    else break; // if the user does not want to ship a different package, exit the loop and end the program
                }

                Console.Write("Please enter the package width as a number (ex:50): ");
                double width = Convert.ToDouble(Console.ReadLine()); // ask user for the package width and store it in a double variable

                Console.Write("Please enter the package height as a number (ex:50): ");
                double height = Convert.ToDouble(Console.ReadLine()); // ask user for the package height and store it in a double variable

                Console.Write("Please enter the package length as a number (ex:50): ");
                double length = Convert.ToDouble(Console.ReadLine()); // ask user for the package length and store it in a double variable

                double dimensionTotal = width + height + length; // calculate the total dimension of the package
                if (dimensionTotal > 50) // check if the dimension total is greater than 50
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Would you like to ship a different package? (Enter yes or no)"); // if the dimension total is greater than 50 tell the user that the package is too big to be shipped with Package Express and ask if they want to ship a different package
                    string response = Console.ReadLine().ToLower(); // store user response in a string variable converted to lowercase
                    if (response == "yes") continue; // if the user wants to ship a different package, return to the start of the program
                    else break; // if the user does not want to ship a different package, exit the loop and end the program
                }

                double quote = (width * height * length * weight) / 100; // calculate the quote for shipping the package

                Console.WriteLine("Your estimated total for shipping this package is :$" + quote.ToString("N2")); // print the quote as a dollar amount with 2 decimal places on console
                Console.WriteLine("Thank you!"); // print thank you on console

                Console.WriteLine("Would you like to ship a another package? (Enter yes or no)"); // ask user if they want to ship another package
                string retryResponse = Console.ReadLine().ToLower(); // store users response in a sting variable converted to lowercase
                if (retryResponse != "yes") break; // if the user does not want to ship another package, exit the loop and end the program
            }
        }
    }
}
