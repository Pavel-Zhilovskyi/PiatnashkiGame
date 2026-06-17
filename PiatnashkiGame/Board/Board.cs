using PiatnashkiGame.Enums;

namespace PiatnashkiGame.Field;

public class Board
{
    private readonly int[,] solvedBoard;

    public int Rows { get; }

    public int Cols { get; }

    private readonly int[,] board;

    private int emptyRow;
    private int emptyCol;

    public Board(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        int[] tempArr;

        switch ((Rows, Cols))
        {
            case (4, 4):
                solvedBoard = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 0 } };
                tempArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
                break;

            case (3, 3):
                solvedBoard = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 0 } };
                tempArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }
            
        do
        {
            Random.Shared.Shuffle(tempArr);
        } while (!BoardValidator.IsSolvable(tempArr, rows, cols) || BoardValidator.IsSolved(tempArr, solvedBoard));

        board = new int[rows, cols];

        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                board[i, j] = tempArr[index++];
            }
        }
        FindEmptyTile();
    }

    public int GetValue(int row, int col)
    {
        return board[row, col];
    }

    private void FindEmptyTile()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (board[i, j] == 0)
                {
                    emptyRow = i;
                    emptyCol = j;
                    return;
                }
            }
        }
    }
        
    public bool CanMove(Direction? direction)
    {
        if ((direction == Direction.Up && emptyRow > 0) ||
            (direction == Direction.Down && emptyRow < Rows - 1) ||
            (direction == Direction.Left && emptyCol > 0) ||
            (direction == Direction.Right && emptyCol < Cols - 1))
        {
            return true;
        }
        return false;
    }

    public void MoveEmptyTile(Direction? direction)
    {
        if (direction == Direction.Up)
        {
            (board[emptyRow, emptyCol], board[emptyRow - 1, emptyCol]) =
                (board[emptyRow - 1, emptyCol], board[emptyRow, emptyCol]);

            emptyRow--;
        }
        else if (direction == Direction.Down)
        {
            (board[emptyRow, emptyCol], board[emptyRow + 1, emptyCol]) =
                (board[emptyRow + 1, emptyCol], board[emptyRow, emptyCol]);

            emptyRow++;
        }
        else if (direction == Direction.Left)
        {
            (board[emptyRow, emptyCol], board[emptyRow, emptyCol - 1]) =
                (board[emptyRow, emptyCol - 1], board[emptyRow, emptyCol]);

            emptyCol--;
        }
        else if (direction == Direction.Right)
        {
            (board[emptyRow, emptyCol], board[emptyRow, emptyCol + 1]) =
                (board[emptyRow, emptyCol + 1], board[emptyRow, emptyCol]);

            emptyCol++;
        }
    }

    public bool IsSolved()
    {
        for (int i = 0; i < Rows; ++i)
        {
            for (int j = 0; j < Cols; ++j)
            {
                if (board[i, j] != solvedBoard[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}