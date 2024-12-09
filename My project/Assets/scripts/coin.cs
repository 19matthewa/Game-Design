using UnityEngine;

public class coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            pickup(other);
        }
    }

    void pickup(Collider2D player)
    {
        // Add score

        PlayerStats stats = player.gameObject.GetComponent<PlayerStats>();
        stats.coins++;

        if (stats.coins == 50)
        {
            stats.lives++;
            stats.coins = 0;
        }
        // Remove coin
        Destroy(gameObject);
    }
}
