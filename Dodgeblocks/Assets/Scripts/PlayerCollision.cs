using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GameObject gameOverPanel;
    public GameObject blockSpawner;
    public GameObject CrashParticles;


    void OnCollisionEnter2D()
    {
        Debug.Log("We've been hit!");

        CrashParticles.SetActive(true);

        // Disables the Playermovement script
        movement.enabled = false;

        Invoke("Reload", 0.3f);


    }

    void Reload()
    {

        //Shows the GameOver Screen
        gameOverPanel.SetActive(true);

        //Stops Blockspawner from spawning next wave
        blockSpawner.SetActive(false);

        //Freezes all blocks when the player collides with a Block.
        // Had to implement this because else the score goes up when 
        // the On screen wave descends and hits the ScoreBase
        Time.timeScale = 0f;
        //FindObjectOfType<GameManager>().EndGame();
    }

}
