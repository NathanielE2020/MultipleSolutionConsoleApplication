using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleSolutions
{
    public class ChatBot
    {
        public static void Chat()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO SIMPLE CHAT BOT.\n");

                Console.WriteLine("ChatBot: Hello! How can i assist you today?");
                Console.WriteLine("Type 'exit' to end the conversation.");

                while (true)
                {
                    Console.Write("You: ");
                    string userMessage = Console.ReadLine();

                    if (userMessage.ToLower() == "exit")
                    {
                        Console.WriteLine("ChatBot: Goodbye! Have a nice day.");
                        break;
                    }

                    string response = GetChatBotResponse(userMessage);
                    Console.WriteLine($"ChatBot: {response}");
                }

        }

        static string GetChatBotResponse(string userMessage)
        {
            if (userMessage.Contains("hello") || userMessage.Contains("hi") || userMessage.Contains("hey"))
            {
                return "Hi there! How can i help you?";
            }
            else if (userMessage.Contains("how are you"))
            {
                return "I'm just a computer program, but thanks for asking!";
            }
            else if (userMessage.Contains("time"))
            {
                return $"The current time is {DateTime.Now.ToString("hh:mm:ss tt")}.";
            } 
            else if (userMessage.Contains("wether"))
            {
                return "I'm sorry, i don't have real-time weather information. You can check a weather websit for that!";
            }
            else if (userMessage.Contains("programming"))
            {
                return "Programming is the process of instructing a computer to perform a task. what specific programming language or topic are you interested in?";
            }
            else if (userMessage.Contains("thank you") || userMessage.Contains("thanks"))
            {
                return "You're welcome! If you have more questions, feel free to ask.";
            }
            else
            {
                return "I'm not sure how to response to that. Ask something else!";
            }
        }
    }
}
