using PiatnashkiGame.Actions;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame;
class GameMenu
{
    public GameAction? RunMenu(Settings settings, ScoreStorage scoreStorage, SettingsStorage settingsStorage)
    {
        ConsoleKeyInfo keyInfo;

        PrintRunMenuText();

        keyInfo = Console.ReadKey(true);

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                return new ClassicGameModeAction(settings, scoreStorage);

            case ConsoleKey.D2:
                return new FastGameModeAction(settings, scoreStorage);

            case ConsoleKey.D3:
                return new ScoreboardAction(scoreStorage);

            case ConsoleKey.D4:
                return new RulesAction();

            case ConsoleKey.D5:
                return new SettingsAction(settings, settingsStorage);

            case ConsoleKey.Escape:
                Console.WriteLine("BYE!");
                Environment.Exit(0);
                return null;

            default:
                Console.Beep();
                Console.Clear();
                return null;
        }
    }

    private void PrintRunMenuText()
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
}