using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    //public float gravityVar = 5;

    private Rigidbody2D rb;
    [SerializeField] public float downwardForce = 20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       // GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/gravityVar;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(new Vector2(0, downwardForce) * Time.deltaTime , ForceMode2D.Force);
    }

    void OnCollisionEnter2D()
    {
        
            Destroy(gameObject);
        
    }
}
