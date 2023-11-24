using System;
using System.Text.RegularExpressions;

public class CheckPassword
{
    public static void Main()
    {
        //user input
        string userInput;
        Console.WriteLine("Enter Password:");
        userInput = Console.ReadLine();
        //pattern to check the password
        string pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$";
        //class Regex represents an immutable regular expression.
        Regex re = new Regex(pattern);
        ///The IsMatch method is used to validate a string or
                //to ensure that a string conforms to a particular pattern.
        if (re.IsMatch(userInput))
        {
            Console.WriteLine(userInput + " Matches the given Regrex.");
        }
        else
        {
            Console.WriteLine(userInput + " does not Matches the given Regrex.");

        }

    }
}
/*
  ^ :start of the string
  (?=.*?[A-Z]) : Atleast one upper case character.
  (?=.*?[a-z]) : Atleast one lower cae character.
  (?=.*?[0-9]) : Atleast one digit.
  (?=.*?[#?!@$%^&*-]) : Atleast one Special character.
  {8,} : has minimum length 8 and maximum length 20.
  $ : end of the string
 */
