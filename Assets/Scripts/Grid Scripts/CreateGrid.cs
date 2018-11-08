using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour {
    [SerializeField]
    private short grid_width;
    [SerializeField]
    private short grid_height;



	// Use this for initialization
	void Start () {
       myGrid level_grid = new myGrid(grid_width, grid_height);
        //  _grid[,] = new Tile(new Vector2(0,0),);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
    