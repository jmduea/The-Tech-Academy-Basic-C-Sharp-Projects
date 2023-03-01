using System;
using System.Collections.Generic;

namespace StringsAndIntegers
{
    class StringsAndIntegers
    {
        static void Main(string[] args)
        {
            // create a list of integers
            List<int> intList = new List<int> { 10, 20, 30, 40, 50 };

            try
            {
                // ask the user for a number to divide each number in the list by
                Console.Write("Please enter a number to divide each number in the list by: ");
                int userInput = int.Parse(Console.ReadLine());

                // loop through each integer in the list, divide it by the user's input, and display the result
                foreach (int num in intList)
                {
                    double result = (int)num / userInput; // perform division and cast to double to avoid integer division
                    Console.WriteLine($"{num} / {userInput} = {result}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid Input: please enter a valid number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }

            Console.WriteLine("The program has emerged from the try/catch block and continued executing.");
            Console.ReadLine();
        }
    }
}
