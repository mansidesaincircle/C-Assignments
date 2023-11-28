using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Simulate a long operation (e.g., fetching data)
        var longOperationTask = SimulateLongOperation();

        // Show the "In Progress" popup after 1 second
        var delayTask = Task.Delay(1000);

        // Wait for either the long operation to complete or the 1-second delay
        var completedTask = await Task.WhenAny(longOperationTask, delayTask);

        // If the long operation completed before the 1-second delay
        if (completedTask == longOperationTask)
        {
            // Do nothing, as the operation has already finished
        }
        else
        {
            // Show the "In Progress" popup
            ShowInProgressPopup();

            // Wait for the long operation to complete
            await longOperationTask;

            // Close the "In Progress" popup
            CloseInProgressPopup();
        }

        // Continue with the rest of your application logic
        Console.WriteLine("Application logic continues...");

        // Keep the console window open (for console application)
        Console.ReadLine();
    }

    static async Task SimulateLongOperation()
    {
        // Simulate a long operation (e.g., fetching data)
        Console.WriteLine("Long operation started...");
        await Task.Delay(7000); // Simulating a 7-second long operation
        Console.WriteLine("Long operation completed.");
    }

    static void ShowInProgressPopup()
    {
        // Code to show the "In Progress" popup
        Console.WriteLine("Showing In Progress Popup...");
    }

    static void CloseInProgressPopup()
    {
        // Code to close the "In Progress" popup
        Console.WriteLine("Closing In Progress Popup...");
    }
}
