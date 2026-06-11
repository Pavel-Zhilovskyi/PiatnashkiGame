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
        Console.WriteLine("Press the key to choose.\n");
    }

    public static void PrintAfterGameMenu()
    {
        Console.WriteLine("Restart the game - R");
        Console.WriteLine("Return to the main menu - M");
        Console.WriteLine("Quit the game - Q");
    }
}
