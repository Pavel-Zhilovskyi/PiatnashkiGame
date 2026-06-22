using PiatnashkiGame.Menues;
using PiatnashkiGame.Storages;
using PiatnashkiGame.Options;

namespace PiatnashkiGame.Actions;

internal class SettingsAction : GameAction
{
    public SettingsAction(Settings settings, ISettingsStorage settingsStorage)
        : base(settings, settingsStorage) {}

    public override void Execute()
    {
        IMenu controlsOption = new ControlsMenuHandler(settings!, settingsStorage!);

        ITimerChangeble timer4x4 = new Timer4x4Handler(settings!, settingsStorage!);
        ITimerChangeble timer3x3 = new Timer3x3Handler(settings!, settingsStorage!);
        IMenu timerOption = new TimerMenuHandler(settings!, timer4x4, timer3x3);

        IMenu settingsMenu = new SettingsMenu(controlsOption, timerOption);
        settingsMenu.Run();
    }
}