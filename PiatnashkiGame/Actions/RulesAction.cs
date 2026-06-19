using PiatnashkiGame.Printers;

namespace PiatnashkiGame.Actions;

internal class RulesAction : GameAction
{
    public RulesAction() : base() { }

    public override void Execute()
    {
        RulesPrinter.PrintRules();
        RulesPrinter.PressAnyKeyToContinue();
    }
}