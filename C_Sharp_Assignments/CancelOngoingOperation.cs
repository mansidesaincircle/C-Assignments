using System;
using System.Threading;
using System.Threading.Tasks;

class CancelOngoingOperation
{
    static async Task Main()
    {
        // Create a CancellationTokenSource to manage the cancellation
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        // Wait for user input to cancel the operation
        Console.WriteLine("Press 'C' to cancel the operation.");

        var token = cancellationTokenSource.Token;
        // Start the asynchronous operation
        var task = PerformAsyncOperation(token);

        
        if (Console.ReadKey().Key == ConsoleKey.C)
        {
            Console.WriteLine("C Me");
            // Cancel the operation by signaling the cancellation token
            cancellationTokenSource.Cancel();     
        }

        try
        {
            Console.WriteLine("Try Me");
            await task; // Await the task to check for cancellation or completion
            Console.WriteLine("Operation completed successfully.");
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Bye");
            Console.WriteLine("Operation was canceled.");
        }
    }

    static async Task PerformAsyncOperation(CancellationToken cancellationToken)
    {
        for (int i = 0; i < 10; i++)
        {
            // Check if cancellation has been requested
            if (cancellationToken.IsCancellationRequested)
            {
                Console.WriteLine("Hiee");
                // Throw an OperationCanceledException to indicate cancellation
                throw new OperationCanceledException();
            }

            // Simulate some work (e.g., a time-consuming operation)
            Console.WriteLine($"Working... Iteration {i + 1}");
            await Task.Delay(1000);
        }
    }
}
