using PiatnashkiGame.Converter;
using PiatnashkiGame.Enums;
using PiatnashkiGame.Field;
using PiatnashkiGame.Handler;
using PiatnashkiGame.Options;
using PiatnashkiGame.Points;
using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;
using System.Diagnostics;

namespace PiatnashkiGame.Gaming;

internal class Game
{
    Board board;

    Settings settings;

    ScoreStorage storage;

    public Game(Board board, Settings settings, ScoreStorage storage)
    {
        this.board = board;
        this.settings = settings;
        this.storage = storage;
    }

    private GameSession InitializeGame(string playerName, GameMode mode)
    {
        return new GameSession(playerName, mode);
    }

    private GameResult RunGameLoop(TimeSpan timerLimit, Stopwatch stopwatch, GameSession session)
    {
        ConsoleKeyInfo keyInfo;

        while (stopwatch.Elapsed < timerLimit)
        {
            TimeSpan timeLeft = timerLimit - stopwatch.Elapsed;

            GamePrinter.PrintGameScreen(timeLeft, board, settings, session.MovesCount);

            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Q)
                {
                    return GameResult.GiveUp;
                }

                Direction? direction = KeyInputConverter.ConvertKey(keyInfo, settings);

                if (direction != null)
                {
                    if (board.CanMove(direction))
                    {
                        board.MoveEmptyTile(direction);

                        if (session.IsFirstMove)
                        {
                            stopwatch.Start();
                            session.RegisterFirstMove();
                        }

                        session.IncrementMovesCount();

                        if (board.IsSolved())
                        {
                            return GameResult.Win;
                        }
                    }
                    else
                    {
                        Console.Beep();
                    }
                }
            }
            Thread.Sleep(30);
        }
        return GameResult.TimeOut;
    }

    public void Run(GameMode mode)
    {
        string playerName = InputHandler.ReadNameInput();

        var session = InitializeGame(playerName, mode);
        
        TimeSpan timerLimit = settings.GetGameTimerMode(mode);

        Stopwatch stopwatch = new Stopwatch();

        GameResult result = RunGameLoop(timerLimit, stopwatch, session);

        stopwatch.Stop();

        switch (result)
        {
            case GameResult.Win:
                Score score = new Score(session.PlayerName, stopwatch.Elapsed, session.Mode);

                storage.Save(score);

                Console.Clear();
                BoardPrinter.PrintBoard(board);
                GameResultPrinter.PrintGameWinMessage(stopwatch.Elapsed, session.MovesCount);
                break;
            
            case GameResult.TimeOut:
                GameResultPrinter.PrintTimeOutMessage();
                break;

            case GameResult.GiveUp:
                GameResultPrinter.PrintGiveUpMessage();
                break;
        }
    }
}