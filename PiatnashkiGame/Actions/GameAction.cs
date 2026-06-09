using PiatnashkiGame.Field;
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

    public Board CreateBoard3x3()
    {
        return new Board(BoardConstants.Size3x3, BoardConstants.Size3x3);
    }

    public Board CreateBoard4x4()
    {
        return new Board(BoardConstants.Size4x4, BoardConstants.Size4x4);
    }

    public abstract void Execute();
}