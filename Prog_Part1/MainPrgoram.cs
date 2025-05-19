using System;

class Program
{
    static void Main()
    {
        // Display ASCII Art
        VisualBanner.ShowTitle();
        VisualBanner.ShowMascot();

        // Play Voice Greeting
        AudioWelcome.PlayGreeting();  // <- Updated to match the new class and method name
        Console.WriteLine();

        // Start Chatbot Interaction
        CyberHelper.BeginInteraction();
    }
}
