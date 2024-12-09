using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int coins = 0;
    public int lives = 3;

    public bool hasArmor = false;

    public GameObject armorModel; // Reference to the armor model

    void Update()
    {
        if (hasArmor)
        {
            armorModel.SetActive(true); // Enable the armor model
        }
        else
        {
            armorModel.SetActive(false); // Disable it when no armor
        }
    }

    public void TakeDamage()
    {
        if (hasArmor)
        {
            // Armor absorbs the damage, deactivate armor instead of losing a life
            hasArmor = false;
            armorModel.SetActive(false); // Disable armor model
        }
        else
        {
            // No armor, player loses a life
            lives--;
            if (lives <= 0)
            {
                Die(); // Handle player death (you can add your death logic here)
            }
        }
    }

    void Die()
    {
        // Handle player death (e.g., restart level or trigger game over)
        Debug.Log("Player is dead!");
        // Restart the game or trigger game over logic
    }
}
