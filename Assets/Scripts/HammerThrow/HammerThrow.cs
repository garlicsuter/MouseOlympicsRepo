using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HammerThrow : MonoBehaviour
{
    public bool isSpinning = false;
    public bool isThrowing = false;
    public GameObject spiralStart;
    //public float momentum = 0.0f;
    //public TextMeshProUGUI momentumText;
    public TextMeshProUGUI timeText;
    private float startTime = 0.0f;


    float currCountdownValue;

    public IEnumerator StartCountdown(float countdownValue = 10)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Debug.Log("Countdown: " + currCountdownValue);
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
            timeText.text = currCountdownValue.ToString();
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnMouseOver()
    {
        if(isThrowing == true)
        {
            Debug.Log("You hit the spiral");
            //subtracts from momentum when mouse over spiral
            //momentum -= 0.2f;
            //UpdateMomentumText();
        }
        
    }

    //void UpdateMomentumText()
    //{
    //    momentumText.text = momentum.ToString();
    //}
}
