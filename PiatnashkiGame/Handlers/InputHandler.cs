namespace PiatnashkiGame.Handler;

internal class InputHandler
{
    public static string ReadNameInput()
    {
        string name;

        do
        {
            Console.Write("\nEnter your nickname: ");
            name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) || name.Contains(InputHandlerConstants.InvalidNameSeparator))
            {
                Console.WriteLine("\nEnter a valid nickname!");
            }
            else
            {
                break;
            }
        } while (true);

        return name;
    }

    public static TimeSpan ReadTimerInput()
    {
        Console.Clear();

        string time;

        do
        {
            Console.WriteLine("Enter the time (hh:mm:ss)");
            time = Console.ReadLine();

            if (TimeSpan.TryParse(time, out TimeSpan result) && time.Length == InputHandlerConstants.TimeInputLength)
            {
                return result;
            }
            else
            {
                Console.Beep();
                Console.WriteLine("Enter valid time format!\n");
            }
        } while (true);
    }
}