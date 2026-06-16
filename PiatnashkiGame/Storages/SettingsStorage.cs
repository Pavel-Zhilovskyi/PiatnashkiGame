using PiatnashkiGame.Enums;
using PiatnashkiGame.Helpers;
using PiatnashkiGame.Options;

namespace PiatnashkiGame.Storages;

internal class SettingsStorage : ISettingsStorage
{
    private readonly string _filePath = FilePathHelper.CreateFilePath(AppDomain.CurrentDomain.BaseDirectory,
            SettingsStorageConstants.SettingsFileName, SettingsStorageConstants.SettingsFileExtension);

    private readonly SafeFileHelper _safeFileHelper = new SafeFileHelper();

    private readonly SettingsFormer _settingsFormer = new SettingsFormer();

    public Settings Load()
    {
        if (!_safeFileHelper.IsExists(_filePath))
        {
            return new Settings();
        }

        return _settingsFormer.Form(_safeFileHelper.ReadAllLines(_filePath));
    }

    public void Save(Settings settings)
    {
        _safeFileHelper.Write(_filePath, _settingsFormer.DeForm(settings) + "\n");
    }
}