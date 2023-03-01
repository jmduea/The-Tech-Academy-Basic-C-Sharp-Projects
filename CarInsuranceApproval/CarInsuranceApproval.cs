using System;

namespace CarInsuranceApproval
{
    class CarInsuranceApproval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?"); // print "What is your age?" on console
            int age = Convert.ToInt32(Console.ReadLine()); // ask user for their age and store it in an integer variable

            Console.WriteLine("Have you ever had a DUI? (Enter yes or no)"); // print "Have you ever had a DUI? (Enter yes or no)" on console
            string duiResponse = Console.ReadLine().ToLower(); // store the users response in a string variable

            bool hasDUI = (duiResponse == "yes"); // determine whether the user has had a DUI based on their response and store in a boolean variable

            Console.WriteLine("How many speeding tickets do you have?"); // print "How many speeding tickets do you have?" on console
            int numTickets = Convert.ToInt32(Console.ReadLine()); // store the users response in an integer variable

            bool isQualified = (age > 15 && !hasDUI && numTickets <= 3); // determine whether the applicant qualifies for car insurance based on the given rules and store the results in a boolean variable

            Console.WriteLine("Qualified?"); // print "Qualified?" on console
            Console.WriteLine(isQualified.ToString()); // write the true or false value of whether the applicant qualifies for car insurance on the console
            Console.ReadLine();
        }
    }
}
