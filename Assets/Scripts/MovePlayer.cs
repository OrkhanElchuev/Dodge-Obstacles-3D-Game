using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0f, zValue);
    }
}
