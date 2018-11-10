using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [ExecuteInEditMode]

public class CreateGrid : MonoBehaviour {
    [SerializeField]
    private short grid_width;
    [SerializeField]
    private short grid_height;
    private Transform _thistransform;

    // Use this for initialization
    void Start () {
        _thistransform = GetComponent<Transform>();

       myGrid level_grid = new myGrid(grid_width, grid_height, _thistransform);
        //  _grid[,] = new Tile(new Vector2(0,0),);

        print(level_grid.IsOnGrid(9, -4));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
    