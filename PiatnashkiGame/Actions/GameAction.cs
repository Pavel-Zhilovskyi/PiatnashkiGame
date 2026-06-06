using PiatnashkiGame.Field;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal abstract class GameAction
{
    protected readonly Settings? settings;
    protected readonly ScoreStorage? scoreStorage;
    protected readonly SettingsStorage? settingsStorage;

    protected GameAction() { }

    protected GameAction(Settings settings, ScoreStorage storage)
    {
        this.settings = settings;
        this.scoreStorage = storage;
    }

    protected GameAction(ScoreStorage? storage)
    {
        this.scoreStorage = storage;
    }

    protected GameAction(Settings settings, SettingsStorage storage)
    {
        this.settings = settings;
        this.settingsStorage = storage;
    }

    public virtual Board? CreateBoard()
    {
        return null;
    }

    public abstract void Execute();
}