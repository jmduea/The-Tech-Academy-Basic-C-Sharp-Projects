using System;


namespace ClassSubmissionAssignment
{
    // Define  a class MyMath
    class MyMath
    {
        // Define a void method called DivideByTwo that takes an intger parameter and divides it by 2
        public void DivideByTwo(int number)
        {
            int result = number / 2;
            Console.WriteLine($"The result of diviiding {number} by 2 is {result}");
        }

        // Define another method called DivideByTwo that takes an integer parameter and returns the result of dividing it by 2
        public int DivideByTwo(int number, out int remainder)
        {
            remainder = number % 2;
            return number / 2;
        }

        // Declare a static class called MathHelper
        public static class MathHelper
        {
            // Define a static method called MultiplyByTwo that takes an integer parameter and multiplies it by 2
            public static int MultiplyByTwo(int number)
            {
                return number * 2;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an instance of MyMath
            MyMath myMath = new MyMath();

            // Prompt the uer to enter a number
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            //Call the DivideByTwo method of myMath with the entered number
            myMath.DivideByTwo(number);

            // Declare an integer variable calle remainder
            int remainder;

            // Call the overloaded DivideByTwo method of myMath with the entered number
            int result = myMath.DivideByTwo(number, out remainder);

            // Print the result of the calculation and the remainder to the console
            Console.WriteLine($"The result of dividing {number} by 2 is {result}, with a remainder of {remainder}");

            // Call the static MultiplyByTwo method of the MathHelper class with the entered number and print the result to the console
            int multiplied = MyMath.MathHelper.MultiplyByTwo(number);
            Console.WriteLine($"Multiplying {number} by 2 gives {multiplied}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
