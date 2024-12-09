using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerStats playerStats; // Reference to the player stats
    public Text coinsText;          // Reference to the coins text
    public Text livesText;          // Reference to the lives text

    void Update()
    {
        // Update the text UI in every frame
        coinsText.text = "Coins: " + playerStats.coins;
        livesText.text = "Lives: " + playerStats.lives;
    }
}
