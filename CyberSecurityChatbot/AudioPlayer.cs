using System;
using System.IO;
using System.Media;

namespace CyberSecurityChatbot
{
    /// <summary>
    /// Handles playback of the voice greeting for the chatbot.
    /// </summary>
    public static class AudioPlayer
    {
        /// <summary>
        /// Plays the greeting.wav file located in the application's output directory.
        /// </summary>
        public static void PlayGreeting()
        {
            try
            {
                // Build the full path to the audio file
                string filePath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "greeting.wav"
                );

                // Check if the file exists before attempting to play it
                if (File.Exists(filePath))
                {
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.Load();      // Loads the WAV file into memory
                        player.PlaySync();  // Plays the sound and waits until it finishes
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: The 'greeting.wav' file was not found.");
                    Console.WriteLine($"Expected location: {filePath}");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("An error occurred while trying to play the audio file.");
                Console.WriteLine($"Details: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}