using PiatnashkiGame.Actions;
using PiatnashkiGame.Options;
using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class AfterGameMenu : IMenu
{
    private Settings _settings;

    private IScoreStorage _scoreStorage;

    private ISettingsStorage _settingsStorage;

    private IBoardCreator _boardCreator;

    public AfterGameMenu(Settings settings, IScoreStorage scoreStorage, ISettingsStorage settingsStorage,
        IBoardCreator boardCreator)
    {
        _settings = settings;
        _scoreStorage = scoreStorage;
        _settingsStorage = settingsStorage;
        _boardCreator = boardCreator;
    }

    public GameAction? Run()
    {
        MenuPrinter.PrintAfterGameMenu();

        ConsoleKeyInfo keyInfo;

        keyInfo = Console.ReadKey(true);

        switch (keyInfo.Key)
        {
            case ConsoleKey.R:
                return null;

            case ConsoleKey.M:
                Console.Clear();
                return null;

            case ConsoleKey.Q:
                Console.WriteLine("\nBYE!");
                break;

            default:
                Console.Beep();
                break;
        }

        return null;
    }
}