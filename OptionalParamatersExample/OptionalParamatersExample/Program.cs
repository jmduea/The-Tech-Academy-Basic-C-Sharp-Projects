using System;


namespace OptionalParamatersExample
{
    // create a class to handle the math operations
    class MathOperations
    {   
        // create a method that takes two integers as paramaters,
        // with the second one being optional and having a default value of 0
        public int DoMath(int num1, int num2 = 0)
        {
            // add the two numbers together and return the result
            int result = num1 + num2;
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // prompt the user to enter the first number
            Console.WriteLine("Please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            // prompt the user to enter the second number (optional)
            Console.WriteLine("Please enter the second number (optional):");

            // Read the user input as a string and try to parse it as an integerr
            // If the parsing failes, num2 will be assigned the default value of 0
            int num2;
            int.TryParse(Console.ReadLine(), out num2);

            // call the DoMath method, passing in the two numbers (or just num1 if num2 is 0)
            int result = math.DoMath(num1, num2);

            // Display the result to the screen
            Console.WriteLine("The result of the math operation is: " + result);

            // wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
