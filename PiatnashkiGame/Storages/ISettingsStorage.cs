using PiatnashkiGame.Options;

namespace PiatnashkiGame.Storages;

interface ISettingsStorage
{
    Settings Load();

    void Save(Settings settings);
}