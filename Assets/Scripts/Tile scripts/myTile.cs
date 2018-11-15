using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script borrowed but edited
public enum tileTypes
    {
        Ground,
        Tower,
        BeginPath,
        Path
    }

public class myTile {
    
	public myTile (Vector2 position, bool isBlocking = false){
        Position = position;
		IsBlocking = isBlocking;
	}

	public Vector2 Position
    {
        get; set;
        //get { return Position; }
        //set { Position = value; }
    }

	//public string Type { get; set; }

	public bool IsBlocking { get; set; }
}
