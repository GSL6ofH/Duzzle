using UnityEngine;
using UnityEngine.SceneManagement;

public class Youwin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player1"))
        {
            SceneManager.LoadScene("Menu");
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
