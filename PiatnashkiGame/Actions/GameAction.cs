using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal abstract class GameAction
{
    public virtual bool IsPlayableAction { get; protected set; }

    protected readonly Settings? settings;
    protected readonly ScoreStorage? scoreStorage;
    protected readonly SettingsStorage? settingsStorage;

    protected GameAction() {}

    protected GameAction(Settings settings, ScoreStorage storage)
    {
        this.settings = settings;
        scoreStorage = storage;
    }

    protected GameAction(ScoreStorage? storage)
    {
        scoreStorage = storage;
    }

    protected GameAction(Settings settings, SettingsStorage storage)
    {
        this.settings = settings;
        settingsStorage = storage;
    }

    public abstract void Execute();
}