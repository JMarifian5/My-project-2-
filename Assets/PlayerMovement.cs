using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement

    private Vector3 movement; // Store movement input

    void Update()
    {
        // Get input from keyboard
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D or Left/Right Arrows
        float moveZ = Input.GetAxisRaw("Vertical");   // W/S or Up/Down Arrows

        // Combine movement into a Vector3
        movement = new Vector3(moveX, 0, moveZ).normalized;

        // Move the player
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
