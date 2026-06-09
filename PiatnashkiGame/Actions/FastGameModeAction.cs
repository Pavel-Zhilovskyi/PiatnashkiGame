using PiatnashkiGame.Enums;
using PiatnashkiGame.Field;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class FastGameModeAction : GameAction
{
    public FastGameModeAction(Settings settings, IScoreStorage scoreStorage)
        : base(settings, scoreStorage) {}

    public override void Execute()
    {
        var game = new Game();
        game.Run(CreateBoard3x3(), settings!, scoreStorage!, GameMode.FastGame);
    }
}