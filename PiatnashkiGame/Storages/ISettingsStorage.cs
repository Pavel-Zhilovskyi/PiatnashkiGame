using PiatnashkiGame.Options;

namespace PiatnashkiGame.Storages;

internal interface ISettingsStorage
{
    Settings Load();

    void Save(Settings settings);
}