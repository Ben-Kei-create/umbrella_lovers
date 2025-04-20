using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneUI : MonoBehaviour
{
    public void OnStartButton()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnHowToPlayButton()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
