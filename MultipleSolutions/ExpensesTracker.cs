using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class ExpensesTracker
    {
        static List<Expense> expenses = new List<Expense>();
        public static void Track()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO EXPENSES TRACKER APP\n");

            while (true)
            {
                Console.WriteLine("\n1. Add Expense");
                Console.WriteLine("2. View Expense");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your Choice (1-3) ");

               int choice;
                
                if(int.TryParse(Console.ReadLine(), out choice))
                {
                    switch(choice)
                    {
                        case 1:
                            AddExpense();
                            break;
                        case 2:
                            ViewExpense();
                            break;
                        case 3:
                            Console.WriteLine("Exiting Expense Tracker.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3");
                            break;
                    }
                } else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

               

            }

            static void AddExpense()
            {
                Console.Write("Enter expense description or name: ");
                string description = Console.ReadLine();

                Console.Write("Enter expense amount: ");
                double amount;

                if(double.TryParse(Console.ReadLine(), out amount))
                {
                    expenses.Add(new Expense(description, amount));
                    Console.WriteLine("Expense Added successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a valid number.");
                }
            }

            static void ViewExpense()
            {
                Console.Clear();
                if(expenses.Count == 0)
                {
                    Console.WriteLine("No expenses record yet.");
                }
                else
                {
                    Console.Write("\nExpense List:");
                    foreach (Expense expense in expenses)
                    {
                        Console.WriteLine($"- {expense.Description}: ${expense.Amount:F2}");
                    }

                    double totalAmount = expenses.Sum(expense => expense.Amount);
                    Console.WriteLine($"Total Expenses: {totalAmount:F2}");
                }
            }
        }

        class Expense
        {
            public string Description { get; }
            public double Amount { get; }

            public Expense(string description, double amount)
            {
                this.Description = description;
                this.Amount = amount;
            }

        }
    }
}
