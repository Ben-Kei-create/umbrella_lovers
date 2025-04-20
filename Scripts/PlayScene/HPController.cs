using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HPController : MonoBehaviour
{
    public int maxHP = 100;
    private int currentHP;
    public Slider hpSlider; // InspectorからHPSliderを割り当てる
    public string gameOverSceneName = "GameOverScene"; // GameOverScene のシーン名を設定
    public bool isSliderInteractable = false; // Inspectorからインタラクトの可否を設定 (デフォルトは不可)

    void Start()
    {
        currentHP = maxHP;
        UpdateHPUI();
        // スライダーのインタラクティブ設定
        if (hpSlider != null)
        {
            hpSlider.interactable = isSliderInteractable;
        }
        // その他の初期化処理
    }

    public void DecreaseHP(int amount)
    {
        currentHP -= amount;
        if (currentHP <= 0) // 0以下になった瞬間に判定
        {
            currentHP = 0;
            UpdateHPUI();
            Debug.Log("HPが0になりました。GameOverSceneに遷移します。");
            SceneManager.LoadScene(gameOverSceneName); // GameOverScene に遷移
        }
        else
        {
            UpdateHPUI();
        }
    }

    public void IncreaseHP(int amount)
    {
        currentHP += amount;
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
        UpdateHPUI();
    }

    void UpdateHPUI()
    {
        if (hpSlider != null)
        {
            // Sliderのvalueを現在のHPの割合に設定
            hpSlider.value = (float)currentHP / maxHP;
        }
    }

    // その他のHP関連のメソッド
}