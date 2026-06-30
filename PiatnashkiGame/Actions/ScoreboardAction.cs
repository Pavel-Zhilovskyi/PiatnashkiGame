using PiatnashkiGame.Menues;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class ScoreboardAction : GameAction
{
    public ScoreboardAction(ScoreStorage scoreStorage)
        : base(scoreStorage) {}

    public override void Execute()
    {
        IMenu scoreMenu = new ScoreMenu(scoreStorage!);
        scoreMenu.Run();
    }
}