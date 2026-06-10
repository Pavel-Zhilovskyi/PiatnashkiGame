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
        IBoardCreator classicBoardCreator = new ClassicBoardCreator();
        IBoardCreator fastBoardCreator = new FastBoardCreator();

        while (true)
        {
            var menu = new GameMenu(settings, scoreStorage, settignsStorage, classicBoardCreator, fastBoardCreator);
            var game = menu.Run();

            if (game != null)
            {
                game.Execute();
            }
        }
    }
}