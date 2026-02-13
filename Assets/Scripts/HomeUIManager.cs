using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeUIManager : MonoBehaviour
{
    [SerializeField] InputField nameInput;
    [SerializeField] Button startButton;
    [SerializeField] Text warningText;

    void Start()
    {
        startButton.interactable = false;
        warningText.text = "";

        nameInput.onValueChanged.AddListener(ValidateInput);
    }

    void ValidateInput(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            startButton.interactable = false;
            warningText.text = "Enter Player Name";
        }
        else
        {
            startButton.interactable = true;
            warningText.text = "";
        }
    }

    public void StartGame()
    {
        PlayerPrefs.SetString("PlayerName", nameInput.text);
        SceneManager.LoadScene("GameScene");
    }
}
