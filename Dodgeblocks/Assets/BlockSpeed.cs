using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpeed : MonoBehaviour
{
    
    //public Rigidbody2D rb;
    float downForceMod = 3.5f;
    
    void Awake()
    {
        //rb = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/gravityVar;

        

    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject blockPrefab = GameObject.Find("Block");

        Debug.Log("Velocity is" + blockPrefab.GetComponent<Rigidbody2D>().velocity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject blockPrefab = GameObject.Find("Block");

        if (Time.timeSinceLevelLoad % 10 == 0)
        {
            Debug.Log("Entered DownForce if statement");
            downForceMod -= 5f;
            blockPrefab.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, downForceMod);
            Debug.Log("DownForce inside if statement is" + downForceMod);
            Debug.Log(blockPrefab.GetComponent<Rigidbody2D>().velocity);
        }

        else
        {
            blockPrefab.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, downForceMod);
        }

        Debug.Log("DownForce outside the if statement" + downForceMod);
        //rb.AddForce(new Vector2(0, downwardForce) * Time.deltaTime , ForceMode2D.Force);
    }
}
