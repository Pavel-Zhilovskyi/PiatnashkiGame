using PiatnashkiGame.Enums;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class FastGameModeAction : GameAction
{
    private IBoardCreator _boardCreator;

    public FastGameModeAction(Settings settings, IScoreStorage scoreStorage, IBoardCreator boardCreator)
        : base(settings, scoreStorage)
    {
        _boardCreator = boardCreator;
    }

    public override void Execute()
    {
        var game = new Game();
        game.Run(_boardCreator.CreateBoard(), settings!, scoreStorage!, GameMode.FastGame);
    }
}