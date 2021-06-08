using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    //public static bool GameIsPaused = false;
    // Start is called before the first frame update
    public GameObject PauseMenuUI;

    void Update()
    {

    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //GameIsPaused = false;
    }

    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //GameIsPaused = true;
    }

    public void MainMenu()
    {
        PauseMenuUI.SetActive(false);
        // When you hit Pause Time Scale freezes, So before you go to Main Menu you have to unfreeze it
        Time.timeScale = 1f;
        //GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }

    public void EndGame()
    {
        Debug.Log("Player has chosen to quit the Game");
        Application.Quit();
    }
}
