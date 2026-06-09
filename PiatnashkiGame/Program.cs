using PiatnashkiGame.Storages;
using PiatnashkiGame.Menues;

namespace PiatnashkiGame;

class Program
{
    static void Main()
    {
        IScoreStorage scoreStorage = new ScoreStorage();
        ISettingsStorage settignsStorage = new SettingsStorage();
        var settings = settignsStorage.Load();

        while (true)
        {
            var menu = new GameMenu(settings, scoreStorage, settignsStorage);
            var game = menu.Run();

            if (game != null)
            {
                game.Execute();
            }
        }
    }
}