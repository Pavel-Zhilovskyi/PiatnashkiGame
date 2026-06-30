using PiatnashkiGame.Points;
using PiatnashkiGame.Helpers;

namespace PiatnashkiGame.Storages;

internal class ScoreStorage
{
    private string _filePath = FilePathHelper.CreateFilePath(AppDomain.CurrentDomain.BaseDirectory,
            ScoreStorageConstants.ScoreFileName, ScoreStorageConstants.ScoreFileExtension);

    private readonly ScoreFormer _scoreFormer = new ScoreFormer();

    public void Save(Score score)
    {
        SafeFileHelper.Append(_filePath, _scoreFormer.DeForm(score) + "\n");
    }

    public List<Score> Load()
    {
        if (!SafeFileHelper.IsExists(_filePath))
        {
            return new List<Score>();
        }

        List<Score> scores = new List<Score>();

        string[] lines = SafeFileHelper.ReadAllLines(_filePath);

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
        SafeFileHelper.Clear(_filePath);
    }
}