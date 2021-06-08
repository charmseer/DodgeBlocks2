using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public GameObject ExitMenuUI;

    void Update()
    {
        if(UnityEngine.InputSystem.Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Debug.Log("Escape Is Pressed");
            ExitMenuUI.SetActive(true);
            Time.timeScale = 0f;
            //ExitMenu();
        }
        
    }

    public void ExitMenu()
    {
        ExitMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //GameIsPaused = true;
    }

    public void Resume()
    {
        ExitMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //GameIsPaused = false;
    }


}
