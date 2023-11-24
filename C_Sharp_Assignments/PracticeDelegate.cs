using System;

public delegate void AddDelegate(int num1, int num2);
public delegate string SayDelegate(string str);

public class Program
{
   // public static AddDelegate AddNumber { get;  set; }

    public void AddNumber(int a, int b)                    //non-static method
    {
        int sum;
        sum = a + b;
        Console.WriteLine(sum);
    }

    public static string SayMsg(string str)
    {
        return str;
    }

    public static void Main()
    {
        Program obj = new Program();
        AddDelegate del1 = new AddDelegate(obj.AddNumber);    //why obj.AddNumber because we are accessing non-static method from static method
        del1(100, 50); //Or del.Invoke(100,50);
        SayDelegate del2 = new SayDelegate(Program.SayMsg);
        string str=del2("Hello");  //or del.Invoke("hello");
        Console.WriteLine(str);
    }
}