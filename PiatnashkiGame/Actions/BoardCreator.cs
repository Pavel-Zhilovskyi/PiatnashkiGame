using PiatnashkiGame.Field;

namespace PiatnashkiGame.Actions;

internal class ClassicBoardCreator : IBoardCreator
{
    public Board CreateBoard() => new Board(4, 4);
}

internal class FastBoardCreator : IBoardCreator
{
    public Board CreateBoard() => new Board(3, 3);
}