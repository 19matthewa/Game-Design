using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    public int coins = 0;
    public int lives = 3;

    public bool hasArmor = false;

    public GameObject armorModel; // Reference to the armor model

    public Text levelFailText;

    void Start()
    {
        // Ensure the level complete text is initially hidden
        if (levelFailText != null)
        {
            levelFailText.gameObject.SetActive(false);
        }
    }
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
            Debug.Log("Level Failed!");
            levelFailText.gameObject.SetActive(true);
        }
    }

    void Die()
    {
        // Handle player death (e.g., restart level or trigger game over)
        Debug.Log("Player is dead!");
        // Restart the game or trigger game over logic
    }
}
