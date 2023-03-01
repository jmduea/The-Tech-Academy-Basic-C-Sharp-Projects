using System;


namespace MainMethodAssignment
{
    public class MathOperations
    {
        // method that takes in an integer, creates a math operation for this integer, then returns the answer as an integer
        public int DoMath(int num)
        {
            // create a math operation for the input integer (in this case, add 5 to it)
            int result = num + 5;
            // return the result
            return result;
        }

        // method that takes in a decimal, creates a different math operation for it, then returns the answer as an integer
        public int DoMath(decimal num)
        {
            // create a math operation for input decimal (in this case, multiply by 2)
            decimal result = num * 2;
            // cast the decimal result to an integer and return it
            return (int)result;
        }

        // method that takes in a string, converts it to an integer if possible, does a different math operation on it, then returns the answer as an integer
        public int DoMath(string numStr)
        {
            int num;
            // try to convert the string input to an integer
            if (int.TryParse(numStr, out num))
            {
                // create a math operation for the input integer (in this case, subtract 3)
                int result = num - 3;
                // return the result
                return result;
            }    
            else
            {
                // if the input string cannot be converted to an integer, return -1
                return -1;
            }
        }
    }
}
