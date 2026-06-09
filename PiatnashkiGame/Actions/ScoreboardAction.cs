using PiatnashkiGame.Menues;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class ScoreboardAction : GameAction
{
    public ScoreboardAction(IScoreStorage scoreStorage)
        : base(scoreStorage) {}

    public override void Execute()
    {
        var scoreMenu = new ScoreMenu(scoreStorage!);
        scoreMenu.Run();
    }
}