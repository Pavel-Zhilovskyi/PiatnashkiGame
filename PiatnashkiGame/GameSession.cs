
using PiatnashkiGame.Enums;

namespace PiatnashkiGame;

internal class GameSession
{
    public string PlayerName { get; }
    
    public int MovesCount { get; private set; }

    public GameMode Mode { get; }

    public bool IsFirstMove {  get; private set; }

    public GameSession(string playerName, GameMode mode)
    {
        PlayerName = playerName;
        Mode = mode;
        IsFirstMove = true;
    }

    public void IncrementMovesCount()
    {
        MovesCount++;
    }

    public void RegisterFirstMove()
    {
        IsFirstMove = false;
    }
}