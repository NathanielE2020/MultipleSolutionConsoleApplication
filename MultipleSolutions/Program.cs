using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("WELCOME TO MY MULTIPLE SOLUTIONS CONSOLE APPLICATION\n");
                Console.WriteLine("Choose a program to run:\n");
                Console.WriteLine("1. Guess the number game");
                Console.WriteLine("2. To-Do list");
                Console.WriteLine("3. Currency Exchange Calculator");
                Console.WriteLine("4. Simple Chatbot");
                Console.WriteLine("5. Simple Calculator");
                Console.WriteLine("6. Generating form letter");
                Console.WriteLine("7. Bank Account Management");
                Console.WriteLine("8 Temperature Converter");
                Console.WriteLine("9. Password generator");
                Console.WriteLine("10. Expense Tracker");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    case 1:
                        GuessTheNumberGame.Game();
                        break;
                    case 2:
                        To_Do_List.ToDo();
                        break;
                    case 3:
                        CurrencyExchangeCalculator.Exchange();
                        break;
                    case 4:
                        ChatBot.Chat();
                        break;
                    case 5:
                        SimpleCalculator.Calculate();
                        break;
                    case 6:
                        GeneratingFormLetter.FormLetter();
                        break;
                    case 7:
                        BankAccountManagement.Bank();
                        break;
                    case 8:
                        TemperatureConverter.Converter();
                        break;
                    case 9:
                        PasswordGenerator.Generate();
                        break;
                    case 10:
                        ExpensesTracker.Track();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;

                }

                Console.WriteLine("Press any key to return to the program selection menu...");
                Console.ReadKey();
                Console.Clear();
            }
           
        }
    }
}
