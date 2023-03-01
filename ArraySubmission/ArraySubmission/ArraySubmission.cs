using System;
using System.Collections.Generic;


namespace ArraySubmission
{
    class ArraySubmission
    {
        static void Main(string[] args)
        {
            // create a one-dimensional array of strings
            string[] stringArray = { "apple", "banana", "cherry", "date", "elderberry" };

            // ask the user to select an index of the array
            Console.WriteLine("Please enter an index of the string array (0-4): ");
            int stringIndex = Convert.ToInt32(Console.ReadLine()); // convert user input to an integer variable

            // display the string at the selected index on the screen
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("The string at index " + stringIndex + " is " + stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("The selected index does not exist.");
            }

            // create a one-dimensional array of integers
            int[] intArray = { 1, 2, 3, 4, 5 };

            // ask the user to select an index of the array
            Console.Write("Please enter an index of the integer array (0-4): ");
            int intIndex = Convert.ToInt32(Console.ReadLine()); // convert user input to an integer variable

            // display the integer at the selected index on the screen
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("The integer at index " + intIndex + " is " + intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("The selected index does not exist.");
            }

            // create a list of strings
            List<string> stringList = new List<string>();
            stringList.Add("apple");
            stringList.Add("banana");
            stringList.Add("cherry");
            stringList.Add("date");
            stringList.Add("elderberry");

            // ask the user to select an index of the list
            Console.Write("Please enter an index of the string list (0-4): ");
            int listIndex = Convert.ToInt32(Console.ReadLine()); // convert user input to an integer variable

            // display the content at the selected index on the screen
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("The string at index " + listIndex + " is " + stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("The selected index does not exist.");
            }
            Console.ReadLine();
        }
    }
}