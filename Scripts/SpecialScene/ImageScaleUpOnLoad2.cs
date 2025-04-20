using UnityEngine;

public class ImageScaleUpOnLoad2 : MonoBehaviour
{
    public Vector3 startScale = Vector3.zero;   // 開始時のスケール (Inspector で調整可能)
    public Vector3 endScale = Vector3.one;     // 終了時のスケール (Inspector で調整可能)
    public float duration = 1.0f;             // 拡大にかかる時間 (秒) (Inspector で調整可能)

    private float timer = 0f;
    private RectTransform rectTransform; // UI Image の場合
    private Transform normalTransform;   // SpriteRenderer の場合

    void Start()
    {
        // RectTransform が存在するか確認 (UI Image)
        rectTransform = GetComponent<RectTransform>();
        if (rectTransform != null)
        {
            rectTransform.localScale = startScale;
        }
        else
        {
            // RectTransform がなければ通常の Transform を使用 (SpriteRenderer)
            normalTransform = GetComponent<Transform>();
            if (normalTransform != null)
            {
                normalTransform.localScale = startScale;
            }
            else
            {
                Debug.LogError("ImageScaleUpOnLoad スクリプトは、RectTransform または Transform を持つ GameObject にアタッチしてください。");
                enabled = false; // スクリプトを停止
            }
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer < duration)
        {
            float progress = timer / duration;

            if (rectTransform != null)
            {
                rectTransform.localScale = Vector3.Lerp(startScale, endScale, progress);
            }
            else if (normalTransform != null)
            {
                normalTransform.localScale = Vector3.Lerp(startScale, endScale, progress);
            }
        }
        else
        {
            // 拡大完了
            if (rectTransform != null)
            {
                rectTransform.localScale = endScale;
            }
            else if (normalTransform != null)
            {
                normalTransform.localScale = endScale;
            }
            enabled = false; // スクリプトを停止 (必要に応じて)
        }
    }
}