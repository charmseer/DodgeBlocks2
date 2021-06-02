using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlocks : MonoBehaviour
{
    public float gravityVar = 20;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad/gravityVar;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D()
    {
        
            Destroy(gameObject);
        
    }
}
