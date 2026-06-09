using PiatnashkiGame.Enums;
using PiatnashkiGame.Handler;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class SettingsMenu
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

            Console.WriteLine("SETTINGS\n");
            Console.WriteLine("1 - Controls");
            Console.WriteLine("2 - Timer settings");
            Console.WriteLine("Esc - Quit settings");

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

    private void TimerMenu()
    {
        ConsoleKeyInfo keyInfo;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("TIMER\n");
            Console.WriteLine("You can change the timer time, by choosing the needed option.\n");
            Console.WriteLine("1 - Set timer for Classic 4x4 game");
            Console.WriteLine("2 - Set timer for Fast 3x3 game\n");
            Console.WriteLine($"Current timer time for Classic game: {_settings.Time4x4}");
            Console.WriteLine($"Current timer time for Fast game: {_settings.Time3x3}\n");
            Console.WriteLine("Esc - Quit timer settings");

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

    private void ControlsMenu()
    {
        ConsoleKeyInfo keyInfo;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("CONTROLS\n");
            Console.WriteLine("You can change the control keys, by choosing the needed option.");
            Console.WriteLine("1 - WASD");
            Console.WriteLine("2 - Arrows");
            Console.WriteLine($"Current controls: {_settings.KeyControls}\n");
            Console.WriteLine("Esc - Quit controls");

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