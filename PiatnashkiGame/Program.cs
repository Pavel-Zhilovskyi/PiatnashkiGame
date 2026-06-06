using PiatnashkiGame.Storages;

namespace PiatnashkiGame;

class Program
{
    static void Main()
    {
        var scoreStorage = new ScoreStorage();
        var settingsStorage = new SettingsStorage();
        var settings = settingsStorage.LoadSettingsFromFile();

        while (true)
        {
            var menu = new GameMenu();
            var game = menu.RunMenu(settings, scoreStorage, settingsStorage);

            if (game != null)
            {
                game.Execute();
            }
        }
    }
}