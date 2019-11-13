using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerDash : MonoBehaviour
{
    //Floating point variable to store the player's movement speed.
    public float speed;
    public Vector2 playerVector;

    //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        playerVector = new Vector2(5.0f, 0.0f);
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void MoveRight()
    {
        //Use the two store floats to create a new Vector2 variable movement.
        //Vector2 movement = new Vector2( );

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.MovePosition(rb2d.position + playerVector * Time.fixedDeltaTime);


    }
}
