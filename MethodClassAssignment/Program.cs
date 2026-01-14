using System;

namespace VoidMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Part 1: This instantiates the MathDisplay class
            MathDisplay mathDisplay = new MathDisplay();

            // Part 2: This calls the method using positional arguments
            mathDisplay.DoMath(5, 10);

            // Part 3: This calls the method using the named arguments
            mathDisplay.DoMath(firstNumber: 7, secondNumber: 20);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
