using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    private static List<Task> tasks = new List<Task>();
    private static CancellationTokenSource cts = new CancellationTokenSource();

    public static void Main()
    {
        // Scenario 1: Show a dialog for 15 seconds or until manually closed
        ShowDialog("This is a dialog", TimeSpan.FromSeconds(15));
        // Simulate user manually closing the dialog after 5 seconds
        Thread.Sleep(TimeSpan.FromSeconds(5));
        CloseDialog();

        // Scenario 2: Start a long operation and abort it if it lasts more than 5 seconds
        StartLongOperation(TimeSpan.FromSeconds(7));

        // Scenario 3: Show an "In Progress" popup for an operation
        ShowInProgressPopup();
        // Simulate the operation finishing before 1 second
        Thread.Sleep(TimeSpan.FromMilliseconds(500));
        // The popup will not be shown because the operation finished quickly
        HideInProgressPopup();

        // Wait for all tasks to complete
        Task.WaitAll(tasks.ToArray());
        Console.WriteLine("All tasks completed.");
    }

    // Scenario 1: Show a dialog for a specified duration or until manually closed
    public static void ShowDialog(string message, TimeSpan duration)
    {
        var task = Task.Run(() =>
        {
            Console.WriteLine("Showing dialog: " + message);
            Thread.Sleep(duration);
            if (!cts.Token.IsCancellationRequested)
            {
                Console.WriteLine("Dialog closed automatically.");
            }
        });
        tasks.Add(task);
    }

    public static void CloseDialog()
    {
        cts.Cancel();

        Console.WriteLine("Dialog closed manually.");
    }

    // Scenario 2: Start a long operation and abort it if it lasts more than a specified duration
    public static void StartLongOperation(TimeSpan duration)
    {
        var task = Task.Run(() =>
        {
            Console.WriteLine("Starting long operation...");
            Thread.Sleep(duration);
            if (!cts.Token.IsCancellationRequested)
            {
                Console.WriteLine("Long operation completed.");
            }
            else
            {
                Console.WriteLine("Long operation aborted.");
            }
        });
        tasks.Add(task);
    }

    // Scenario 3: Show an "In Progress" popup for an operation
    public static void ShowInProgressPopup()
    {
        var task = Task.Run(() =>
        {
            Thread.Sleep(TimeSpan.FromSeconds(1));
            if (!cts.Token.IsCancellationRequested)
            {
                Console.WriteLine("Showing 'In Progress' popup...");
            }
        });
        tasks.Add(task);
    }

    public static void HideInProgressPopup()
    {
        cts.Cancel();
        Console.WriteLine("Hiding 'In Progress' popup.");
    }
}