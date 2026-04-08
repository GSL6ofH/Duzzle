using UnityEngine;

public class OnbuttonPlayer1 : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;//this makes it so you can choose on what object it has effect

    // Triggered when the player enters the area
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            if (targetObject != null)
            {
                targetObject.SetActive(true); // Turns on
            }
        }
    }

    // Triggered when the player leaves the area
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("Player2"))
        {
            if (targetObject != null)
            {
                targetObject.SetActive(false); // Turns off again
            }
        }
    }
}
