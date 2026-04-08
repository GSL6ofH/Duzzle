using UnityEngine;
using UnityEngine.SceneManagement; //needed to switch scenes

public class MenuScript: MonoBehaviour
{
    public void StartGame()
    {
       //loads the next scene in your list
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        // turns the game off
        Debug.Log("the game closes"); //is shown in the console
        Application.Quit();
    }
}