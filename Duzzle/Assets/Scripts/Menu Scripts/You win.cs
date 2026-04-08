using UnityEngine;
using UnityEngine.SceneManagement;

public class Youwin : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {//if the Tag collides with the object with this script the game wil go to the win screen
            if (collision.gameObject.CompareTag("Player1"))
        {
            SceneManager.LoadScene("YouWin");
        }
        if (collision.gameObject.CompareTag("Player2"))
        {
            SceneManager.LoadScene("YouWin");
        }
    }
}
