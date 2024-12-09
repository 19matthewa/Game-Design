using UnityEngine;

public class PlainArmorPowerup : MonoBehaviour
{ void OnTriggerEnter2D(Collider2D other)
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
        stats.hasArmor = true;

        // Remove powerup
        Destroy(gameObject);
    }
}
