using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToHome : MonoBehaviour
{
    public void GoToHome()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
