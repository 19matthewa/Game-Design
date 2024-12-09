using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 7f; // Maximum speed
    public float jumpForce = 15f; // Initial jump force
    public float jumpCutMultiplier = 0.5f; // How much to reduce upward velocity when releasing jump
    public float bounceForce = 10f; // Force applied when killing an enemy

    void FixedUpdate()
    {
        // Horizontal movement
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);

        // Deceleration when no input is pressed
        if (horizontalInput == 0)
        {
            rb.linearVelocity = new Vector2(Mathf.MoveTowards(rb.linearVelocity.x, 0, 10f * Time.deltaTime), rb.linearVelocity.y);
        }
    }

    void Update()
    {
        // Jump logic
        if (Input.GetKeyDown(KeyCode.UpArrow) && Mathf.Abs(rb.linearVelocity.y) < 0.01f)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // Cut jump when releasing the jump button
        if (Input.GetKeyUp(KeyCode.UpArrow) && rb.linearVelocity.y > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, rb.linearVelocity.y * jumpCutMultiplier);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the player collides with an enemy from above
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Bounce the player if colliding from above
            if (transform.position.y > collision.transform.position.y+1)
            {
                BouncePlayer();
                // You can call a method to destroy or disable the enemy here
                Destroy(collision.gameObject); // Example: Destroy the enemy (Goomba)
            }
        }
    }

    void BouncePlayer()
    {
        // Apply upward force to simulate bounce effect
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounceForce);
    }
}
