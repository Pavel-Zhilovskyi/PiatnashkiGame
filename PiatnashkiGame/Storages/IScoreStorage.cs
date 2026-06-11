using PiatnashkiGame.Points;

namespace PiatnashkiGame.Storages;

interface IScoreStorage
{
    void Save(Score score);

    List<Score> Load();

    void Clear();
}