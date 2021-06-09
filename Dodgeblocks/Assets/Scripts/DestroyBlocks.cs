using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    //public float gravityVar = 5;

    private Rigidbody2D rb;
    float downForce = -3.5f;

    //[SerializeField] public float downwardForce = 20f;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/gravityVar;
        rb.velocity = new Vector2(0f, downForce);

    }

    void Start()
    {   

    }
    // Update is called once per frame
    void FixedUpdate()
    {

    }

    void OnCollisionEnter2D()
    {
            Destroy(gameObject);
    }
}
