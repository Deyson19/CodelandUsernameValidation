// See https://aka.ms/new-console-template for more information
/*Codeland Username Validation
https://coderbyte.com/editor/Codeland%20Username%20Validation:Csharp
Have the function CodelandUsernameValidation(str) take the str parameter 
being passed and determine if the string is a valid username according 
to the following rules:

//* 1. The username is between 4 and 25 characters.
//* 2. It must start with a letter.
//* 3. It can only contain letters, numbers, and the underscore character.
//* 4. It cannot end with an underscore character.

If the username is valid then your program should return the string true, otherwise return the string false.*/

using System.Text.RegularExpressions;
using CodelandUsernameValidation;

public static class Program
{
    private static void Main(string[] args)
    {
        static string CodelandUsernameValidation(string str)
        {
            var validation = new ValidationProvider();
            // code goes here  
            var start = validation.startWithLetter(str);
            var userNameRange = validation.userNameRange(str);
            var endUnder = validation.endWithUnderScore(str);
            var isValidWord = validation.lettersNumberAndUnderCore(str);

            if (start && userNameRange && endUnder && isValidWord)
            {
                return "true";
            }
            return "false";
        }

        Console.WriteLine("Write Something");
        Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    }



}