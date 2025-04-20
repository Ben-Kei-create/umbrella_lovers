
using UnityEngine;
using TMPro;

public class ClearScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI gameOverScoreText;

    void Start()
    {
        if (gameOverScoreText != null)
        {
            gameOverScoreText.text = "Score " + Score.finalScore.ToString();
        }
        else
        {
            Debug.LogError("GameOverScoreText がアサインされていません。");
        }
    }
}