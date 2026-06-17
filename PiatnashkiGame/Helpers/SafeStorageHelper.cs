namespace PiatnashkiGame.Helpers;

static class SafeFileHelper
{
    private static void SafeExecute(Action action)
    {
        try
        {
            action();
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message + "\n");
        }
    }
    
    public static void Append(string path, string text)
    {
        SafeExecute(() => File.AppendAllText(path, text));
            
    }

    public static void Write(string path, string text)
    {
        SafeExecute(() => File.WriteAllText(path, text));
    }

    public static void Clear(string path)
    {
        Write(path, string.Empty);
    }

    public static string[] ReadAllLines(string path)
    {
        string[] lines = Array.Empty<string>();
        try
        {
            lines = File.ReadAllLines(path);
            return lines;
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message + "\n");
        }

        return lines;
    }

    public static bool IsExists(string path)
    {
        return File.Exists(path);
    }
}