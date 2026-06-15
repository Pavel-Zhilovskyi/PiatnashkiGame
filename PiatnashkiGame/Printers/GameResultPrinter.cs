using PiatnashkiGame.Enums;

namespace PiatnashkiGame.Printers;

static class GameResultPrinter
{
    public static void PrintGameWinMessage(TimeSpan time, int movesCount)
    {
        Console.WriteLine("You have successfully completed the board!\n");
        Console.WriteLine("Time: " + time.ToString(@"hh\:mm\:ss"));
        Console.WriteLine("Moves: " + movesCount + "\n");
    }

    public static void PrintGiveUpMessage()
    {
        Console.Clear();
        Console.WriteLine("\nYou decided to give up!\n");
    }

    public static void PrintTimeOutMessage()
    {
        Console.WriteLine("\nTime is out!\n");
    }
}
