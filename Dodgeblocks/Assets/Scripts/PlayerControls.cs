using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float speed = 15f;
    public float mapWidth = 5.5f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Debug.Log("Game Begins");
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        //rb.position is in (x,y) format so you can only add something
        //else in the same format. Vector2.right adds a vector that is (1,0)

        // x is the float that is received from user. So we have Direction and magnitude
        //to make the rigidbody move
        rb.MovePosition(newPosition);

    }

}
