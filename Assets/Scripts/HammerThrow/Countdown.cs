using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Countdown : MonoBehaviour
{
    float timeLeft = 10.0f;
    public Text text;

    //public GameManager gm;



    void Update()
    {
        timeLeft -= Time.deltaTime;
        text.text = "Time Left: " + Mathf.Round(timeLeft);
        //if (timeLeft < 0)
        //{
        //    gmX.GameOver();
        //}
    }
}