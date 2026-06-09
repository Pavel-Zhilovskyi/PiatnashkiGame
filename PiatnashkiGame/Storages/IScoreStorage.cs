using PiatnashkiGame.Points;

namespace PiatnashkiGame.Storages;

internal interface IScoreStorage
{
    void Save(Score score);

    List<Score> Load();

    void Clear();
}