using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public Transform player;             // Player's Transform
    public float leftBoundary = 2f;      // Left boundary for camera movement
    public float rightBoundary = 2f;     // Right boundary for camera movement
    public float verticalBoundary = 2f;  // Vertical boundary for camera movement
    public float smoothSpeed = 0.1f;     // Smooth speed for all directions (horizontal and vertical)
    public float verticalStartHeight = 0f; // The initial y position of the camera to prevent going below it

    private Vector3 cameraOffset;         // Camera offset relative to the player
    private Vector3 targetPosition;       // Target position for the camera

    void Start()
    {
        // Initialize camera offset
        cameraOffset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Ensure player reference is not null
        if (player == null)
        {
            Debug.LogError("Player reference is not assigned!");
            return;
        }

        // Current camera position and player's position
        Vector3 cameraPosition = transform.position;
        Vector3 playerPosition = player.position;

        // Calculate horizontal camera boundaries
        float cameraLeft = cameraPosition.x - Camera.main.orthographicSize * Camera.main.aspect + leftBoundary;
        float cameraRight = cameraPosition.x + Camera.main.orthographicSize * Camera.main.aspect - rightBoundary;

        // Calculate vertical camera boundaries
        float cameraTop = cameraPosition.y + verticalBoundary;
        float cameraBottom = cameraPosition.y - verticalBoundary;

        // Horizontal Camera Movement (left-right)
        if (playerPosition.x < cameraLeft)
        {
            targetPosition.x = Mathf.Lerp(cameraPosition.x, playerPosition.x - Camera.main.orthographicSize * Camera.main.aspect + leftBoundary, smoothSpeed);
        }
        else if (playerPosition.x > cameraRight)
        {
            targetPosition.x = Mathf.Lerp(cameraPosition.x, playerPosition.x + Camera.main.orthographicSize * Camera.main.aspect - rightBoundary, smoothSpeed);
        }
        else
        {
            targetPosition.x = cameraPosition.x;
        }

        // Vertical Camera Movement (up and down), restricted to not go below starting y position
        if (playerPosition.y > cameraTop) // Moving up
        {
            targetPosition.y = Mathf.Lerp(cameraPosition.y, playerPosition.y - verticalBoundary, smoothSpeed);
        }
        else if (playerPosition.y < cameraBottom) // Moving down
        {
            targetPosition.y = Mathf.Lerp(cameraPosition.y, playerPosition.y + verticalBoundary, smoothSpeed);
        }
        else
        {
            targetPosition.y = cameraPosition.y;
        }

        // Ensure the camera doesn't move below the starting point
        if (targetPosition.y < verticalStartHeight)
        {
            targetPosition.y = verticalStartHeight;
        }

        // Smooth transition for camera position
        transform.position = Vector3.Lerp(cameraPosition, targetPosition, smoothSpeed);

        // Optionally, lock the Z position if working in 2D
        transform.position = new Vector3(transform.position.x, transform.position.y, cameraPosition.z);
    }
}
