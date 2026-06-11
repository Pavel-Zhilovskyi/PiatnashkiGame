using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class ScoreMenu : IScoreMenu
{
    private readonly IScoreStorage _storage;

    public ScoreMenu(IScoreStorage storage)
    {
        _storage = storage;
    }

    public void Run()
    {
        ConsoleKeyInfo keyInfo;
        Console.Clear();

        do
        {
            MenuPrinter.PrintScoreMenu();

            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    ScoreboardPrinter.ShowScoreboard(_storage.Load());
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    _storage.Clear();
                    Console.WriteLine("You have successfully cleared the scoreboard!\n");
                    break;

                case ConsoleKey.Escape:
                    Console.Clear();
                    return;

                default:
                    Console.Clear();
                    Console.Beep();
                    break;
            }
        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}