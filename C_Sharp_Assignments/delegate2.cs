/*2) Write a program to combine two delegates.
Sample Output:
First Delegate:
Hello
Second delegate:
welcome
MultiDelegate:
Hello
Welcome
*/
using System;

// Declare the delegate
public delegate void CombineDelegate();

public class DelegateCombining
{
    // First method to be used as a delegate target
    public static void DelegateMethod1()
    {
        Console.WriteLine("Hello");
    }

    // Second method to be used as a delegate target
    public static void DelegateMethod2()
    {
        Console.WriteLine("Welcome");
    }

    public static void Main()
    {
        // Using the first delegate
        Console.WriteLine("First Delegate:");
        CombineDelegate del1 = new CombineDelegate(DelegateMethod1);
        del1(); // Invoking the delegate, which calls DelegateMethod1

        // Using the second delegate
        Console.WriteLine("Second Delegate:");
        CombineDelegate del2 = new CombineDelegate(DelegateMethod2);
        del2(); // Invoking the delegate, which calls DelegateMethod2

        // Combining two delegates
        Console.WriteLine("After Combining two Delegates:");
        CombineDelegate combinedel;
        combinedel = del1 + del2; // Combining del1 and del2
        combinedel(); // Invoking the combined delegate, which calls both DelegateMethod1 and DelegateMethod2

        // Alternative syntax using method group conversion
        // Uncomment the code below to see an alternative way of declaring and combining delegates

        // CombineDelegate del1, del2, combinedel;
        // del1 = DelegateMethod1;
        // del1(); // Invoking the delegate, which calls DelegateMethod1
        // del2 = DelegateMethod2;
        // del2(); // Invoking the delegate, which calls DelegateMethod2
        // combinedel = del1 + del2; // Combining del1 and del2
        // combinedel(); // Invoking the combined delegate, which calls both DelegateMethod1 and DelegateMethod2
    }
}
