using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiralStart : MonoBehaviour
{
    public GameObject spiralGroup;
    public GameObject waypoints;

    // Start is called before the first frame update
    void Start()
    {
        
        //spiralGroup.GetComponent<HammerThrow>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("Start says you clicked Start");
        spiralGroup.GetComponent<HammerThrow>().isThrowing = true;

        StartCoroutine(spiralGroup.GetComponent<HammerThrow>().StartCountdown());
        waypoints.SetActive(true);
    }
}
