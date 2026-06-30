namespace PiatnashkiGame;

public static class SettingsConstants
{
    public const string Controls = "Controls";
    public const string Time4x4 = "Time4x4";
    public const string Time3x3 = "Time3x3";
}

public static class BoardConstants
{
    public const int Size3x3 = 3;
    public const int Size4x4 = 4;
}

public static class RulesConstants
{
    public const int RulesCount = 11;
}

public static class InputHandlerConstants
{
    public const int TimeInputLength = 8;
    public const string InvalidNameSeparator = ";";
}

public static class SettingsStorageConstants
{
    public const string SettingsFileName = "PiatnashkiGameSettings";
    public const string SettingsFileExtension = "Settings";

    public const int ValidSettingsLineLength = 2;
}

public static class ScoreStorageConstants
{
    public const string ScoreFileName = "PiatnashkiGameScore";
    public const string ScoreFileExtension = "Score";

    public const int ValidScoreLineLength = 3;
}