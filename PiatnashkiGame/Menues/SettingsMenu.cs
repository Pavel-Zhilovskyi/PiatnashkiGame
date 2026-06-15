using PiatnashkiGame.Printers;

namespace PiatnashkiGame.Menues;

internal class SettingsMenu : ISettingsMenu
{
    private readonly IControlsOptions _controlsOption;
    private readonly ITimerOptions _timerOption;

    public SettingsMenu(IControlsOptions controlsOption, ITimerOptions timerOption)
    {
        _controlsOption = controlsOption;
        _timerOption = timerOption;
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
                    _controlsOption.Run();
                    break;

                case ConsoleKey.D2:
                    _timerOption.Run();
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
}