using PiatnashkiGame.Points;
using PiatnashkiGame.Helpers;

namespace PiatnashkiGame.Storages;

internal class ScoreStorage : IScoreStorage
{
    private string _filePath = FilePathHelper.CreateFilePath(AppDomain.CurrentDomain.BaseDirectory,
            ScoreStorageConstants.ScoreFileName, ScoreStorageConstants.ScoreFileExtension);

    private readonly SafeFileHelper _safeFileHelper = new SafeFileHelper();

    private readonly ScoreFormer _scoreFormer = new ScoreFormer();

    public void Save(Score score)
    {
        _safeFileHelper.Append(_filePath, _scoreFormer.DeForm(score) + "\n");
    }

    public List<Score> Load()
    {
        if (!_safeFileHelper.IsExists(_filePath))
        {
            return new List<Score>();
        }

        List<Score> scores = new List<Score>();

        string[] lines = _safeFileHelper.ReadAllLines(_filePath);

        foreach(string line in lines) 
        {
            var score = _scoreFormer.Form(line);

            if (score != null)
            {
                scores.Add(score);
            }
        }
        return scores;
    }

    public void Clear()
    {
        _safeFileHelper.Clear(_filePath);
    }
}