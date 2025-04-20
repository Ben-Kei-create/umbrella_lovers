using UnityEngine;
using UnityEngine.EventSystems; // UI イベントを処理するために必要

public class SpeedButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float fastForwardScale = 2.2f; // 早送りの倍率 (Inspector で調整可能)
    private float originalTimeScale;    // 通常の Time.timeScale を保存

    void Start()
    {
        // ゲーム開始時の Time.timeScale を保存
        originalTimeScale = Time.timeScale;
    }

    // ボタンが押された時に呼ばれる
    public void OnPointerDown(PointerEventData eventData)
    {
        // 時間を早送り
        Time.timeScale = fastForwardScale;
        Debug.Log("早送り開始: Time.timeScale = " + Time.timeScale);
    }

    // ボタンが離された時に呼ばれる
    public void OnPointerUp(PointerEventData eventData)
    {
        // 時間を通常に戻す
        Time.timeScale = originalTimeScale;
        Debug.Log("早送り終了: Time.timeScale = " + Time.timeScale);
    }
}