using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;  // Reference to the player object
    public float moveSpeed = 4f;  // Movement speed of the enemy
    public float stoppingDistance = 1.5f;  // Minimum distance to stop following

    void Update()
    {
        // Check the distance between the enemy and the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer > stoppingDistance)
        {
            // Calculate direction to the player
            Vector3 direction = (player.position - transform.position).normalized;

            // Move the enemy towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Ensure the enemy only rotates on the Y-axis to face the player
            Vector3 lookDirection = new Vector3(player.position.x, transform.position.y, player.position.z);
            transform.LookAt(lookDirection);
        }
    }
}
