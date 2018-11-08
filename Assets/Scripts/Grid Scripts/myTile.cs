using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script borrowed but edited

public class myTile {
    
   public enum tileTypes
    {
        Ground,
        Tower,
        Path,
        EndPiece
    };

	public myTile (Vector2 position, tileTypes type = tileTypes.Ground, bool isBlocking = false){
		Position = position;
        tileTypes Type = type;
		IsBlocking = isBlocking;
	}

	public Vector2 Position { get; set; }

	public string Type { get; set; }

	public bool IsBlocking { get; set; }
}
