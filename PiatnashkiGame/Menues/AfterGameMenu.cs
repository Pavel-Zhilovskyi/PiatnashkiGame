using PiatnashkiGame.Actions;
using PiatnashkiGame.Options;
using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Enums;

namespace PiatnashkiGame.Menues;

internal class AfterGameMenu
{
    private Settings _settings;

    private IScoreStorage _scoreStorage;

    private ISettingsStorage _settingsStorage;

    private IBoardCreator _classicBoardCreator;
    private IBoardCreator _fastBoardCreator;

    public AfterGameMenu(Settings settings, IScoreStorage scoreStorage, ISettingsStorage settingsStorage,
        IBoardCreator classicBoardCreator, IBoardCreator fastBoardCreator)
    {
        _settings = settings;
        _scoreStorage = scoreStorage;
        _settingsStorage = settingsStorage;
        _classicBoardCreator = classicBoardCreator;
        _fastBoardCreator = fastBoardCreator;
    }

    public AfterGameChoice Run(GameAction gameAction)
    {
        MenuPrinter.PrintAfterGameMenu();

        ConsoleKeyInfo keyInfo;

        while(true)
        {
            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.R:
                    return AfterGameChoice.PlayAgain;

                case ConsoleKey.M:
                    Console.Clear();
                    return AfterGameChoice.MainMenu;

                case ConsoleKey.Q:
                    return AfterGameChoice.QuitProgram;

                default:
                    Console.Beep();
                    break;
            }
        }
    }
}