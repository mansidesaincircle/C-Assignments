//Lambda Operation

using Newtonsoft.Json;   //library to manage json object
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Emp
{
    //Create a list of Emp class and perform operation using Lambda.
    private int id;
    public int Id
    {
        get;
        set;
    }
    private string firstName;
    public string FirstName
    {
        get;
        set;
    }
    private string lastName;
    public string LastName
    {
        get;
        set;
    }
    
    public Dept Department { get; set; }
    public enum Dept 
    {
        IT,
        HR,
        Payroll,
        Engineering,
        Admin,
        Sales
    }
    public Gender EmployeeGender { get; set; }
    public enum Gender 
    {
        Male,
        Female
    }
    public Country EmployeeCountry { get; set; }
    public enum Country
    {
        USA,
        Canada,
        UK,
        India
    }
    private int salary;
    public int Salary { get; set; }
    
    private DateTime dob;
    public DateTime DOB { get; set; }
}

class MainMethod
{
    static void Main(String [] args)
    {
        // Creating an List<T> of 10 Employee 
        List<Emp> EmpData = new List<Emp>()
        {
            new Emp
            {
                Id = 101,
                FirstName = "Mansi",
                LastName = "Desai",
                Department = Emp.Dept.IT,
                EmployeeGender = Emp.Gender.Female,
                EmployeeCountry = Emp.Country.India,
                Salary = 35000,
                DOB=new DateTime(2000,12,31)
            
            },
            new Emp
            {
                Id = 102,
                FirstName = "Kunal",
                LastName = "Desai",
                Department = Emp.Dept.Admin,
                EmployeeGender = Emp.Gender.Male,
                EmployeeCountry = Emp.Country.UK,
                Salary = 50000,
                DOB = new DateTime(2001, 04, 24)

            },
            new Emp
            {
                Id = 103,
                FirstName = "Shalaka",
                LastName = "Kamble",
                Department = Emp.Dept.Sales,
                EmployeeGender = Emp.Gender.Female,
                EmployeeCountry = Emp.Country.UK,
                Salary = 40000,
                DOB=new DateTime(2006,2,2)

            },
            new Emp
            {
                Id = 104,
                FirstName = "Santosh",
                LastName = "Yadav",
                Department = Emp.Dept.Engineering,
                EmployeeGender = Emp.Gender.Male,
                EmployeeCountry = Emp.Country.USA,
                Salary = 55000,
                DOB=new DateTime(1998,12,18)

            },

            new Emp
            {
                Id = 105,
                FirstName = "Sakshi",
                LastName = "Joshi",
                Department = Emp.Dept.Payroll,
                EmployeeGender = Emp.Gender.Female,
                EmployeeCountry = Emp.Country.Canada,
                Salary = 65000,
                DOB=new DateTime(1996,5,15)

            },
            new Emp
            {
                Id = 106,
                FirstName = "Sujal",
                LastName = "Kulkarni",
                Department = Emp.Dept.IT,
                EmployeeGender = Emp.Gender.Male,
                EmployeeCountry = Emp.Country.India,
                Salary = 23000,
                DOB=new DateTime(2002,6,22)

            },
            new Emp
            {
                Id = 107,
                FirstName = "Ayesha",
                LastName = "Kale",
                Department = Emp.Dept.HR,
                EmployeeGender = Emp.Gender.Female,
                EmployeeCountry = Emp.Country.Canada,
                Salary = 250000,
                DOB=new DateTime(1995,6,11)

            },
            new Emp
            {
                Id = 108,
                FirstName = "Aryan",
                LastName = "Rane",
                Department = Emp.Dept.Admin,
                EmployeeGender = Emp.Gender.Male,
                EmployeeCountry = Emp.Country.USA,
                Salary = 250000,
                DOB=new DateTime(1992,5,21)

            },
            new Emp
            {
                Id = 109,
                FirstName = "Ritika",
                LastName = "Rokade",
                Department = Emp.Dept.Engineering,
                EmployeeGender = Emp.Gender.Female,
                EmployeeCountry = Emp.Country.India,
                Salary = 35000,
                DOB=new DateTime(2002,11,2)

            },
            new Emp
            {
                Id = 110,
                FirstName = "Mavi",
                LastName = "Desai",
                Department = Emp.Dept.Engineering,
                EmployeeGender = Emp.Gender.Female,
                EmployeeCountry = Emp.Country.USA,
                Salary = 48000,
                DOB=new DateTime(2001,6,22)

            }
        };

        
        while (true)
        {
            int choice;
            string userInput;
            Console.WriteLine("\n\n1.Find the max and min salary of male employee." +
                " Then display the employee details(Id, First name, last name and DOB)");
            Console.WriteLine("2.Create a new list for employee which contain data { ID, FullName and Gender only }.");
            Console.WriteLine("3.Create a new list for only female employees.");
            Console.WriteLine("4.Sort employee list based on Salary and Gender.");
            Console.WriteLine("5.Export data in All employee data in json file.");
            Console.WriteLine("6.Exit");
            Console.WriteLine("\nEnter Choice:");
            userInput = Console.ReadLine();
            
                choice = Convert.ToInt32(userInput);
            switch (choice)
            {
                case 1:
                    //1.find the max salary 
                    int MaxSalary = EmpData.Where(emp => emp.EmployeeGender == Emp.Gender.Male).Max(emp => emp.Salary);
                    Console.WriteLine($"Maximum Salary of Male Employees is:{ MaxSalary}" + "\n");

                    //2.find the min salary
                    int MinSalary = EmpData.Where(emp => emp.EmployeeGender == Emp.Gender.Male).Min(emp => emp.Salary);
                    Console.WriteLine($"Minimum Salary of Male Employees is:{ MinSalary}" + "\n");


                    //3.find the details id,fname,lname and DOB of maxSalaryEmployee
                    var maleEmployeeWithMaxSalary = EmpData
                        .Where(emp => emp.EmployeeGender == Emp.Gender.Male && emp.Salary == MaxSalary)
                        .FirstOrDefault();
                    if (maleEmployeeWithMaxSalary != null)
                    {
                        Console.WriteLine("Details of Male Employee with Maximum Salary:");
                        Console.WriteLine($"ID: {maleEmployeeWithMaxSalary.Id}");
                        Console.WriteLine($"First Name: {maleEmployeeWithMaxSalary.FirstName}");
                        Console.WriteLine($"Last Name: {maleEmployeeWithMaxSalary.LastName}");
                        Console.WriteLine($"DOB: {maleEmployeeWithMaxSalary.DOB}" + "\n");
                    }

                    //3.find the details id,fname,lname and DOB of minSalaryEmployee
                    var maleEmployeeWithMinSalary = EmpData
                        .Where(emp => emp.EmployeeGender == Emp.Gender.Male && emp.Salary == MinSalary)
                        .FirstOrDefault();

                    if (maleEmployeeWithMinSalary != null)
                    {
                        Console.WriteLine("Details of Male Employee with Minimum Salary:");
                        Console.WriteLine($"ID: {maleEmployeeWithMinSalary.Id}");
                        Console.WriteLine($"First Name: {maleEmployeeWithMinSalary.FirstName}");
                        Console.WriteLine($"Last Name: {maleEmployeeWithMinSalary.LastName}");
                        Console.WriteLine($"DOB: {maleEmployeeWithMinSalary.DOB}" + "\n");
                    }
                    break;

                case 2:
                    //Create a new list for employee which contain data { ID, FullName and Gender only }.

                    var newEmployeeList = EmpData.Select(emp => new
                    {
                        ID = emp.Id,
                        FullName = $"{emp.FirstName} {emp.LastName}",
                        Gender = emp.EmployeeGender
                    }).ToList();

                    foreach (var employee in newEmployeeList)
                    {
                        Console.WriteLine($"ID: {employee.ID}, FullName: {employee.FullName}, Gender: {employee.Gender}");
                    }
                    break;

                case 3:
                    //Create a new list for only female employees.
                    var femaleEmployee = EmpData.Where(emp => emp.EmployeeGender == Emp.Gender.Female).ToList();
                    foreach (var employee in femaleEmployee)
                    {
                        Console.WriteLine($"ID: {employee.Id}, FullName: {employee.FirstName}, Gender: {employee.EmployeeGender}");
                    }
                    break;

                case 4:
                    //Sort employee list based on Salary and Gender.
                    var sortBySalary = EmpData.OrderByDescending(emp => emp.Salary);
                    foreach (var employee in sortBySalary)
                    {
                        Console.WriteLine($"ID: {employee.Id}, FullName: {employee.FirstName},Salary:{employee.Salary}");
                    }
                    Console.WriteLine("");
                    var sortByGender = EmpData.OrderByDescending(emp => emp.EmployeeGender);
                    foreach (var employee in sortByGender)
                    {
                        Console.WriteLine($"ID: {employee.Id}, FullName: {employee.FirstName},Gender:{employee.EmployeeGender}");
                    }

                    break;

                case 5:
                    //Export Data of all employess into json file.
                    string filename = "Employee.json";
                    string jsonstring = JsonConvert.SerializeObject(EmpData);
                    //Serialization is converting .net object such as string into json format
                    File.WriteAllText(filename, jsonstring);
                    Console.WriteLine("Data has been exported to employees.json.");
                    // Console.WriteLine(File.ReadAllText(filename));
                    break;

                case 6:
                   return;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;

            }
        }
       
        
       
        

        

        
        


    }
}
