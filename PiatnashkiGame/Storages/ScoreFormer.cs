using PiatnashkiGame.Points;
using PiatnashkiGame.Enums;

namespace PiatnashkiGame.Storages;

internal class ScoreFormer
{
    public string DeForm(Score score)
    {
        return score.Name + ";" + score.Time.ToString(@"hh\:mm\:ss") + ";" + score.Mode.ToString();
    }

    public Score? Form(string line)
    {
        string[] parts = line.Split(';');
        if (parts.Length != ScoreStorageConstants.ValidScoreLineLength)
        {
            return null;
        }
        if (!TimeSpan.TryParse(parts[1], out TimeSpan time))
        {
            return null;
        }
        if (!Enum.TryParse(parts[2], true, out GameMode mode))
        {
            return null;
        }
        return new Score(parts[0], time, mode);
    }
}