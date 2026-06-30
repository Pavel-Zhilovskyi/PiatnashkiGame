using PiatnashkiGame.Handler;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class Timer3x3Handler : ITimerChangeble
{
    private readonly Settings _settings;
    private readonly SettingsStorage _storage;

    public Timer3x3Handler(Settings settings, SettingsStorage storage)
    {
        _settings = settings;
        _storage = storage;
    }

    public void ChangeTimer()
    {
        _settings.Time3x3 = InputHandler.ReadTimerInput();
        _storage.Save(_settings);
    }
}
