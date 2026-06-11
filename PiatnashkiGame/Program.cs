using PiatnashkiGame.Storages;
using PiatnashkiGame.Menues;
using PiatnashkiGame.Actions;

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

        while (true)
        {
            var game = menu.Run();

            if (game != null)
            {
                game.Execute();
            }
        }
    }
}