using UnityEngine;

public class MoveDirectionController : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public bool moveRight = false; // false = left, true = right

    void Update()
    {
        float direction = moveRight ? 1f : -1f;
        transform.position += Vector3.right * direction * moveSpeed * Time.deltaTime;
    }
}
