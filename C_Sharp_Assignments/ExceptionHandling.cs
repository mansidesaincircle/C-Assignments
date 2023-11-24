using System;
using System.IO;

public class ExceptionHandling
{
    public static void Main()
    {
        while(true)
        {
            int choice;
            string userInput;
            Console.WriteLine("\n1:Divide by zero");
            Console.WriteLine("2:Array out of bound");
            Console.WriteLine("3.Null Reference Exception ");
            Console.WriteLine("4:File Not Found");
            Console.WriteLine("5.Exit:");
            Console.WriteLine("\nEnter Choice:");
            userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            switch (choice)
            {
                case 1:
                    // take first int input from user
                    Console.WriteLine("Enter first number:");
                    int firstNumber = int.Parse(Console.ReadLine());
                    // take second int input from user
                    Console.WriteLine("Enter second number:");
                    int secondNumber = int.Parse(Console.ReadLine());
                    try
                    {
                        // code that may raise raise an exception 
                        int divisionResult = firstNumber / secondNumber;
                        Console.WriteLine("Division of two numbers is: " + divisionResult);
                    }
                    // this catch block gets executed only when an exception is raised
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("An exception occurred: " + e.Message);
                    }
                    finally           
                    {
                        // this code is always executed whether of exception occurred or not 
                        Console.WriteLine("Sum of two numbers is: " + (firstNumber + secondNumber));
                    }
                    break;

                case 2:
                    int[] numbers = { 1, 2, 3, 4, 5 };
                    int index = 10; // Index that is out of bounds

                    try
                    {
                        int value = numbers[index]; // Attempt to access the element
                        Console.WriteLine("Value: " + value); // This will not be executed
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("An IndexOutOfRangeException occurred. " + e.Message);
                    }
                    break;

                case 3:
                    string text = null;

                    try
                    {
                        int length = text.Length; // This line will throw a NullReferenceException
                        Console.WriteLine("Length: " + length);
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine("NullReferenceException: " + ex.Message);
                    }
                    break;

                case 4:
                   
                    try
                    {
                        string path = "nonexistentfile.txt";
                        using (FileStream fileStream = File.OpenRead(path)) // This line can throw a FileNotFoundException
                        {
                            // Read from the file
                        }
                    }
                    catch (FileNotFoundException ex)
                    {
                        Console.WriteLine("FileNotFoundException: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Other Exception: " + ex.Message);
                    }
                    break;

                case 5:
                    return;

                default:
                    Console.WriteLine("Invalid Exception.....");
                    break;


            }


        }

    }
}