using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script is attached to Background Double
public class MoveDown : MonoBehaviour
{
    private Rigidbody2D rb;
    float downForce = 3.5f;
    Text score; // Finds the score from the Scene
                //private float speed = 30;
                // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
        rb.velocity = new Vector2(0f, -(downForce + ((float.Parse(score.text)) / 10)));


        //Add this to basic movement for flawed increasing velocity
        //downForce = (downForce + ((float.Parse(score.text)) / 10));

        //basic movement
        //transform.Translate(Vector2.down * Time.deltaTime * downForce);

        //Format from Unit3
        //transform.Translate(Vector3.left * Time.deltaTime * speed);

    }
}
