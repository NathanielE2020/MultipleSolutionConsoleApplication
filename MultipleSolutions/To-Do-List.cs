using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class To_Do_List
    {
        static String filename = "E:\\LIBRARY\\todo.txt";
        public static void ToDo()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO TODO-LIST.\n");

            do
            {
                int menuItem = -1;
                while (menuItem != 0)
                {
                    menuItem = menu();
                    switch (menuItem)
                    {
                        case 1:
                            showList();
                            break;
                        case 2:
                            addItem();
                            break;
                        case 3:
                            removeItem();
                            break;
                        case 0:
                            break;
                        default:
                            Console.WriteLine("Don't recognize input.");
                            break;
                    }
                }

                Console.Write("Do you want to Todo Again (y/n)? ");
                char input = Convert.ToChar(Console.ReadLine());

                if (input != 'y')
                {
                    Console.WriteLine("Exiting Todo- list app");
                    break;
                }

                } while (true);

        }

        static void addItem()
        {
            Console.WriteLine("\nAdd Item\n");
            StreamWriter outFile = File.AppendText(filename);
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            outFile.WriteLine(item);
            outFile.Close();
        }

        static void removeItem()
        {
            int choice;
            showList();
            Console.Write("Which item do you want to remove? ");
            choice = Convert.ToInt32(Console.ReadLine());
            List<string> items = new List<string>();
            int number = 1;
            string item;
            StreamReader inFile = new StreamReader(filename);
            while (inFile.Peek() != -1)
            {
                item = inFile.ReadLine();
                if (number != choice)
                    items.Add(item);
                ++number;
            }
            inFile.Close();
            StreamWriter outFile = new StreamWriter(filename);
            for (int i = 0; i < items.Count; ++i)
                outFile.WriteLine(items[i]);
            outFile.Close();
        }

        static int menu()
        {
            int choice;
            Console.WriteLine("Main Menu\n");
            Console.WriteLine("0. Exit the program");
            Console.WriteLine("1. Display to-do list");
            Console.WriteLine("2. Add item to to-do list");
            Console.WriteLine("3. Remove item from to-do list");
            Console.WriteLine();
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        static void showList()
        {
            Console.WriteLine("\nTo-do List\n");
            StreamReader inFile = new StreamReader(filename);
            String line;
            int number = 1;
            while (inFile.Peek() != -1)
            {
                line = inFile.ReadLine();
                Console.Write(number + " ");
                Console.WriteLine(line);
                ++number;
            }
            Console.WriteLine();
            inFile.Close();
        }
    }
}
