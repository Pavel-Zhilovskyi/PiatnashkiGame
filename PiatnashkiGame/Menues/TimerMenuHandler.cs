using PiatnashkiGame.Printers;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class TimerMenuHandler : ITimerOptions
{
    private readonly Settings _settings;
    private readonly ITimerChangeble _timer4x4;
    private readonly ITimerChangeble _timer3x3;

    public TimerMenuHandler(Settings settings, ITimerChangeble timer4x4, ITimerChangeble timer3x3)
    {
        _settings = settings;
        _timer4x4 = timer4x4;
        _timer3x3 = timer3x3;
    }

    public void Run()
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
                    _timer4x4.ChangeTimer();
                    break;

                case ConsoleKey.D2:
                    _timer3x3.ChangeTimer();
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
