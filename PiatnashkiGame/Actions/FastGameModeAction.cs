using PiatnashkiGame.Enums;
using PiatnashkiGame.Field;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class FastGameModeAction : GameAction
{
    public FastGameModeAction(Settings settings, ScoreStorage scoreStorage)
        : base(settings, scoreStorage) {}

    public override Board? CreateBoard()
    {
        return new Board(BoardConstants.Size3x3, BoardConstants.Size3x3);
    }

    public override void Execute()
    {
        var game = new Game();
        game.Run(CreateBoard()!, settings!, scoreStorage!, GameMode.FastGame);
    }
}