using UnityEngine;
using UnityEngine.UI;  // Make sure to import this for UI components

public class EndTrigger : MonoBehaviour
{
    // Reference to the UI Text component
    public Text levelCompleteText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Ensure the level complete text is initially hidden
        if (levelCompleteText != null)
        {
            levelCompleteText.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player has triggered the end
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Level Complete!");
            
                levelCompleteText.gameObject.SetActive(true);
            
        }
    }
}
