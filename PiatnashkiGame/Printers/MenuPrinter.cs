namespace PiatnashkiGame.Printers;

static class MenuPrinter
{
    public static void PrintGameMenu()
    {
        Console.WriteLine("Fifteen Puzzle\n");
        Console.WriteLine("1 - Play (4x4 board)");
        Console.WriteLine("2 - Fast game (3x3 board)");
        Console.WriteLine("3 - Scoreboard");
        Console.WriteLine("4 - See rules");
        Console.WriteLine("5 - Settings");
        Console.WriteLine("Esc - Exit");
        Console.WriteLine("Press the key to choose.");
    }

    public static void PrintAfterGameMenu()
    {
        Console.WriteLine("Restart the game - R");
        Console.WriteLine("Return to the main menu - M");
        Console.WriteLine("Quit the game - Q");
    }

    public static void PrintSettingsMenu()
    {
        Console.WriteLine("SETTINGS\n");
        Console.WriteLine("1 - Controls");
        Console.WriteLine("2 - Timer settings");
        Console.WriteLine("Esc - Quit settings");
    }

    public static void PrintTimerMenu(TimeSpan time4x4, TimeSpan time3x3)
    {
        Console.WriteLine("TIMER\n");
        Console.WriteLine("You can change the timer time, by choosing the needed option.\n");
        Console.WriteLine("1 - Set timer for Classic 4x4 game");
        Console.WriteLine("2 - Set timer for Fast 3x3 game\n");
        Console.WriteLine($"Current timer time for Classic game: {time4x4}");
        Console.WriteLine($"Current timer time for Fast game: {time3x3}\n");
        Console.WriteLine("Esc - Quit timer settings");
    }

    public static void PrintControlsMenu(string currentControls)
    {
        Console.WriteLine("CONTROLS\n");
        Console.WriteLine("You can change the control keys, by choosing the needed option.");
        Console.WriteLine("1 - WASD");
        Console.WriteLine("2 - Arrows");
        Console.WriteLine($"Current controls: {currentControls}\n");
        Console.WriteLine("Esc - Quit controls");
    }

    public static void PrintScoreMenu()
    {
        Console.WriteLine("1 - Show scoreboard");
        Console.WriteLine("2 - Clear scoreboard");
        Console.WriteLine("Esc - Quit scoreboard menu");
    }
}