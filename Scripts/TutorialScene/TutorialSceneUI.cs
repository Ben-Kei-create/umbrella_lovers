using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialSceneUI : MonoBehaviour
{
    public void OnBackButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
