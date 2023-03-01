using System;
using System.Collections.Generic;

namespace Six_PartAssignment
{
    class Six_PartAssignment
    {
        static void Main(string[] args)
        {
            //Assignment Part 1
            // create a one-dimensional array of strings
            string[] stringArray = { "apple", "banana", "cherry", "elderberry" };

            // ask the user to input some text
            Console.Write("Please enter some text: ");
            string userInput = Console.ReadLine();

            // iterate through each string in the array and add the user's text input to the end of each string
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userInput;
            }

            // print off each string in the array one at a time
            foreach (string s in stringArray)
            {
                Console.WriteLine(s);
            }
            
            // Assignment Part 2
            // infinite loop
            while (true)
            {
                Console.WriteLine("This is an infinite loop. Press any key to exit.");
                Console.ReadKey();

                // break out of the infinite loop when any key is pressed
                break;
            }

            // Assignment Part 3
            // loop with "<" operator
            Console.WriteLine("Loop with '<' operator:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // loop with "<=" operator
            Console.WriteLine("\nLoop with '<=' operator:");
            for (int i = 0; i <= stringArray.Length - 1; i++)
            {
                Console.WriteLine(stringArray[i]);
            }

            // Assignment Part 4
            // create a list of strings where each item in the list is unique
            List<string> stringList = new List<string> { "apple", "banana", "cherry", "date", "elderberry" };

            // ask the user to input text to search for in the list
            Console.Write("Please enter some text to search for in the list: ");
            string userInput2 = Console.ReadLine();

            bool foundMatch = false; // flag to indicate whether a match has been found or not

            // loop that iterates through the list and displays the index of the list item that contains matching text
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(userInput2))
                {
                    Console.WriteLine($"Match found at index {i}");
                    foundMatch = true; // set flag to true since a match has been found
                    break; // stop the loop from executing once a match has been found
                }
            }

            // check if the user's input is on the list
            if (!foundMatch)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // Assignment Part 5
            // create a list of strings that has at least two identical strings in the list
            List<string> stringList2 = new List<string> { "apple", "banana", "cherry", "date", "apple" };
            
            // ask the user to enter text to search for in the list
            Console.Write("Please enter text to search for in the list: ");
            string userInput3 = Console.ReadLine();

            bool foundMatch2 = false; // flag to indicate whether a match has been found

            // loop that iterates through the list and displays the indices of the items matching the user entered text
            for (int i = 0; i < stringList2.Count; i++)
            {
                if (stringList2[i] == userInput3)
                {
                    Console.WriteLine($"Match found at index {i}");
                    foundMatch2 = true; // set flag to true since a match has been found
                }
            }

            // check if the user's input is on the list
            if (!foundMatch2)
            {
                Console.WriteLine("Your inputn is not on the list.");
            }

            //Assignment Part 6
            // create a list of strings that has at least two identical strings in it
            List<string> stringList3 = new List<string> { "apple", "banana", "cherry", "date", "apple" };

            // create a dictionary to keep track of whether or not a string has already appeared in the list
            Dictionary<string, bool> stringDict = new Dictionary<string, bool>();

            // loop through each item in the list and display a message showing whether or not it has already appeared in the list
            foreach (string item in stringList3)
            {
                // check if the itm has already appeared in the list
                if (stringDict.ContainsKey(item))
                {
                    Console.WriteLine($"{item} - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine($"{item} - this item is unique");
                    stringDict.Add(item, true); // add the item to the dictionary to indicate that it has appeared in the list
                }
            }
            Console.ReadLine();
        }
    }
}
