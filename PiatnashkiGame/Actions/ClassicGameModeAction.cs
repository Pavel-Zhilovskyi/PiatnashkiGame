using PiatnashkiGame.Enums;
using PiatnashkiGame.Field;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class ClassicGameModeAction : GameAction
{
    public  ClassicGameModeAction(Settings settings, IScoreStorage scoreStorage)
        : base(settings, scoreStorage) {}

    public override void Execute()
    {
        var game = new Game();
        game.Run(CreateBoard4x4(), settings!, scoreStorage!, GameMode.Classic);
    }
}