using PiatnashkiGame.Enums;
using PiatnashkiGame.Gaming;
using PiatnashkiGame.Options;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class ClassicGameModeAction : GameAction
{
    private BoardCreator _boardCreator;

    public  ClassicGameModeAction(Settings settings, ScoreStorage scoreStorage, BoardCreator boardCreator)
        : base(settings, scoreStorage) 
    {
        _boardCreator = boardCreator;

        IsPlayableAction = true;
    }

    public override void Execute()
    {
        var game = new Game(_boardCreator.CreateBoard(), settings!, scoreStorage!);
        game.Run(GameMode.Classic);
    }
}