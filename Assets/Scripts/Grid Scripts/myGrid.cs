using System.Collections.Generic;
using UnityEngine;

//script borrowed but heavily edited


public class myGrid
{
    const short startPointX = 0;
    const short startPointY = 0;
    private KillChildren kill = new KillChildren();

    /// <summary>
    /// The tiles for this grid.
    /// </summary>
    public readonly myTile[,] _grid;

    /// <summary>
    /// Constructor.
    /// </summary>
    /* 
       <param name="width">Width of the grid (amount of columns)</param>
       <param name="height">Height of the grid (amount ofrows)</param> 
       */
    public myGrid(int width, int height, Transform parent)
    {
        if (width < 0 || height < 0)
        {
            throw new System.InvalidOperationException("width and height cannot be smaller than zero");
        }

        Width = width;
        Height = height;

        _grid = new myTile[Width, Height];
        

        //if another grid exists, remove it and make it again.
        if (parent.childCount != (Height * Width))
        {
            kill.Kill_All_Children(parent);
            //kill all children before creating new ones
            for (var x = 0; x < Width; x++)
            {
                for (var y = 0; y < Height; y++)
                {
                    CreateTile(parent, x, y);
                }
            }
        }
       
    }

    /// <summary>
    /// The width of the grid.
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// The height of the grid.
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Gets a Tile from the grid.
    /// </summary>
    /// <param name="x">x position of the tile.</param>
    /// <param name="y">y position of the tile.</param>
    /// <returns></returns>
    public myTile GetTile(int x, int y)
    {
       
        // todo 1: ik return nu 'null'. Zorg ervoor dat jullie de Tile returnen die op plek x en y staat in ons grid

        // todo 2: bouw een check in of de x en y wel binnen het grid valt

        return null;
    }

    /// <summary>
    /// Determines if a x & y position is within the grid
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public bool IsOnGrid(float x, float y)
    {

        float xCalc = x;
        float yCalc = y;

        Debug.Log(xCalc);
        Debug.Log(yCalc);

        if( xCalc > Width   ||
            xCalc < Width - Width  ||
            yCalc < -Height  ||
            yCalc > Height - Height )
        {
            return false;
        }
        else
        {
            return true;
        }
    }
	
    private void CreateTile(Transform parent, int x, int y)
    {
        var currentPosition = new Vector2(x, y);
        _grid[x, y] = new myTile(currentPosition);
        GameObject Tile = GameObject.CreatePrimitive(PrimitiveType.Quad);
        Tile.AddComponent<TileTypesClass>();
        Tile.transform.SetParent(parent);
        Vector3 tileDim = Tile.GetComponent<Renderer>().bounds.size;
        Tile.transform.position = new Vector3(startPointX + (tileDim.y * x), startPointY - (tileDim.x * y), 0);
        Tile.AddComponent<mouseHover>();
        Tile.AddComponent<ColorPicker>();
        Debug.Log("children made");
    }
 
}