namespace PiatnashkiGame.Field;

static class BoardValidator
{
    static public bool IsSolvable(int[] tempArr, int rows, int cols)
    {
        int inversionCount = 0;

        for (int i = 0; i < tempArr.Length; i++)
        {
            for (int j = i + 1; j < tempArr.Length; j++)
            {
                if (tempArr[i] != 0 && tempArr[j] != 0)
                {
                    if (tempArr[i] > tempArr[j])
                    {
                        inversionCount++;
                    }
                }
            }
        }

        if (rows == BoardConstants.Size4x4 && cols == BoardConstants.Size4x4)
        {
            int emptyTileIndex = Array.IndexOf(tempArr, 0);

            int rowFromTop = emptyTileIndex / cols;

            int rowFromBottom = rows - rowFromTop;

            if ((inversionCount % 2) != (rowFromBottom % 2))
            {
                return true;
            }
            return false;
        }

        if (inversionCount % 2 == 0)
        {
            return true;
        }
        return false;
    }

    static public bool IsSolved(int[] tempArr, int[,] solvedBoard)
    {
        int index = 0;

        for (int i = 0; i < solvedBoard.GetLength(0); i++)
        {
            for (int j = 0; j < solvedBoard.GetLength(1); j++)
            {
                if (tempArr[index++] != solvedBoard[i, j])
                {
                    return false;
                }
            }
        }
        return true;
    }
}