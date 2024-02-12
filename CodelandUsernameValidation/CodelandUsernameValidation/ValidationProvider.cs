
namespace CodelandUsernameValidation
{
    public class ValidationProvider
    {
        public bool userNameRange(string value)
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
        //2. It must start with a letter.
        public bool startWithLetter(string value) => Char.IsLetter(value[0]);

        public bool lettersNumberAndUnderCore(string value)
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
        public bool endWithUnderScore(string value)
        {
            // 4. It cannot end with an underscore character.
            return !Char.IsLetter(value[value.Length - 1]);
        }
    }
}