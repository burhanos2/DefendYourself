using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour {
    private TileTypesClass thisType;
    private Renderer rend;

	void Start () {
        thisType = GetComponent<TileTypesClass>();
        rend = GetComponent<Renderer>();

        switch(thisType.objectType)
        {
            case tileTypes.Ground:
                rend.material.color = Color.gray;   
                break;
            case tileTypes.Tower:
                rend.material.color = Color.yellow;
                break;
            case tileTypes.BeginPath:
                rend.material.color = Color.red;
                break;
            case tileTypes.Path:

                break;

        }
        
    }
	
}
