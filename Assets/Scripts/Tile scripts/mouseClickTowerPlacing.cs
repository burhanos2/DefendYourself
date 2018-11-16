using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClickTowerPlacing : MonoBehaviour
{
    private CreateGrid create_grid;
    private myGrid grid;
    private int intX,
                intY;
    [SerializeField]
    private GameObject Tower;
    

    private void Start()
    { 
        create_grid = gameObject.GetComponentInParent<CreateGrid>();
        print("ik haal hem op");
        grid = create_grid.level_grid;



        intY = Mathf.FloorToInt(gameObject.transform.localPosition.y * -1);
        intX = Mathf.FloorToInt(gameObject.transform.localPosition.x);
    }

    private void OnMouseUpAsButton()
    {
        CheckButton();
    }

    private void CheckButton()
    {
        if (Input.GetMouseButtonUp(0))//check left click
        {
            if (grid.GetTile(intX, intY).IsBlocking == false)
            {
                PlaceTower();
            }
        }
        else if (Input.GetMouseButtonUp(1))//check right click
        {
            if (grid.GetTile(intX, intY).IsBlocking == true)
            {
                RemoveTower();
            }
        }
    }

    private void PlaceTower()
    {
        grid.GetTile(intX, intY).IsBlocking = true;
        Instantiate(Tower, transform);

    }

    private void RemoveTower()
    {
        grid.GetTile(intX, intY).IsBlocking = false;
    }

    private void OnMouseOver()
    {
        print(grid.GetTile(intX, intY).IsBlocking);
    }
}
