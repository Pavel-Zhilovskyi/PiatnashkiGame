using PiatnashkiGame.Regulations;

namespace PiatnashkiGame.Printers;

static class RulesPrinter
{
    public static void ShowRules()
    {
        Console.Clear();

        var rules = new Rules();

        for (int i = 0; i < RulesConstants.RulesCount; i++)
        {
            Console.WriteLine(i + 1 + ". " + rules.GetRules(i));
            Thread.Sleep(200);
        }
    }
}