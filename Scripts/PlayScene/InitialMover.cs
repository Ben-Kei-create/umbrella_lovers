using UnityEngine;

public class InitialMover : MonoBehaviour
{
    public float moveSpeed = 0.5f; // 調整可能：1秒間に移動する量

    void Update()
    {
        // 左方向に一定速度で移動
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
