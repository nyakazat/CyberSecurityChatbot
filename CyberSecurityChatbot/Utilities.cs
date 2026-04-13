using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    public static class Utilities
    {
        public static void TypeText(string text, int delay = 2)
        {
            foreach (char character in text)
            {
                Console.Write(character);
                Thread.Sleep(delay);
            }
        }
    }
}
