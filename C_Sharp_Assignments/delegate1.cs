/*1) Write a program to Use Delegate to Call 2 Methods within which First
 * method Prints to Console and Second Method Prints to File.*/

using System;
using System.IO;

// Declare the delegate
public delegate void PrintMessageDelegate(string msg);

public class DelegateProgram
{
    // Method to display a message in the console
    public static void displayIntoCommand(string str)
    {
        Console.WriteLine(str);
    }

    // Method to display a message in a file
    public static void displayIntoFile(string str)
    {
        string writeText = str;
        // Write the message to a file named "filename.txt"
        File.WriteAllText("filename.txt", writeText);
    }

    public static void Main()
    {
        // Instantiate the delegate and assign the first method
        PrintMessageDelegate del1 = new PrintMessageDelegate(displayIntoCommand);

        // Call the delegate, which in turn calls the first method
        del1("Display Message using Delegates in the console....");

        // Instantiate the delegate and assign the second method
        PrintMessageDelegate del2 = new PrintMessageDelegate(displayIntoFile);

        // Call the delegate, which in turn calls the second method
        del2("Display Message using Delegates in the file....");
    }
}
