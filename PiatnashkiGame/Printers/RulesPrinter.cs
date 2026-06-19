using PiatnashkiGame.Regulations;

namespace PiatnashkiGame.Printers;

static class RulesPrinter
{
    public static void PrintRules()
    {
        Console.Clear();

        var rules = new Rules();

        for (int i = 0; i < RulesConstants.RulesCount; i++)
        {
            Console.WriteLine(i + 1 + ". " + rules.GetRules(i));
            Thread.Sleep(200);
        }
    }

    public static void PressAnyKeyToContinue()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey(true);
        Console.Clear();
    }
}