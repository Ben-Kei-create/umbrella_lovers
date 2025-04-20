using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearController : MonoBehaviour
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
