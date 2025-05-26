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

        // collects the ujsers name so that it can be used in this class
        public ChatBot(string name)
        {
            userName = name;
        }

        //The chatbot's main loop that handles user input and provides responses
        public void Run()
        {
            Random rand = new Random();
            string input;
            string currentTopic = null;
            string favoriteTopic = null;

            // Keywords for detecting user emotions or states
            string[] worriedKeywords = { "worried", "anxious", "nervous", "concerned" };
            string[] frustratedKeywords = { "frustrated", "confused", "angry", "irritated", "overwhelmed" };
            string[] curiousKeywords = { "curious", "interested", "keen", "eager" };

            // Predefined response variations
            string[] howAreYouResponses = {
                "I'm a bot, so I don't have feelings, but thanks for asking!",
                "Running smoothly in the digital realm!",
                "All systems operational — how can I help you today?",
                "I'm functioning as expected. How can I assist?"
            };

            string[] purposeResponses = {
                "I help users understand basic cybersecurity concepts.",
                "My main goal is to educate people about staying safe online.",
                "I was designed to answer your cybersecurity-related questions.",
                "Think of me as your digital safety assistant!"
            };

            string[] passwordResponses = {
                "Always use a strong, unique password with a mix of characters.",
                "Never reuse passwords across different sites — it’s risky!",
                "Consider using a password manager to generate and store secure passwords.",
                "Avoid using personal info like birthdays or pet names in passwords."
            };

            string[] phishingResponses = {
                "Phishing is when attackers trick you into giving away personal info.",
                "Beware of emails that look urgent or suspicious — they could be phishing.",
                "Legit companies never ask for your password via email.",
                "Always verify links before clicking — hover to see where they lead."
            };

            string[] browsingResponses = {
                "Avoid suspicious websites and don't click on unknown links.",
                "Use a secure browser and enable pop-up blockers.",
                "Keep your browser and plugins up to date to prevent exploits.",
                "Look for 'https://' in the URL for secure sites."
            };

            string[] scamResponses = {
                "Scams often come through email or phone calls — always verify the source.",
                "Never share personal or financial info unless you're sure who you're talking to.",
                "Scammers try to create urgency — take your time and double-check.",
                "If something sounds too good to be true, it probably is — stay alert for scams."
            };

            string[] privacyResponses = {
                "Limit the amount of personal information you share online.",
                "Review your privacy settings on social media and apps regularly.",
                "Use encrypted messaging apps to protect your conversations.",
                "Be cautious when giving apps permission to access your location or contacts."
            };

            // "More info" arrays for each topic
            string[] morePasswordInfo = {
                "Using multi-factor authentication adds an extra layer of security.",
                 "Try to change your passwords every few months.",
                "Avoid using the same password across multiple accounts.",
                "Password managers can generate and store complex passwords safely."
            };

            string[] morePhishingInfo = {
                "Be skeptical of emails with spelling errors or urgent demands.",
                "Never download attachments from unknown senders.",
                "Banks and companies will never ask for your password by email.",
                "Phishing websites often look almost identical — double-check the URL."
            };

            string[] moreBrowsingInfo = {
                "Install browser extensions that block ads and trackers.",
                "Use private or incognito mode when needed.",
                "Avoid entering sensitive info on public Wi-Fi unless using a VPN.",
                "Clear cookies and cache regularly to protect your privacy."
            };

            string[] moreScamInfo = {
                "Online scams may impersonate trusted brands — always verify URLs.",
                "Avoid giving out personal info over the phone or text unless verified.",
                "Fake job offers and lottery wins are common scam tactics.",
                "Use reverse image search to check if a profile or item is fake."
            };

            string[] morePrivacyInfo = {
                "Be cautious with what you post on social media — it can be used against you.",
                "Review app permissions and disable unnecessary access.",
                "Use encrypted email and messaging services for added privacy.",
                "Don’t overshare personal details on forums or websites."
            };

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("You: ");
                // sets the users response to lower case to make the readbiltity better
                input = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                // If the user does not enter anything, it will prompt them to enter something
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: I didn’t quite understand that. If you dont know what to ask then try typing 'help' for a list of prompts.");
                    continue;
                }

                // Sentiment detection
                if (worriedKeywords.Any(word => input.Contains(word)))
                {
                    Console.WriteLine("Bot: It's completely understandable to feel that way. Cyber threats can be scary, but I'm here to help you stay informed and protected.");
                }
                else if (frustratedKeywords.Any(word => input.Contains(word)))
                {
                    Console.WriteLine("Bot: I'm sorry you're feeling that way. Cybersecurity can be overwhelming at times, but don't worry — I’ll explain things clearly.");
                }
                else if (curiousKeywords.Any(word => input.Contains(word)))
                {
                    Console.WriteLine("Bot: I love your curiosity! Exploring cybersecurity is a great step toward protecting yourself online.");
                }

                // Topic interest detection
                if (input.Contains("i'm interested in") || input.Contains("i am interested in"))
                {
                    int interestIndex = input.Contains("i'm interested in")
                        ? input.IndexOf("i'm interested in") + "i'm interested in".Length
                        : input.IndexOf("i am interested in") + "i am interested in".Length;

                    favoriteTopic = input.Substring(interestIndex).Trim();
                    Console.WriteLine($"Bot: Great! I'll remember that you're interested in {favoriteTopic}. It's a crucial part of staying safe online.");
                    continue;
                }

                if (input.Contains("remind") || input.Contains("topic"))
                {
                    Console.WriteLine($"Bot: If i remeber correctly you had an interst in {favoriteTopic}");
                }

                // The bot will respond to the users input based on what they have entered
                if (input.Contains("how are you"))
                {
                    Console.WriteLine($"Bot: {howAreYouResponses[rand.Next(howAreYouResponses.Length)]}");
                    currentTopic = null;
                } 
                else if (input.Contains("purpose"))
                {
                    Console.WriteLine($"Bot: {purposeResponses[rand.Next(purposeResponses.Length)]}");
                    currentTopic = null;
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine($"Bot: {passwordResponses[rand.Next(passwordResponses.Length)]}");
                    currentTopic = "password";
                }
                else if (input.Contains("phishing"))
                {
                    Console.WriteLine($"Bot: {phishingResponses[rand.Next(phishingResponses.Length)]}");
                    currentTopic = "phishing";
                }
                else if (input.Contains("browsing") || input.Contains("browse") || input.Contains("safe online"))
                {
                    string personalized = favoriteTopic == "safe browsing" ? "Since you're interested in safe browsing, here's a tip: " : "";
                    Console.WriteLine($"Bot: {browsingResponses[rand.Next(browsingResponses.Length)]}");
                    currentTopic = "browsing";
                }
                else if (input.Contains("scam"))
                {
                    Console.WriteLine($"Bot: {scamResponses[rand.Next(scamResponses.Length)]}");
                    currentTopic = "scam";
                }
                else if (input.Contains("privacy"))
                {
                    Console.WriteLine($"Bot: {privacyResponses[rand.Next(privacyResponses.Length)]}");
                    currentTopic = "privacy";
                }
                else if (input.Contains("exit") || input.Contains("quit"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Bot: Goodbye, ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(userName);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" ! Stay safe online.");

                    return;
                }
                else if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("what else can you tell me"))
                {
                    if (userName != null)
                    {
                        Console.WriteLine($"Bot: Here's what you can ask me about, {userName}:");
                    }
                    else
                    {
                        Console.WriteLine("Bot: Here's what I currently have knowledge on:");
                    }

                    Console.WriteLine("- Password safety");
                    Console.WriteLine("- Phishing");
                    Console.WriteLine("- Scams");
                    Console.WriteLine("- Privacy");
                    Console.WriteLine("- Safe browsing");

                    if (favoriteTopic != null)
                    {
                        Console.WriteLine($"Bot: Since you're interested in {favoriteTopic}, I recommend checking out more tips on that!");
                    }
                    else 
                    {
                        Console.WriteLine($"Tell me what your favorite topic is {userName}, and we can go into more detail");
                    }

                        currentTopic = null;
                }
                else if ((input.Contains("more") || input.Contains("details") || input.Contains("explain") || input.Contains("confused")) && currentTopic != null)
                {
                    switch (currentTopic)
                    {
                        case "password":
                            Console.WriteLine($"Bot: {morePasswordInfo[rand.Next(morePasswordInfo.Length)]}");
                            break;
                        case "phishing":
                            Console.WriteLine($"Bot: {morePhishingInfo[rand.Next(morePhishingInfo.Length)]}");
                            break;
                        case "browsing":
                            Console.WriteLine($"Bot: {moreBrowsingInfo[rand.Next(moreBrowsingInfo.Length)]}");
                            break;
                        case "scam":
                            Console.WriteLine($"Bot: {moreScamInfo[rand.Next(moreScamInfo.Length)]}");
                            break;
                        case "privacy":
                            Console.WriteLine($"Bot: {morePrivacyInfo[rand.Next(morePrivacyInfo.Length)]}");
                            break;
                        default:
                            Console.WriteLine("Bot: Sure, what part would you like me to explain further?");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
                }
            }
        }
    }
}
