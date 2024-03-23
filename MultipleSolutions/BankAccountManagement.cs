using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class BankAccountManagement
    {
        static List<BankAccount> account = new List<BankAccount>();

        public static void Bank()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO BANK ACCOUNT MANAGEMENT SYSTEM.\n");

            while (true)
            {
                Console.WriteLine("\n1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Widthdraw Money");
                Console.WriteLine("4. Check balance");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        CheckBalance();
                        break;
                    case 5:
                        Console.WriteLine("Exiting the Bank account management system");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter number between 1 to 5");
                        break;
                }

                Console.Write("Do you want to perform any transaction (y/n)? ");
                char input = Convert.ToChar(Console.ReadLine());

                if (input != 'y')
                {
                    Console.WriteLine("Exiting the bank management system");
                    break;
                }

                Console.Clear();
            }

        }

        static void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Enter account holder name: ");
            string accountHolder = Console.ReadLine();

            var newAccount = new BankAccount(accountHolder);
            account.Add(newAccount);

            Console.WriteLine($"Account created successfully. Account Number: {newAccount.AccountNumber}");
        }

        static void DepositMoney()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            int accountIndex = GetAccountIndex();

            if (accountIndex != -1)
            {
                Console.Write("Enter deposit amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                account[accountIndex].Deposit(amount);

                Console.WriteLine($"Deposit successful. New balance: {account[accountIndex].Balance:C}");
            }
        }

        static void WithdrawMoney()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            int accountIndex = GetAccountIndex();
            if (accountIndex != -1)
            {
                Console.WriteLine("Enter withdrawal amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (account[accountIndex].Withdraw(amount))
                {
                    Console.WriteLine($"Withdrawal successful. New balance: {account[accountIndex].Balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Withdrawal unsuccessful.");
                }
            }
        }

        static void CheckBalance()
        {
            int accountIndex = GetAccountIndex();
            if (accountIndex != -1)
            {
                Console.WriteLine($"Account Balance: {account[accountIndex].Balance:C}");
            }
        }

        static int GetAccountIndex()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();

            for (int i = 0; i < account.Count; i++)
            {
                if (account[i].AccountNumber == accountNumber)
                {
                    return i;
                }
            }

            Console.WriteLine("Account not found. Please enter a valid account number.");
            return -1;
        }
    }

    class BankAccount
    {
        private static int accountCounter = 1000;

        public string AccountNumber { get; set;  }
        public string AccountHolder { get; set;  }
        public double Balance { get; set; }

        public BankAccount(string accountHolder)
        {
            this.AccountNumber = $"AC{accountCounter++}";
            this.AccountHolder = accountHolder;
            this.Balance = 0.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }else
            {
                return false;
            }
           
        }
    }
}
