using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class MainMethodAssignment
    {
        static void Main(string[] args)
        {
            // instantiate the MathOperations class
            MathOperations math = new MathOperations();

            // call the first method with an integer input
            int result1 = math.DoMath(10);
            Console.WriteLine($"Result 1: {result1}");

            // call the second method with a decimal input
            int result2 = math.DoMath(4.5M);
            Console.WriteLine($"Result 2: {result2}");

            // call the third method with a string input
            int result3 = math.DoMath("20");
            Console.WriteLine($"Result 3: {result3}");

            Console.ReadLine();
        }
    }
}
