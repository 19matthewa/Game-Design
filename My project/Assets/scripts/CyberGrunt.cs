using UnityEngine;
using System.Collections; // Required for coroutines

public class GoombaMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2f; // Adjustable speed
    public float freezeTime = 0.5f; // Time to freeze before reversing direction

    private Rigidbody2D rb;
    private bool movingLeft = true;
    private bool isFrozen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (!isFrozen)
        {
            // Move the object at a constant speed
            rb.linearVelocity = new Vector2(movingLeft ? -speed : speed, rb.linearVelocity.y);
        }
        else
        {
            // Keep the Goomba frozen (no movement)
            rb.linearVelocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            // Get the contact points of the collision
            foreach (ContactPoint2D contact in collision.contacts)
            {
                // Check if the collision is on the side of the collider
                if (Mathf.Abs(contact.normal.x) > Mathf.Abs(contact.normal.y))
                {
                    // Freeze the Goomba, then reverse direction
                    StartCoroutine(FreezeAndReverse());
                    break;
                }
            }
        }

        if (collision.gameObject.CompareTag("Player") && !(transform.position.y+1 < collision.transform.position.y))
        {
            // Get the PlayerStats component from the player
            PlayerStats playerStats = collision.gameObject.GetComponent<PlayerStats>();

            if (playerStats != null)
            {
                playerStats.TakeDamage(); // Call TakeDamage when the Goomba collides with the player
            }
        }
    }

    // Coroutine to freeze the Goomba and then reverse direction
    private IEnumerator FreezeAndReverse()
    {
        isFrozen = true; // Freeze the Goomba
        yield return new WaitForSeconds(freezeTime); // Wait for the specified freeze time
        ReverseDirection(); // Reverse the direction
        isFrozen = false; // Unfreeze the Goomba
    }

    void ReverseDirection()
    {
        movingLeft = !movingLeft;
    }
}
