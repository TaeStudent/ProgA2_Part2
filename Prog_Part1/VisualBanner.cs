using System;

class VisualBanner
{
    public static void ShowTitle()
    {
        string[] titleLines = new string[] {
            " __        __   _                            _          _ ",
            " \\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___   / |",
            "  \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\  | |",
            "   \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) | | |",
            "    \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  |_|"
        };

        Console.ForegroundColor = ConsoleColor.Cyan;

        foreach (string line in titleLines)
        {
            CenterText(line);
        }

        Console.ResetColor();
        Console.WriteLine(); // spacing after title
    }

    public static void ShowMascot()
    {
        // Bear mascot lines
        string[] bearLines = new string[] {
            "         .--.        ",
            "        |o_o |        ",
            "        |:_/ |        ",
            "       //   \\ \\\\      ",
            "      (|     | )      ",
            "     /'\\_   _/`\\\\     ",
            "     \\___)=(___/      "
        };

        // Tiger mascot lines (aligned to the right)
        string[] tigerLines = new string[] {
            "                     /|_ |\\  ",
            "                     ( o.o ) ",
            "                      > ^ <  ",
            "                     /     \\ ",
            "                    (       )",
            "                     \\     / ",
            "                      \\___/  "
        };

        Console.ForegroundColor = ConsoleColor.Yellow;

        // Print the bear lines centered
        foreach (string line in bearLines)
        {
            CenterText(line);
        }

        Console.ResetColor();

        // Print the tiger lines aligned to the right
        foreach (string line in tigerLines)
        {
            RightAlignText(line);
        }

        Console.WriteLine(); // spacing before line

        // Display the line under the mascot
        string underline = new string('*', bearLines[0].Length); // adjusted length
        CenterText(underline);
        Console.WriteLine();
    }

    private static void CenterText(string text)
    {
        int windowWidth = Console.WindowWidth;
        int padding = Math.Max((windowWidth - text.Length) / 2, 0);
        Console.WriteLine(new string(' ', padding) + text);
    }

    private static void RightAlignText(string text)
    {
        int windowWidth = Console.WindowWidth;
        int padding = Math.Max(windowWidth - text.Length, 0);  // Calculate space to push it to the right
        Console.WriteLine(new string(' ', padding) + text);
    }
}

