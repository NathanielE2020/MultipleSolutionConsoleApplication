using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class PasswordGenerator
    {
        public static void Generate()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO PASSWORD GENERATOR APP");

            while (true)
            {
                Console.Write("Enter the length of the password: ");
                int passwordLength = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Generated password: {GeneratePassword(passwordLength)}");

                Console.Write("Do you want to generate another password (y/n)? ");
                char input = Convert.ToChar(Console.ReadLine());

                if(input != 'y')
                {
                    Console.WriteLine("Exiting the password generator program.");
                    break;
                }
                Console.Clear();
            }
        }

        static string GeneratePassword(int length)
        {
            const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUWXYZ0123456789!@#$%^&*()-_=+,.";

            Random random = new Random();
            StringBuilder password = new StringBuilder();

            for(int i = 0; i < length; i++)
            {
                int index = random.Next(allowedChars.Length);
                password.Append(allowedChars[index]);
            }

            return password.ToString();
        }
    }
}
