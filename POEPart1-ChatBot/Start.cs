using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1_ChatBot
{
    public class Start
    {
        public static string DispalyAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════╗");
            Console.WriteLine("║              CYBERSECURITY AWARENESS BOT               ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════╝");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi my name is ...");
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

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Before we start, please let me know what I can call you -> ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nPerfect \n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\nHello, ");
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.Write(userName);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("! I'm here to help you stay safe online.\n");

            return userName;
        }

        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.Load();
                player.PlaySync(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }
            //Hello and welcome to dave bot, a personalized chat bot to help you stay safe of the internet
        }
    }
}