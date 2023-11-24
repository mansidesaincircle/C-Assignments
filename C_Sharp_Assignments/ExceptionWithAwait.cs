using System;
using System.Threading.Tasks;

class ExceptionWithAwait
{
    static async Task Main()
    {
        try
        {
            // Call the DivideAsync method and await the result
            double result = await DivideAsync(10, 1);
            Console.WriteLine($"Result: {result}");
        }
        catch (Exception ex)
        {
            // Catch any exceptions that may occur and print an error message
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static async Task<double> DivideAsync(double dividend, double divisor)
    {
        if (divisor == 0)
        {
            // Throw an exception if trying to divide by zero
            throw new InvalidOperationException("Cannot divide by zero.");
        }

        // Simulate an asynchronous operation (e.g., a network request) with a delay
        await Task.Delay(5000);

        // Perform the division and return the result
        return dividend / divisor;
    }
}
