using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class GeneratingFormLetter
    {
        public static void FormLetter()

        {
            Console.Clear();
            while (true)
            {
                
                Console.WriteLine("WELCOME TO BIRTHDAY FORM LETTER.\n");
                String name, present, yourName;
                int age;
                Console.Write("What is the name of the gift giver? ");
                name = Console.ReadLine();
                Console.Write("What is the gift? ");
                present = Console.ReadLine();
                Console.Write("How old were you on your birthday? ");
                age = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is your name? ");
                yourName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Dear {0}, ", name);
                Console.WriteLine();
                Console.Write("Thank you for the {0}. ", present);
                Console.WriteLine("I really like it. I can't believe ");
                Console.Write("I'm already " + age + " years old, but ");
                Console.WriteLine("it doesn't feel that much different than ");
                Console.WriteLine("being " + (age - 1) + ". ");
                Console.WriteLine();
                Console.WriteLine("Sincerely, ");
                Console.WriteLine();
                Console.WriteLine(yourName);

                Console.WriteLine();
                Console.WriteLine("Press any key to return to the menu...");

                Console.Write("Do you want to create another birthday form letter (y/n)? ");
                char input = Convert.ToChar(Console.ReadLine());

                if (input != 'y')
                {
                    Console.WriteLine("Exiting the program.");
                    break;
                }
                Console.Clear() ;

            }
        }
    }
}
