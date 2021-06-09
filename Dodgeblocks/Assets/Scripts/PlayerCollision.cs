using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController movement;
    public GameObject gameOverPanel;
    public GameObject blockSpawner;


    void OnCollisionEnter2D()
    {
        Debug.Log("We've been hit!");

        // Disables the Playermovement script
        movement.enabled = false;

        //Shows the GameOver Screen
        gameOverPanel.SetActive(true);

        //Stops Blockspawner from spawning next wave
        blockSpawner.SetActive(false);

        //FindObjectOfType<GameManager>().EndGame();
    }

}
