using System;
using System.Runtime.CompilerServices;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckIfPasswordIsValid(password);
        }

        static void CheckIfPasswordIsValid(string password)
        {
            bool isCorrect = true;
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isCorrect = false;
            }

            if (ConsistLettersAndNumbers(password) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isCorrect = false;
            }

            if (ConsistAtLeastTwoDigits(password) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isCorrect = false;
            }

            if (isCorrect)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ConsistLettersAndNumbers(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char current = password[i];
                if (!((current >= 48 && current <= 57) || (current >= 65 && current <= 90) || (current >= 97 && current <= 122)))
                {  
                    return false;
                }

            }
            return true;
        }

        static int ConsistAtLeastTwoDigits(string password)
        {
            int counter = 0;

            for (int i = 0; i < password.Length; i++)
            {
                int current = password[i];

                if (current >= 48 && current <= 57)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
