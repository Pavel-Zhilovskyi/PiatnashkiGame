using PiatnashkiGame.Printers;
using PiatnashkiGame.Storages;

namespace PiatnashkiGame.Actions;

internal class RulesAction : GameAction
{
    public RulesAction() : base() { }

    public override void Execute()
    {
        RulesPrinter.PrintRules();
    }
}