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
        var settingsMenu = new SettingsMenu(settings!, settingsStorage!);
        settingsMenu.Run();
    }
}