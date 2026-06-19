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

        IsPlayableAction = true;
    }

    public override void Execute()
    {
        var game = new Game(_boardCreator.CreateBoard(), settings!, scoreStorage!);
        game.Run(GameMode.FastGame);
    }
}