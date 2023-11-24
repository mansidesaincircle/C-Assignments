using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Start multiple asynchronous tasks concurrently
        Task1();
        Task2();
        Task3();
        Task4();

        // Allow the user to press Enter to keep the console window open
        Console.ReadLine();
    }

    // Define and execute Task 1 asynchronously
    public static async void Task1()
    {
        await Task.Run(() =>
        {
            // Display a message indicating the start of Task 1
            Console.WriteLine("Task 1 Starting");

            // Simulate work by sleeping the thread for 4000 milliseconds
            Thread.Sleep(4000);

            // Display a message indicating the completion of Task 1
            Console.WriteLine("Task 1 Completed");
        });
    }

    // Define and execute Task 2 asynchronously
    public static async void Task2()
    {
        await Task.Run(() =>
        {
            // Display a message indicating the start of Task 2
            Console.WriteLine("Task 2 Starting");

            // Simulate work by sleeping the thread for 2000 milliseconds
            Thread.Sleep(2000);

            // Display a message indicating the completion of Task 2
            Console.WriteLine("Task 2 Completed");
        });
    }

    // Define and execute Task 3 asynchronously
    public static async void Task3()
    {
        await Task.Run(() =>
        {
            // Display a message indicating the start of Task 3
            Console.WriteLine("Task 3 Starting");

            // Simulate work by sleeping the thread for 5000 milliseconds
            Thread.Sleep(5000);

            // Display a message indicating the completion of Task 3
            Console.WriteLine("Task 3 Completed");
        });
    }

    // Define and execute Task 4 asynchronously
    public static async void Task4()
    {
        await Task.Run(() =>
        {
            // Display a message indicating the start of Task 4
            Console.WriteLine("Task 4 Starting");

            // Simulate work by sleeping the thread for 1000 milliseconds
            Thread.Sleep(1000);

            // Display a message indicating the completion of Task 4
            Console.WriteLine("Task 4 Completed");
        });
    }
}
