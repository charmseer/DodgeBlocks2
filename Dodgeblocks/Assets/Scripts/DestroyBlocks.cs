using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyBlocks : MonoBehaviour
{
    //public float gravityVar = 5;

    private Rigidbody2D rb;
    float downForce = -3.5f;
    //[SerializeField] public float downwardForce = 20f;
    Text score;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        //Finds GameObject called ScoreValue and takes it's Text component and assigns it to the variable score.
        score = GameObject.Find("ScoreValue").GetComponent<Text>();

        //GetComponent<Text>().ScoreValue();
        //Debug.Log(score.text);

        //GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/gravityVar;
        //Debug.Log(score.text);
        //rb.velocity = new Vector2(0f, downForce);
        rb.velocity = new Vector2(0f, downForce - ((float.Parse(score.text)) / 10));
        Debug.Log(rb.velocity.ToString());


    }

    void Start()
    {   

    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }

    /*    void OnCollisionEnter2D(Collider other)
        {
            Destroy(gameObject);
            if (other.gameObject.tag == "Player")
            {
                GameObject.Find("CrashStars").SetActive(true);
            }
            else
            {
                Destroy(gameObject);
            }

        }*/
    void OnCollisionEnter2D()
    {
        Destroy(gameObject);
    }
}
