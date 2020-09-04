using System;
using System.Linq;
using System.Text;

namespace FundTextProcessingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            StringBuilder validUsername = new StringBuilder();

            foreach (var username in usernames)
            {
                if (IsValidUsername(username))
                {
                    Console.WriteLine(username);
                }
            }
        }
        public static bool IsValidUsername(string username)
        {
            if (username.Length < 3 || username.Length > 16)
            {
                return false;
            }

            bool isvalid = true;

            for (int i = 0; i < username.Length; i++)
            {
                char curr = username[i];

                if (!(Char.IsLetterOrDigit(curr) || curr == '-' || curr == '_'))
                {
                    isvalid = false;
                    break;
                }

            }

            return isvalid;
        }
    }
}
