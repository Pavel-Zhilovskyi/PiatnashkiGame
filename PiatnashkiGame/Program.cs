using PiatnashkiGame.Storages;
using PiatnashkiGame.Menues;
using PiatnashkiGame.Actions;
using PiatnashkiGame.Enums;

namespace PiatnashkiGame;

class Program
{
    static void Main()
    {
        IScoreStorage scoreStorage = new ScoreStorage();

        ISettingsStorage settignsStorage = new SettingsStorage();

        var settings = settignsStorage.Load();

        IBoardCreator classicBoardCreator = new BoardCreator(BoardConstants.Size4x4, BoardConstants.Size4x4);
        IBoardCreator fastBoardCreator = new BoardCreator(BoardConstants.Size3x3, BoardConstants.Size3x3);

        IMenu menu = new GameMenu(settings, scoreStorage, settignsStorage, classicBoardCreator, fastBoardCreator);
        var afterGameMenu = new AfterGameMenu(settings, scoreStorage, settignsStorage, classicBoardCreator, fastBoardCreator);

        var game = menu.Run();

        while (game != null)
        {
            game.Execute();

            if (game.IsGameAction)
            {
                var choice = afterGameMenu.Run(game);

                if(choice == AfterGameChoice.PlayAgain)
                {
                    continue;
                }
                else if (choice == AfterGameChoice.MainMenu)
                {
                    game = menu.Run();
                }
                else if (choice == AfterGameChoice.QuitProgram)
                {
                    break;
                }
            }
            else
            {
                game = menu.Run();
            }
        }
    }
}