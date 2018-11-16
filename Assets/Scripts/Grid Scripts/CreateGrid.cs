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

    public myGrid level_grid;

    // Use this for initialization
    void Awake () {
        _thistransform = GetComponent<Transform>();

        print("ik ga hem aanmaken");
       level_grid = new myGrid(grid_width, grid_height, _thistransform);
        //  _grid[,] = new Tile(new Vector2(0,0),);

        


    }

    //private void OnMouseOver()
    //{
    //    print(level_grid._grid[].Position);
    //}

    // Update is called once per frame
    void Update () {
		
	}
}
    