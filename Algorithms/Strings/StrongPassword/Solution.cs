using System;
using System.Linq;

namespace StrongPassword
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string password = Console.ReadLine();

            Console.WriteLine(MinimumNumber(password));
        }

        private static int MinimumNumber(string password)
        {
            int count = 0;

            char[] numbers = "0123456789".ToCharArray();
            char[] lower_case = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            char[] upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] special_characters = "!@#$%^&*()-+".ToCharArray();

            int missingCharacters = 6 - password.Length;

            if (password.Intersect(numbers).Count() == 0)
                count++;

            if ((password.Intersect(lower_case).Count() == 0))
                count++;

            if ((password.Intersect(upper_case).Count() == 0))
                count++;

            if ((password.Intersect(special_characters).Count() == 0))
                count++;

            if (count > missingCharacters)
                return count;
            else
                return missingCharacters;
        }
    }
}
