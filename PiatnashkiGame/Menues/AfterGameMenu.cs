using PiatnashkiGame.Actions;
using PiatnashkiGame.Printers;
using PiatnashkiGame.Enums;

namespace PiatnashkiGame.Menues;

internal class AfterGameMenu
{
    public AfterGameChoice Run(GameAction gameAction)
    {
        MenuPrinter.PrintAfterGameMenu();

        ConsoleKeyInfo keyInfo;

        while(true)
        {
            keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.R:
                    return AfterGameChoice.PlayAgain;

                case ConsoleKey.M:
                    Console.Clear();
                    return AfterGameChoice.MainMenu;

                case ConsoleKey.Q:
                    Console.Write("BYE!");
                    return AfterGameChoice.QuitProgram;

                default:
                    Console.Beep();
                    break;
            }
        }
    }
}