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

    private short Towercost = 60;

    private void Start()
    { 
        create_grid = gameObject.GetComponentInParent<CreateGrid>();
        grid = create_grid.level_grid;



        intY = Mathf.FloorToInt(gameObject.transform.localPosition.y * -1);
        intX = Mathf.FloorToInt(gameObject.transform.localPosition.x);
    }

    private void OnMouseOver()
    {
        CheckButton();
    }

    private void CheckButton()
    {
        if (Input.GetMouseButtonUp(0) && grid.GetTile(intX, intY).IsBlocking == false)//check left click
        {
                PlaceTower();
        }
        if (Input.GetMouseButtonUp(1) && grid.GetTile(intX, intY).IsBlocking == true)//check right click
        {
                RemoveTower();
        }
    }

    private void PlaceTower()
    {
        if(Money_count.money >= 60)
        {
            Money_count.money -= Towercost;
            grid.GetTile(intX, intY).IsBlocking = true;
            Instantiate(Tower, transform);
        }

    }

    private void RemoveTower()
    {
        grid.GetTile(intX, intY).IsBlocking = false;
        grid.kill.Kill_All_Children(gameObject.transform);
        Money_count.money += (Towercost/2);
    }
}
