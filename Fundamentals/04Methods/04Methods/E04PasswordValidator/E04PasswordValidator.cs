using System;

namespace E04PasswordValidator
{
    class PasswordValidator
    {
        static void Main()
        {
            string password = Console.ReadLine();
            char[] checkArray = password.ToCharArray();

            bool failLength = CheckPasswordLength(checkArray);
            bool failDigitQty = CheckPasswordDigitsQty(checkArray);
            bool failLettersAndDigits = CheckPasswordLettersAndDigits(checkArray);

            if (failLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (failLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (failDigitQty)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (!failLength && !failLettersAndDigits && !failDigitQty)
            {
                Console.WriteLine("Password is valid");
            }

        }
        public static bool CheckPasswordLength(char[] checkLength)
        {

            if (checkLength.Length >= 6)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckPasswordDigitsQty(char[] checkDigit)
        {
            int digitCount = 0;

            foreach (var item in checkDigit)
            {
                if ((int)item > 47 && (int)item < 58)
                {
                    digitCount++;
                }
            }

            if (digitCount >= 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckPasswordLettersAndDigits(char[] checkDigit)
        {
            int symbol = 0;

            foreach (var item in checkDigit)
            {
                if (!(char.IsLetterOrDigit(item)))
                {
                    symbol++;
                }
            }

            if (symbol > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
