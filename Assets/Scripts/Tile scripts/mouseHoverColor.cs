using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseHoverColor : MonoBehaviour {

    private Color hoverColor;
    private Color startColor;

    private Renderer rend;

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }


    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
    
    void Start () {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        hoverColor = startColor + Color.white;
	}
	
	
	void Update () {
		
	}
}
