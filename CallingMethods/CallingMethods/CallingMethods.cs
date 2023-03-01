using System;


namespace CallingMethods
{
    class CallingMethods
    {
        static void Main(string[] args)
        {
            // ask the user what number they want to do the math operation on
            Console.Write("Enter a number to perform math operations on: ");
            int num = int.Parse(Console.ReadLine());

            // create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // call each method in turn, passing the user input to the method
            int result1 = math.MultiplyByTwo(num);
            int result2 = math.AddTen(num);
            int result3 = math.SubtractFive(num);

            // display the returned integers to the screen
            Console.WriteLine($"Result 1: {result1}");
            Console.WriteLine($"Result 2: {result2}");
            Console.WriteLine($"Result 3: {result3}");
            
            Console.ReadLine();
        }
        
    }
}
