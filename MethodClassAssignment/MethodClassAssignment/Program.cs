using System;

namespace MethodClassAssignment
{
    // Define a class called myClass
    class MyClass
    {
        // Define a void method called DoMath that takes two integers as parameters
        // The first integer is multiplied by 2 and the second integer is printed to the console
        public void DoMath(int firstNumber, int secondNumber)
        {
            int result = firstNumber * 2;
            Console.WriteLine($"The second number is: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an instance of MyClass
            MyClass myClass = new MyClass();

            // Call the DoMath method, passing in two numbers
            myClass.DoMath(3, 5);

            // Call the DoMath method, specify the paramaters by name
            myClass.DoMath(firstNumber: 7, secondNumber: 8);

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
