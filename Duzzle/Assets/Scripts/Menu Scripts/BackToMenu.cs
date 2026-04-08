using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //restart button code(the button is just a text)
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
