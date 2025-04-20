using UnityEngine;

public class PlayerPairWarp : MonoBehaviour
{
    public float warpThresholdLeft = -10f; // ワープする左端の X 座標
    public float warpThresholdRight = 10f; // ワープする右端の X 座標

    private void Update()
    {
        // 現在の PlayerPair の X 座標を取得
        float currentX = transform.position.x;

        // 左端を超えた場合、右端にワープ
        if (currentX < warpThresholdLeft)
        {
            transform.position = new Vector3(warpThresholdRight, transform.position.y, transform.position.z);
        }

        // 右端を超えた場合、左端にワープ
        else if (currentX > warpThresholdRight)
        {
            transform.position = new Vector3(warpThresholdLeft, transform.position.y, transform.position.z);
        }
    }
}