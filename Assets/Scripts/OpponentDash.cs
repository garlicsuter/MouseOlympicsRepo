using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpponentDash : MonoBehaviour
{
    private Rigidbody2D opponentRb;
    public GameObject player;
    public Vector2 opponentVector;
    public TextMeshProUGUI ow;
    public bool gameOver;
    public bool winnerDeclared;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOver = player.GetComponent<PlayerControllerDash>().gameOver;
        winnerDeclared = player.GetComponent<PlayerControllerDash>().winnerDeclared;
        opponentRb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        opponentRb.velocity = opponentVector;
        if (gameOver)
        {
            //rb2d.AddForce(transform.right * speed);
            opponentRb.velocity = -Vector2.zero;
            opponentRb.angularVelocity = 0f;
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Finish" && player.GetComponent<PlayerControllerDash>().gameOver == false)
        {
            player.GetComponent<PlayerControllerDash>().winnerDeclared = true;
            ow.text = "Opponent Wins!";
            player.GetComponent<PlayerControllerDash>().gameOver = true;
            Debug.Log("Opponent says game is over!");
            

            //"Opponent Wins!" Text
           
            
        }
    }
}
