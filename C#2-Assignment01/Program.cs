using System;

namespace MathOperationConsoleApp
{
    // Create a class named MathOperations
    class MathOperations
    {
        // Create a void method that takes two integers as parameters
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer (add 5 in this example)
            int result = firstNumber + 5;

            // Display the second integer to the screen
            Console.WriteLine($"Second integer: {secondNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOperations = new MathOperations();

            // Call the method in the class, passing in two numbers (10 and 20)
            mathOperations.PerformMathOperation(10, 20);

            // Call the method in the class, specifying the parameters by name
            mathOperations.PerformMathOperation(firstNumber: 15, secondNumber: 30);

            // Keep the console window open to see the output
            Console.ReadLine();
        }
    }
}
