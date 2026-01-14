using System;

namespace VoidMethodAssignment
{
    // This class contains a void method that performs both a math operation and displays values to the console
    public class MathDisplay
    {
        // This void method takes two integers as parameters
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Performs a math operation on the first integer
            int result = firstNumber * 2;

            // Then displays the result of the math operation
            Console.WriteLine("Result of math operation on first number: " + result);

            // This will display the second integer to the screen
            Console.WriteLine("Second number passed in: " + secondNumber);
        }
    }
}
