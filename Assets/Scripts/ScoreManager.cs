using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int Score { get; private set; }

    [SerializeField] Text scoreText;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        Score += amount;
        UpdateUI();
    }

    void UpdateUI()
    {
        scoreText.text = "Score: " + Score;
    }
}
