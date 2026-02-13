using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int lives = 3;
    public bool isGameActive = false;

    [SerializeField] Transform playerSpawnPoint;
    [SerializeField] Text livesText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateLivesUI();
    }

    public void StartGame()
    {
        isGameActive = true;
    }

    public void PlayerDied()
    {
        lives--;
        UpdateLivesUI();

        if (lives <= 0)
            GameOver();
        else
            RespawnPlayer();
    }

    void RespawnPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        player.transform.position = playerSpawnPoint.position;
    }

    void GameOver()
    {
        PlayerPrefs.SetInt("FinalScore", ScoreManager.Instance.Score);
        SceneManager.LoadScene("LeaderboardScene");
    }

    void UpdateLivesUI()
    {
        livesText.text = "Lives: " + lives;
    }
}
