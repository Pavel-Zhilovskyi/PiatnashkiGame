using PiatnashkiGame.Enums;
using PiatnashkiGame.Options;

namespace PiatnashkiGame.Storages;

internal class SettingsFormer
{
    public string DeForm(Settings settings) => SettingsConstants.Controls + "=" + settings.KeyControls.ToString() + "\n" +
                                               SettingsConstants.Time4x4 + "=" + settings.Time4x4.ToString(@"hh\:mm\:ss") + "\n" +
                                               SettingsConstants.Time3x3 + "=" + settings.Time3x3.ToString(@"hh\:mm\:ss");

    public Settings Form(string[] lines)
    {
        Settings settings = new Settings();
        string[] parts;

        for (int i = 0; i < lines.Length; i++)
        {
            parts = lines[i].Split('=');
            if (parts.Length != SettingsStorageConstants.ValidSettingsLineLength)
            {
                continue;
            }
            switch (parts[0])
            {
                case SettingsConstants.Controls:
                    if (Enum.TryParse(parts[1], true, out ControlsSettings controls))
                    {
                        settings.KeyControls = controls;
                    }
                    break;
                case SettingsConstants.Time4x4:
                    if (TimeSpan.TryParse(parts[1], out TimeSpan time))
                    {
                        settings.Time4x4 = time;
                    }
                    break;
                case SettingsConstants.Time3x3:
                    if (TimeSpan.TryParse(parts[1], out TimeSpan timer))
                    {
                        settings.Time3x3 = timer;
                    }
                    break;
            }
        }
        return settings;
    }
}