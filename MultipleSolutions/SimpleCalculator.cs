using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class SimpleCalculator
    {
        public static void Calculate()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO CALCULATOR PROGRAM.\n");
            

            while (true)
            {
                Console.WriteLine("Enter first number to calculate: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                char op = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = Calculation(num1, num2, op);

                Console.WriteLine($"Result: {result}");

                Console.Write("Do you want to perform another calculation (y/n)? ");
                char more = Convert.ToChar(Console.ReadLine());

                if (more != 'y')
                {
                    Console.WriteLine("Exiting the Calculator.");
                    break;
                }

                Console.Clear();
            };
        }

        static double Calculation(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allow.");
                        return 0;
                    }
                default:
                    Console.WriteLine("Invalid operator. Please enter (+, -, *, /): ");
                    return 0;
            }

        }
    }
}
