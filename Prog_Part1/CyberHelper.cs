using System;

class CyberHelper
{
    public static void BeginInteraction()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Hello! What's your name? ");
        string visitorName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nNice to meet you, {visitorName}! I'm here to help with cybersecurity.");
        Console.WriteLine("You can ask me questions about cybersecurity, or type 'options' to see available topics.");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\n{visitorName}: ");
            Console.ResetColor();

            string query = Console.ReadLine()?.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(query))
            {
                PrintBot("I didn't quite understand that. Could you rephrase?");
                continue;
            }

            if (query == "exit")
            {
                PrintBot("Goodbye! Stay safe online!");
                break;
            }

            if (query == "options")
            {
                PrintBot("You can ask me about:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("- Cybersecurity");
                Console.WriteLine("- Password protection");
                Console.WriteLine("- Phishing or scams");
                Console.WriteLine("- Online safety");
                Console.WriteLine("- Safe browsing");
                Console.WriteLine("- My purpose");
                Console.WriteLine("- How I’m doing");
                Console.ResetColor();
            }
            else if (query.Contains("cybersecurity"))
            {
                PrintBot("Cybersecurity is the practice of protecting systems, networks, and programs from digital attacks.");
            }
            else if (query.Contains("password"))
            {
                PrintBot("Use a strong password with at least 12 characters, including letters, numbers, and symbols!");
            }
            else if (query.Contains("phishing") || query.Contains("scam"))
            {
                PrintBot("Be cautious of unexpected emails, verify links before clicking, and never share personal info online.");
            }
            else if ((query.Contains("safe") || query.Contains("safety")) && query.Contains("online"))
            {
                PrintBot("Staying safe online means using strong passwords, avoiding suspicious links, enabling two-factor authentication, and keeping your devices updated.");
            }
            else if (query.Contains("browsing"))
            {
                PrintBot("Safe browsing means avoiding suspicious websites, using HTTPS, and keeping your browser updated.");
            }
            else if (query.Contains("purpose"))
            {
                PrintBot("I'm here to teach you about cybersecurity and staying safe online.");
            }
            else if (query.Contains("how are you"))
            {
                PrintBot("I'm just a bot, but I'm always ready to help!");
            }
            else
            {
                PrintBot("I'm not sure I understand. Can you try rephrasing?");
            }
        }
    }

    private static void PrintBot(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Chatbot: ");
        Console.ResetColor();
        Console.WriteLine(message);
    }
}
