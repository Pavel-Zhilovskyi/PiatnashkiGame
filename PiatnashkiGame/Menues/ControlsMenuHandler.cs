using PiatnashkiGame.Enums;
using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;
using PiatnashkiGame.Options;

namespace PiatnashkiGame.Menues;

internal class ControlsMenuHandler : IMenu
{
    private readonly Settings _settings;

    private readonly ISettingsStorage _storage;

    public ControlsMenuHandler(Settings settings, ISettingsStorage storage)
    {
        _settings = settings;
        _storage = storage;
    }

    public void Run()
    {
        ConsoleKeyInfo keyInfo;

        while (true)
        {
            Console.Clear();

            MenuPrinter.PrintControlsMenu(_settings.KeyControls.ToString());

            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    _settings.KeyControls = ControlsSettings.WASD;
                    _storage.Save(_settings);
                    break;

                case ConsoleKey.D2:
                    _settings.KeyControls = ControlsSettings.Arrows;
                    _storage.Save(_settings);
                    break;

                case ConsoleKey.Escape:
                    return;

                default:
                    Console.Beep();
                    break;
            }
        }
    }
}