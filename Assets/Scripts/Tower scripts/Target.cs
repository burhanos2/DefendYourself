using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script can pick up the speed of a trigger
//it will also put gameobjects that come in in the list, and remove them when out of the list

public class Target : MonoBehaviour {
    private RotateTowards rotate;
    private GameObject enemy;
    private List<GameObject> enemyCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        enemyCount.Add(collision.gameObject);
        Waypoint_Movement enemyWpoints =  collision.GetComponent<Waypoint_Movement>();
        float vel = enemyWpoints.speed;

        print(vel);
        print(enemyCount[0]);
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        enemyCount.Remove(collision.gameObject);
    }

    private void OnTriggerStay2D(Collider2D collision)
    { 
        rotate.RotateToNext(this.transform, collision.transform.position);
    }

    private void Start()
    {
        rotate = new RotateTowards();
        enemyCount = new List<GameObject>();
    }
}
