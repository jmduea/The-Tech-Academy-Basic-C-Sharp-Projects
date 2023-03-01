using System;

namespace ConsoleApp
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            //while loop example
            Console.WriteLine("Example of while loop:");
            int num1 = 0;
            while (num1 < 5) // repeat the loop until num1 is no longer less than 5
            {
                Console.WriteLine("num1 = " + num1);
                num1++; // increment num1 by 1
            }

            // do while loop example
            Console.WriteLine("\nExample of do while Loop:");
            int num2 = 0;
            do // execute the loop at least once
            {
                Console.WriteLine("num2 = " + num2);
                num2++; // increment num2 by 1
            } while (num2 < 5); //repeat the loop until num2 is no longer less than 5
            Console.ReadLine();
        }
    }
}
