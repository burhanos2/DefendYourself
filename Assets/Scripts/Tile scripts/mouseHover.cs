using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHover : MonoBehaviour {

    private Color hoverColor;
    private Color startColor;

    private Renderer rend;

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseOver()
    {
       
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }

    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        hoverColor = startColor + Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
