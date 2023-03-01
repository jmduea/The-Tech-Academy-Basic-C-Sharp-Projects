using System;

namespace IncomeComparison
{
    class IncomeComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program"); // print "Anonymous Income Comparison Program" on console

            Console.WriteLine("Person 1"); // print "Person 1" on console
            Console.Write("Hourly Rate? ");
            double rate1 = Convert.ToDouble(Console.ReadLine()); // ask user for hourly rate and store it in a double variable
            Console.Write("Hours worked per week? ");
            double hours1 = Convert.ToDouble(Console.ReadLine()); // ask user for hours worked per week and store it in a double variable

            Console.WriteLine("Person 2"); // print "Person 2" on console
            Console.Write("Hourly Rate? ");
            double rate2 = Convert.ToDouble(Console.ReadLine()); // ask user for hourly rate and store it in a double variable
            Console.Write("Hours worked per week? ");
            double hours2 = Convert.ToDouble(Console.ReadLine()); // ask user for hours worked per week and store it in a double variable

            double salary1 = rate1 * hours1 * 52; // calculate the annual salary of Person 1 and store it in a double variable
            double salary2 = rate2 * hours2 * 52; // calculate the annual salary of Person 2 and store it in a double variable

            Console.WriteLine("Annual salary of Person 1:"); // print "Annual salary of Person 1:" on console
            Console.WriteLine(salary1.ToString("N2")); // display the annual salary of Person 1 with 2 decimal places

            Console.WriteLine("Annual salary of Person 2:"); // print "Annual salary of Person 2:" on console
            Console.WriteLine(salary2.ToString("N2")); // display the annual salary of Person 2 with 2 decimal places

            Console.WriteLine("Does Person 1 make more money than Person 2?"); // print "Does Person 1 make more money than Person 2?" on console
            Console.WriteLine((salary1 > salary2).ToString()); // write the true or false value of whether Person 1 makes more money than Person 2
            Console.ReadLine();
        }
    }
}