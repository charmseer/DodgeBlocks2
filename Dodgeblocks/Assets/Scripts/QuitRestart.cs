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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
