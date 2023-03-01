using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //print "The Tech Academy" on console
            Console.WriteLine("Student Daily Report"); // print "Student Daily Report" on console
            
            // ask user for their name and store it in a string variable
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            // ask user for their course and store it in a string variable
            Console.Write("What course are you on? ");
            string course = Console.ReadLine();

            // ask user for their page number and store it in an integer variable
            Console.Write("What page number? ");
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            // ask user if they need help and store their response in a boolean variable
            Console.Write("Do you need help with anything? Please answer true or false ");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            // ask user for any positive experiences they want to share and store it in a string variable
            Console.Write("Were there any posiive experiences you'd like to share? Please give specifics. ");
            string positiveExperiences = Console.ReadLine();

            // ask user for any other feedback they want to provide and store it in a string variable
            Console.Write("Is there any other feedback you'd like to provide? Please be specific. ");
            string feedback = Console.ReadLine();

            // ask user how many hours they studied and store it in a float variable
            Console.Write("How many hours did you study today? ");
            float hoursStudied = Convert.ToSingle(Console.ReadLine());

            // print a thank you message on console
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day! This is the end of the program.");
            Console.ReadLine();
        }
    }
}
