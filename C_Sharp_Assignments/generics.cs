using System;

public class GenericProgram
{
    static void PrintArray<T>(T[]arr)
    {
       
        foreach(T element in arr)
        {
            Console.WriteLine(element);
        }
    }

    public static void Main()
    {
        int[] number = { 10, 20, 30, 40, 50 };
        string[] color = { "red", "black", "blue", "yellow", "white", "grey" };
        Console.WriteLine("Printing Int array:");
        PrintArray(number);
        Console.WriteLine("Printing String array:");
        PrintArray(color);
    }
}

/*C# Generics allow us to create a single class or method that can be used with different types of data.
*/