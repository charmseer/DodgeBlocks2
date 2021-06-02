using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreValue;
    public Text scoreValue2;

    public int counter;

    private void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        counter += 1; 
        Debug.Log("Col lided with ScoreBase");

        scoreValue.text = (counter / 4).ToString();
        scoreValue2.text = (counter / 4).ToString();
    }
}
