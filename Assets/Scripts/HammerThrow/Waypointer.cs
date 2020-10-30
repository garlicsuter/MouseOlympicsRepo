using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypointer : MonoBehaviour
{
    public SpriteRenderer myRenderer;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        myRenderer.color = new Color(127f, 255f, 0f, 275f); // Set to yellow-ish
        Debug.Log("entered waypoint");
    }
}
