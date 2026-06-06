using PiatnashkiGame.Enums;
using PiatnashkiGame.Field;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class ClassicGameModeAction : GameAction
{
    public ClassicGameModeAction(Settings settings, ScoreStorage scoreStorage)
        : base(settings, scoreStorage) {}

    public override Board? CreateBoard()
    {
        return new Board(BoardConstants.Size4x4, BoardConstants.Size4x4);
    }

    public override void Execute()
    {
        var game = new Game();
        game.Run(CreateBoard()!, settings!, scoreStorage!, GameMode.Classic);
    }
}