using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreValue; // For on screen active Score Object
    public Text scoreValue2; // For score displayed when Game Over Panel's Score Object


    public int counter; // Everytime a block collides with ScoreBase the counter goes up by one

    private void Start()
    {
        
    }
    private void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        counter += 1;
        Debug.Log("Collided with ScoreBase");

        scoreValue.text = (counter / 4).ToString(); // 4 boxes collide with the Scorebase but score only needs to go up once 
        scoreValue2.text = (counter / 4).ToString();

    }
}
