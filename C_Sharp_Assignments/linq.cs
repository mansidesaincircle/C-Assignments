using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    private int Id;
    public int id
    {
        get;
        set;
    }

    private string Fname;
    public string fname
    {
        get;
        set;
    }

    private int Age;
    public int age
    {
        get;
        set;
    }

    private string Designation;
    public string designation
    {
        get;
        set;
    }

}

class MainMethod
{
    static public void Main()
    {
        List<Employee> employee = new List<Employee>
        {
            new Employee
            {
                id=101,
                fname="ruhi",
                age=15,
                designation="student"
            },
            new Employee
            {
                id=103,
                fname="tara",
                age=28,
                designation="employee"
            },
            new Employee
            {
                id=103,
                fname="ayesha",
                age=25,
                designation="developer"
            },
            new Employee
            {
                id=104,
                fname="bani",
                age=45,
                designation="hr"
            },
            new Employee
            {
                id=105,
                fname="neha",
                age=34,
                designation="manager"
            },
            new Employee
            {
                id=106,
                fname="kunal",
                age=25,
                designation="sr.developer"
            }
         };


        while (true)
        {
            int choice;
            string userInput;
            Console.WriteLine("\n1.Print names of employees whose name length is 4");
            Console.WriteLine("2.Order by objects and ordering: order by employee age");
            Console.WriteLine("3.Objects Condition and Ordering: Length == 4 and order by employees age.");
            Console.WriteLine("4:Extracting Properties from Objects in a new collection");
            Console.WriteLine("5.Exit");
            Console.WriteLine("\nEnter Choice:");
            userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            switch (choice)
            {
                case 1:
                    //print names of employees whose name length is 4
                    Console.WriteLine("Names of Employees whose name length is 4:");
                    IEnumerable<Employee> Query1 =
                        from emp in employee
                        where emp.fname.Length == 4
                        select emp;
                    foreach (Employee empl in Query1)
                    {
                        Console.WriteLine(empl.fname);
                    }
                    break;

                case 2:
                    //order by objects and ordering: order by employee age
                    Console.WriteLine("Order by employee age:");
                    IEnumerable<Employee> Query2 = employee.OrderBy(empl => empl.age);
                    foreach (Employee empl in Query2)
                    {
                        Console.WriteLine("{0} - {1}", empl.fname, empl.age);
                    }
                    break;

                case 3:
                    //Objects Condition and Ordering: Length == 4 and order by employees age.
                    IEnumerable<Employee> Query3 =
                        from emp in employee
                        where emp.fname.Length == 4
                        orderby emp.age
                        select emp;
                    Console.WriteLine("Name:\tAge:");
                    foreach (Employee empl in Query3)
                    {
                        Console.WriteLine("{0} - {1}", empl.fname, empl.age);
                    }
                    break;

                case 4:
                    //Extracting Properties from Objects in a new collection
                    List<string> empDesig = employee.Select(empl => empl.designation).ToList();
                    Console.WriteLine("Designation:");
                    foreach (string empl in empDesig)
                    {
                        Console.WriteLine(empl);
                    }
                    break;

                case 5:
                    return;

                default:
                    Console.Write("Invalid Choice...");
                    break;

            }


        }    

    }
}
/*
Obtain the data source.

Create the query.

Execute the query.
*/