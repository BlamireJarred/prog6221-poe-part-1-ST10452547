using System;
using System.Media;
using POEPart1_ChatBot;

namespace POEPart1_ChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start art = new Start();
            art.PlayGreeting();
            String userName = Start.DispalyAsciiArt();

            ChatBot dave = new ChatBot(userName);
            dave.Run();

            Console.ReadKey();
        }
    }
}