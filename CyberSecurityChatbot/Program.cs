using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Chatbot";

            // Play the voice greeting
            AudioPlayer.PlayGreeting();

            // Display ASCII logo
            AsciiArt.DisplayLogo();

            // Start the chatbot interaction
            Chatbot bot = new Chatbot();
            bot.Start();

            // Exit message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot. Stay safe online!");
            Console.ResetColor();
        }
    }
}
