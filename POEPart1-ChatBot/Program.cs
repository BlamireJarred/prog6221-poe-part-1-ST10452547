using System;
using System.Media;
using POEPart1_ChatBot;

namespace POEPart1_ChatBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start start = new Start();
            //start.PlayGreeting();
            String userName = Start.DispalyAsciiArt();

            ChatBot dave = new ChatBot(userName);
            dave.Run();

            Console.ReadKey();
        }
    }
}