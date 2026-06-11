using PiatnashkiGame.Enums;
using PiatnashkiGame.Handler;
using PiatnashkiGame.Options;
using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class SettingsMenu : ISettingsMenu
{
    private readonly Settings _settings;

    private readonly ISettingsStorage _storage;

    public SettingsMenu(Settings settings, ISettingsStorage storage)
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

            MenuPrinter.PrintSettingsMenu();

            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    ControlsMenu();
                    break;

                case ConsoleKey.D2:
                    TimerMenu();
                    break;

                case ConsoleKey.Escape:
                    Console.Clear();
                    return;

                default:
                    Console.Beep();
                    break;
            }
        }
    }

    public void TimerMenu()
    {
        ConsoleKeyInfo keyInfo;

        while (true)
        {
            Console.Clear();

            MenuPrinter.PrintTimerMenu(_settings.Time4x4, _settings.Time3x3);

            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    _settings.Time4x4 = InputHandler.ReadTimerInput();
                    SaveSettings();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    _settings.Time3x3 = InputHandler.ReadTimerInput();
                    SaveSettings();
                    break;

                case ConsoleKey.Escape:
                    return;

                default:
                    Console.Beep();
                    break;
            }
        }
    }

    public void ControlsMenu()
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
                    SaveSettings();
                    break;

                case ConsoleKey.D2:
                    _settings.KeyControls = ControlsSettings.Arrows;
                    SaveSettings();
                    break;

                case ConsoleKey.Escape:
                    return;

                default:
                    Console.Beep();
                    break;
            }
        }
    }

    private void SaveSettings()
    {
        _storage.Save(_settings);
    }
}