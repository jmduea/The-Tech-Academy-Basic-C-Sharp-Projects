using System;


namespace ParsingEnums
{
    // Define an enum for days of the week
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool isValidDay = false;

            while (!isValidDay)
            {

                try
                {
                    // Prompt the user to enter the current day of the week
                    Console.Write("Enter the current day of the week: ");

                    // Read the user's input and convert it to an enum value
                    DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);

                    // Assign the enum value to a variable
                    DayOfWeek selectedDay = currentDay;

                    // Output the selected day to the console
                    Console.WriteLine($"Selected day: {selectedDay}");

                    isValidDay = true;
                }
                catch (ArgumentException)
                {
                    // If an error occurs (e.g. the user entered an invalid day), print an error message to the console
                    Console.WriteLine("Please enter an actual day of the week.");

                    continue;
                }

                //Keep the console window open until the user presses a key
                Console.ReadKey();
            }
        }
    }
}
