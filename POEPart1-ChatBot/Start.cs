using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POEPart1_ChatBot
{
    public class Start
    {
        // Displays the ASCII art and prompts the user for their name
        public static string DispalyAsciiArt()
        {
            Console.Title = "CyberGuard Chatbot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Please let me know what I can call you before we start -> ");
            Console.ForegroundColor = ConsoleColor.Red;
            string name = Console.ReadLine();

            // If the user does not enter a name, it will default to "Guest"
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "Guest";
            }

            // Displaying the ASCII art and greeting the user
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nHello, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("! I'm here to help you stay safe online.\n");

            // Displaying the welcome message with ASCII art
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Welcome to CyberGaurd my name is ");
            Console.WriteLine(@"
 /$$$$$$$                                      /$$$$$$$              /$$          
| $$__  $$                                    | $$__  $$            | $$          
| $$  \ $$  /$$$$$$  /$$    /$$ /$$$$$$       | $$  \ $$  /$$$$$$  /$$$$$$        
| $$  | $$ |____  $$|  $$  /$$//$$__  $$      | $$$$$$$  /$$__  $$|_  $$_/        
| $$  | $$  /$$$$$$$ \  $$/$$/| $$$$$$$$      | $$__  $$| $$  \ $$  | $$          
| $$  | $$ /$$__  $$  \  $$$/ | $$_____/      | $$  \ $$| $$  | $$  | $$ /$$      
| $$$$$$$/|  $$$$$$$   \  $/  |  $$$$$$$      | $$$$$$$/|  $$$$$$/  |  $$$$/      
|_______/  \_______/    \_/    \_______/      |_______/  \______/    \___/        
                                                                                                                                                          
            ");

            return name;
        }

        public void PlayGreeting()
        {
            // Play a greeting sound when the program starts
            try
            {
                // Ensure the sound file exists in the same directory as the executable
                SoundPlayer player = new SoundPlayer("greeting.wav");
                // Load and play the sound synchronously
                player.Load();
                // Play the sound
                player.PlaySync(); 
            }
            // Catch any exceptions that occur during sound playback
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }

            //Hello and welcome to dave bot, a personalized chat bot to help you stay safe of the internet
        }
    }
}