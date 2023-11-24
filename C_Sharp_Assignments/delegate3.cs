using System;

public class Calculator
{
    public event EventHandler<int> AdditionPerformed;
    public event EventHandler<int> SubtractionPerformed;

    public int Add(int a, int b)
    {
        int result = a + b;                        // Calculate the addition result (3)
        AdditionPerformed?.Invoke(this, result);   // Raise the AdditionPerformed event (4)
        return result;                            // Return the addition result (7)
    }

    public int Subtract(int a, int b)
    {
        int result = a - b;                             // Calculate the subtraction result (10)
        SubtractionPerformed?.Invoke(this, result);     // Raise the SubtractionPerformed event (11)
        return result;                                 // Return the subtraction result (14)
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of the Calculator class (1)
        Calculator calculator = new Calculator();

        calculator.AdditionPerformed += (sender, result) =>
        {
            Console.WriteLine($"Addition result: "); // Display the addition result (5)
        };

        calculator.SubtractionPerformed += (sender, result) =>
        {
            Console.WriteLine($"Subtraction result: "); // Display the subtraction result (12)
        };

        int num1 = 10;
        int num2 = 20;

        int sum = calculator.Add(num1, num2);                  // Perform addition and get the result (2)
        Console.WriteLine(sum);                                // Display the addition result (8)
        int difference = calculator.Subtract(num1, num2);       // Perform subtraction and get the result (9)
        Console.WriteLine(difference);                         // Display the subtraction result (15)
    }
}
