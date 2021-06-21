using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBG : MonoBehaviour
{   
    // initial Position of the background is stored in this variable
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.y);
        // Offset value works at around 9.9 -10.1 range for this image
        if (transform.position.y < startPos.y - 10)
        {
            transform.position = startPos;
        }
    }
}
