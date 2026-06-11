using PiatnashkiGame.Actions;

namespace PiatnashkiGame.Menues;

interface IMenu
{
    GameAction? Run();
}