using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerActionControls playerActionControls;

    [SerializeField]private float speed;
    [SerializeField]private float mapWidth = 5.5f;

    private void Awake()
    {
        /* Awake runs before Start and it's used when you
        need to do something in one script before doing something
        in another script before the start of the game
        */
        playerActionControls = new PlayerActionControls();

    }
    void Start()
    {
        
    }
    void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }


    // Update is called once per frame
    void Update()
    {
        //Read the movement values
        float movementInput = playerActionControls.Slide.Move.ReadValue<float>();

        //Move the player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * speed * Time.deltaTime;
        currentPosition.x = Mathf.Clamp(currentPosition.x, -mapWidth, mapWidth);
        /*        if( currentPosition.x < -mapWidth)
                {
                    currentPosition.x = -mapWidth;
                }
                else if (currentPosition.x > mapWidth)
                {
                    currentPosition.x = mapWidth;
                }*/
        transform.position = currentPosition;
    }
}
