using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public void OnRetryButton()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnEndButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
