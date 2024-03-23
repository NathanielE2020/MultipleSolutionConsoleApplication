using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MultipleSolutions
{
    public class GuessTheNumberGame
    {
        public static void Game()
        {
            
            Console.Clear();

            Console.Write("WELCOME TO THE NUMBER GUESSER GAME.\n");
            Console.WriteLine("Guess a number between 1 and 10.\n");

            

            do
            {
                Random rand = new Random();
                int number, guess;
                number = rand.Next(11);

                char input;
                int attempts = 0;
                int max = 3;

                while (attempts < max)
                {
                    Console.Write("Enter your guess: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess == number)
                    {
                        Console.WriteLine("Congratulations! YOU WON!");
                        Console.Write("Want to play again (y/n)? ");
                        input = Convert.ToChar(Console.ReadLine().ToLower());
                    }
                    else
                    {
                        Console.WriteLine("Incorrect guess. Try again.");
                        attempts++;
                    }
                }

                Console.WriteLine($"GAME OVER! You run out of guess. The correct number was {number}.");
                Console.WriteLine();

                Console.Write("Want to play again (y/n)? ");
                 input = Convert.ToChar(Console.ReadLine().ToLower());
                if(input != 'y')
                {
                    Console.WriteLine("Exiting the game.");
                    break; 
                }
                Console.Clear();
            } while (true);
        }
    }
}