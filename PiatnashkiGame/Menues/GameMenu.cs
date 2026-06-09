using PiatnashkiGame.Actions;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;
class GameMenu
{
    private Settings _settings;

    private IScoreStorage _scoreStorage;

    private ISettingsStorage _settingsStorage;

    public GameMenu(Settings settings, IScoreStorage scoreStorage, ISettingsStorage settingsStorage)
    {
        _settings = settings;
        _scoreStorage = scoreStorage;
        _settingsStorage = settingsStorage;
    }

    public GameAction? Run()
    {
        ConsoleKeyInfo keyInfo;

        PrintRunMenuText();

        keyInfo = Console.ReadKey(true);

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
                return new ClassicGameModeAction(_settings, _scoreStorage);

            case ConsoleKey.D2:
                return new FastGameModeAction(_settings, _scoreStorage);

            case ConsoleKey.D3:
                return new ScoreboardAction(_scoreStorage);

            case ConsoleKey.D4:
                return new RulesAction();

            case ConsoleKey.D5:
                return new SettingsAction(_settings, _settingsStorage);

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