using UnityEngine;
using TMPro;

public class GameOverScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI gameOverScoreText;

    void Start()
    {
        Debug.Log(gameObject.scene.name + " の ScoreDisplay が開始しました。Score.finalScore: " + Score.finalScore); // 追加

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