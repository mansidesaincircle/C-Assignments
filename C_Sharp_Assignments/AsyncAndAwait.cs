using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        try
        {
            // Execute a series of asynchronous tasks
             await ExecuteTask("Task 1", 4000, false);
             ExecuteTask("Task 2", 2000, false);
             await ExecuteTask("Task 3", 5000, true);
             ExecuteTask("Task 4", 1000, false);
        }
        catch (Exception ex)
        {
            // Catch and handle exceptions that occur during task execution
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Asynchronously execute a task with a specified name, delay, and exception condition
    static async Task ExecuteTask(string taskName, int delayMilliseconds, bool throwException)
    {
        // Display a message indicating the start of the task
        Console.WriteLine($"{taskName} Starting");

        // Simulate asynchronous work by delaying for the specified time
        await Task.Delay(delayMilliseconds);

        // Display a message indicating the completion of the task
        Console.WriteLine($"{taskName} Completed");

        // If the throwException flag is true, simulate encountering an error during the task
        if (throwException)
        {
            // Throw an exception with a specific message
            throw new Exception($"{taskName} encountered an error...");
        }
    }
}
