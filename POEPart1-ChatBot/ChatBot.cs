using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1_ChatBot
{
    class ChatBot
    {
        private string userName;

        public ChatBot(string name)
        {
            userName = name;
        }
        public void Run()
        {
            Console.WriteLine("You can ask me things about cyber safety, the current questions I can answer are:");
            Console.WriteLine("- 1. How are you?");
            Console.WriteLine("- 2. What's your purpose?");
            Console.WriteLine("- 3. What can I ask you about?");
            Console.WriteLine("- 4. Password safety");
            Console.WriteLine("- 5. Phishing");
            Console.WriteLine("- 6. Safe browsing\n");
            Console.WriteLine("Juast type the number of the question you want answered\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nAsk a question (or type 'exit' to quit): ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                string input = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (input == "exit")
                {
                    Console.WriteLine($"\nGoodbye, {userName}! Stay safe online!");
                    break;
                }

                RespondToQuestion(input);
            }
        }

        private void RespondToQuestion(string response)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            switch (response)
            {
                case "1":
                    Console.WriteLine("I'm just a bot, but I'm always ready to protect your digital life!");
                    break;
                case "2":
                    Console.WriteLine("My purpose is to raise awareness about cybersecurity and help you stay safe online.");
                    break;
                case "3":
                    Console.WriteLine("You can ask me about password safety, phishing, and safe browsing tips.");
                    break;
                case "4":
                    Console.WriteLine("Use long, unique passwords and enable two-factor authentication whenever possible.");
                    break;
                case "5":
                    Console.WriteLine("Watch out for suspicious emails or messages asking for personal info. Always verify the sender.");
                    break;
                case "6":
                    Console.WriteLine("Use secure websites (https), avoid clicking unknown links, and keep your browser up to date.");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't understand that yet. Could you rephrase?");
                    break;
            }

            Console.ResetColor();
        }
    }
}
