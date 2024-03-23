using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class CurrencyExchangeCalculator
    {
        public static void Exchange()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO CURRENCY EXCHANGE CALCULATOR.\n");

            do
            {
                Console.WriteLine("1. Convert USD to Naira.");
                Console.WriteLine("2. Convert Naira to USD.");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice (1 or 2): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting the conversion app");
                        return;
                    case 1:
                        ConvertUsdToNaira();
                        break;
                    case 2:
                        ConvertNairaToUsd();
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }

                Console.Write("Do you want to perform another conversion (y/n)? ");
                char input = Convert.ToChar(Console.ReadLine().ToLower());

                if (input != 'y')
                {
                    Console.WriteLine("Exiting currency exchange app");
                }
                Console.Clear();
            } while (true);
   

        }

        static void ConvertUsdToNaira()
        {
            Console.Write("Enter amount in US Dollar: ");
            double usdAmount = Convert.ToDouble(Console.ReadLine());
            //xchanger rate = 1 usd = 1200
            double exchangeRate = 1200;
            double nairaAmount = usdAmount * exchangeRate;
            char naireSign = '#';

            Console.WriteLine($"Amount in Naira: {naireSign}{nairaAmount:N2}");

        }

        static void ConvertNairaToUsd()
        {
            Console.Write("Enter amount in Naira: ");
            double nairaAmount = Convert.ToDouble(Console.ReadLine());

            double exchangeRate = 1200;
            double usdAmount = nairaAmount / exchangeRate;

            Console.WriteLine($"Amount in US Dollar: ${usdAmount:N2}");
        }
    }
}
