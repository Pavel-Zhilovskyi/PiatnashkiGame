using PiatnashkiGame.Helpers;
using PiatnashkiGame.Options;

namespace PiatnashkiGame.Storages;

internal class SettingsStorage
{
    private readonly string _filePath = FilePathHelper.CreateFilePath(AppDomain.CurrentDomain.BaseDirectory,
            SettingsStorageConstants.SettingsFileName, SettingsStorageConstants.SettingsFileExtension);

    private readonly SettingsFormer _settingsFormer = new SettingsFormer();

    public Settings Load()
    {
        if (!SafeFileHelper.IsExists(_filePath))
        {
            return new Settings();
        }

        return _settingsFormer.Form(SafeFileHelper.ReadAllLines(_filePath));
    }

    public void Save(Settings settings)
    {
        SafeFileHelper.Write(_filePath, _settingsFormer.DeForm(settings) + "\n");
    }
}