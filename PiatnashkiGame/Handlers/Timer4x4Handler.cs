using PiatnashkiGame.Handler;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Menues;

internal class Timer4x4Handler : ITimerChangeble
{
    private readonly Settings _settings;
    private readonly ISettingsStorage _storage;

    public Timer4x4Handler(Settings settings, ISettingsStorage storage)
    {
        _settings = settings;
        _storage = storage;
    }

    public void ChangeTimer()
    {
        _settings.Time4x4 = InputHandler.ReadTimerInput();
        _storage.Save(_settings);
    }
}
