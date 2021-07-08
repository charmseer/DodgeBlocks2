using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitRestart : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    public void RestartGame()
    {
        Debug.Log("We are restarting!");
        Time.timeScale = 1f; //Had to implement this because Time.timeScale 
        //was set to 0 on Game Over Screenelse the score goes up when 

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        //PauseMenuUI.SetActive(false);
        // When you hit Pause Time Scale freezes, So before you go to Main Menu you have to unfreeze it
        Time.timeScale = 1f;
        //GameIsPaused = false;
        SceneManager.LoadScene("Menu");
    }
}
