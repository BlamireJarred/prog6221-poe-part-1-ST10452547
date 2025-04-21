using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1_ChatBot
{
    public class Start
    {
        public static string DispalyAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Greetings human!");
            Console.ForegroundColor = ConsoleColor.Green;
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

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.WriteLine($"\nHello, {userName}! I'm here to help you stay safe online.\n");
            return userName;
        }

        public void PlayGreeting()
        {
            /*try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Load();
                player.PlaySync(); // PlaySync waits until playback finishes
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }*/
            Console.WriteLine(@"Greeting wav played");
        }
    }
}