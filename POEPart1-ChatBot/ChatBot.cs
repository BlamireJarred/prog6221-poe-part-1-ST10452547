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
            Console.WriteLine("Type the number of the question you'd like answered, or type 'exit' to end our chat.\n");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("\nAsk a question: ");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                string input = Console.ReadLine().ToLower();
                Console.ResetColor();

                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\nGoodbye, ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(userName);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("! Stay safe and secure online.");
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
                    Console.WriteLine("My mission is to help you understand cybersecurity and stay protected online.");
                    Console.WriteLine("From phishing scams to password protection, I’ve got your back.");
                    break;
                case "3":
                    Console.WriteLine("You can ask me about:");
                    Console.WriteLine("Password safety\nPhishing scams\nSafe browsing habits");
                    Console.WriteLine("Just type the number next to the topic you’re curious about.");
                    break;
                    break;
                case "4":
                    Console.WriteLine("Password Safety Tip:");
                    Console.WriteLine("- Use unique passwords for every account.");
                    Console.WriteLine("- A password manager can help you generate and store strong passwords.");
                    Console.WriteLine("- And don’t forget to enable two-factor authentication where possible!");
                    break;
                case "5":
                    Console.WriteLine("Phishing Awareness:");
                    Console.WriteLine("- Never click links in unsolicited emails or texts.");
                    Console.WriteLine("- Always verify the sender before providing sensitive info.");
                    Console.WriteLine("- Look out for strange grammar, urgent language, or odd URLs.");
                    break;
                case "6":
                    Console.WriteLine("Safe Browsing Habits:");
                    Console.WriteLine("- Stick to secure websites that start with HTTPS.");
                    Console.WriteLine("- Avoid clicking suspicious pop-ups or ads.");
                    Console.WriteLine("- Keep your browser and antivirus software up to date.");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't understand that yet. Could you rephrase? \nOnly type the number next to the question");
                    break;
            }

            Console.ResetColor();
        }
    }
}
