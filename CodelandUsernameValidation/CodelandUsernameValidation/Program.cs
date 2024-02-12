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

public class Program
{
    private static void Main(string[] args)
    {
        static string CodelandUsernameValidation(string str)
        {

            // code goes here  
            var startWith = startWithLetter(str);
            var _userNameRange = userNameRange(str);
            var endUnder = endWithUnderScore(str);
            var isValidWord = lettersNumberAndUnderCore(str);

            if (startWith && _userNameRange && endUnder && isValidWord)
            {
                return "true";
            }
            return "false";
        }

        Console.WriteLine("Escribe algo");
        Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
    }
    //2. It must start with a letter.
    static bool startWithLetter(string value) => Char.IsLetter(value[0]);
    static bool endWithUnderScore(string value)
    {
        // 4. It cannot end with an underscore character.
        return !Char.IsLetter(value[value.Length - 1]);
    }
    static bool lettersNumberAndUnderCore(string value)
    {
        //*3. It can only contain letters, numbers, and the underscore character.
        foreach (var c in value)
        {
            if (!Char.IsLetter(c) && !Char.IsNumber(c) && c != '_')
            {
                return false;
            }
        }
        return true;

    }
    static bool userNameRange(string value)
    {
        //* 1. The username is between 4 and 25 characters.
        if (value.Length >= 4 && value.Length <= 25)
        {
            Console.WriteLine($"{value.Length} is within range");
            return true;
        }
        Console.WriteLine($"{value.Length} is not in range");
        return false;
    }
}