using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            DisplayWelcomeMessage();
            AskUserName();
            GreetUser();
            ChatLoop();
        }

        private void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Utilities.TypeText("Welcome to the Cybersecurity Awareness Bot!\n");
            Utilities.TypeText("I'm here to help you stay safe online.\n");
            Utilities.TypeText("You can ask me about phishing, passwords, and safe browsing.\n\n");
            Console.ResetColor();
        }

        private void AskUserName()
        {
            Console.Write("Please enter you name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name cannot be empty. Please enter your name: ");
                Console.ResetColor();
                userName = Console.ReadLine();
            }
        }

        private void GreetUser()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Utilities.TypeText($"\nHello {userName}! I'm your Cybersecurity Awareness Assistant.\n");
            Utilities.TypeText("Type 'help' to see what you can ask or 'exit' to quit.\n");
            Console.ResetColor();
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"\n{userName}: ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bot: Please enter a valid question.");
                    Console.ResetColor();
                    continue;
                }

                if (input == "exit" || input == "quit")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Utilities.TypeText("Bot: Stay safe online. Goodbye!\n");
                    Console.ResetColor();
                    break;
                }

                if (input == "help")
                {
                    DisplayHelp();
                    continue;
                }

                string response = ResponseHandler.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Green;
                Utilities.TypeText($"Bot: {response}\n");
                Console.ResetColor();
            }
        }

        private void DisplayHelp()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nYou can ask me about:");
            Console.WriteLine("- Password safety");
            Console.WriteLine("- Phishing scams");
            Console.WriteLine("- Safe browsing");
            Console.WriteLine("- My purpose");
            Console.WriteLine("- How I am");
            Console.WriteLine("Type 'exit' to close the application.");
            Console.ResetColor();
        }
    }
}
