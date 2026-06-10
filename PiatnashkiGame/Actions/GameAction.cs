using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal abstract class GameAction
{
    protected readonly Settings? settings;
    protected readonly IScoreStorage? scoreStorage;
    protected readonly ISettingsStorage? settingsStorage;

    protected GameAction() {}

    protected GameAction(Settings settings, IScoreStorage storage)
    {
        this.settings = settings;
        scoreStorage = storage;
    }

    protected GameAction(IScoreStorage? storage)
    {
        scoreStorage = storage;
    }

    protected GameAction(Settings settings, ISettingsStorage storage)
    {
        this.settings = settings;
        settingsStorage = storage;
    }

    public abstract void Execute();
}