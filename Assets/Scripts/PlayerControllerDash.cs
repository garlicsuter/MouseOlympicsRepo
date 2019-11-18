using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerControllerDash : MonoBehaviour
{
    //Floating point variable to store the player's movement speed.
    public float speed;
    public Vector2 playerVector;
    public Button lButton;
    public Button rButton;
    public bool gameOver = false;
    public TextMeshProUGUI pw;
    public bool winnerDeclared;


    //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        //playerVector = new Vector2(5.0f, 0.0f);
        rb2d = GetComponent<Rigidbody2D>();
        //lButton = GameObject.Find("lButton");
        //rButton = GameObject.Find("rButton");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish" && winnerDeclared == false)
        {
            gameOver = true;

  

            winnerDeclared = true;
            rb2d.velocity = -Vector2.zero;
            rb2d.angularVelocity = 0f;
            //Debug.Log("Game should be oveR");
            pw.text = "Player Wins!";
        }
    }
    private void Update()
    {
       
        
    }


    public void MoveRight()
    {
        //Use the two store floats to create a new Vector2 variable movement.
        //Vector2 movement = new Vector2( );

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        if (!gameOver)
        {
            //rb2d.MovePosition(rb2d.position + playerVector * speed * Time.fixedDeltaTime);
            //rb2d.AddForce(rb2d.position + playerVector * speed * Time.fixedDeltaTime);
            rb2d.AddForce(transform.right * speed);
            //rb2d.velocity = playerVector;
            if (rButton.interactable == false)
            {
                lButton.interactable = false;
                rButton.interactable = true;
            }
            else
            {
                rButton.interactable = false;
                lButton.interactable = true;
            }
        }
            

        
        
        

    }
}
