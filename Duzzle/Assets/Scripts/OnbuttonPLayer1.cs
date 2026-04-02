using UnityEngine;

public class OnbuttonPLayer1 : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;

    // Triggered when the player enters the area
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player1"))
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
        if (other.CompareTag("Player1"))
        {
            if (targetObject != null)
            {
                targetObject.SetActive(false); // Turns off again
            }
        }
    }
}
