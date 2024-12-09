using UnityEngine;

public class flagTopLife : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            addLife(other);
        }
    }

    void addLife(Collider2D player)
    {
        // Add score

        PlayerStats stats = player.gameObject.GetComponent<PlayerStats>();
        stats.lives++;

 
    }
}
