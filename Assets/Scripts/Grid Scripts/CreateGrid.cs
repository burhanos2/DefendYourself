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
    
    void Awake () {
        _thistransform = GetComponent<Transform>();

       
       level_grid = new myGrid(grid_width, grid_height, _thistransform);
        
    }

}
    