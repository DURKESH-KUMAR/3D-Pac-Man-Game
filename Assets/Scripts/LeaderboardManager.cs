using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

[System.Serializable]
public class ScoreData
{
    public string playerName;
    public int score;
}

public class LeaderboardManager : MonoBehaviour
{
    [SerializeField] Text leaderboardText;

    List<ScoreData> scores = new List<ScoreData>();

    void Start()
    {
        SaveScore();
        DisplayLeaderboard();
    }

    void SaveScore()
    {
        ScoreData newScore = new ScoreData();
        newScore.playerName = PlayerPrefs.GetString("PlayerName");
        newScore.score = PlayerPrefs.GetInt("FinalScore");

        scores.Add(newScore);

        scores = scores
            .OrderByDescending(x => x.score)
            .Take(5)
            .ToList();
    }

    void DisplayLeaderboard()
    {
        leaderboardText.text = "LEADERBOARD\n\n";

        for (int i = 0; i < scores.Count; i++)
        {
            leaderboardText.text +=
                (i + 1) + ". " +
                scores[i].playerName +
                " - " +
                scores[i].score + "\n";
        }
    }
}
