using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveDown : MonoBehaviour
{
    float downForce = 3.5f;
    Text score; // Finds the score from the Scene
    //private float speed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Obtains the value of the score
        score = GameObject.Find("ScoreValue").GetComponent<Text>();

        //Increase the downforce to match the descend speed of the block. Sign is changed
        //to + because there the value of downforce was -3.5. Here it is +3.5
        
        //downForce = downForce + ((float.Parse(score.text)) / 10);

        transform.Translate(Vector2.down * Time.deltaTime * downForce);
        //transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
}
