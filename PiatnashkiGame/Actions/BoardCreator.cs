using PiatnashkiGame.Field;

namespace PiatnashkiGame.Actions;

internal class BoardCreator : IBoardCreator
{
    private readonly int _rows;
    private readonly int _cols;

    public BoardCreator(int rows, int cols)
    {
        _rows = rows;
        _cols = cols;
    }

    public Board CreateBoard() => new Board(_rows, _cols);
}