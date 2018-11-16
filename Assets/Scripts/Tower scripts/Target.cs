using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script can pick up the speed of a trigger
//it will also put gameobjects that come in in the list, and remove them when out of the list

public class Target : MonoBehaviour
{

    private Vector3 predictRotate;
    private RotateTowards rotate;
    private GameObject enemy;
    public List<GameObject> enemyCount;
    private float velocity;
    private float gottenSpace;
    private Predict predict;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyCount.Add(collision.gameObject);
            Waypoint_Movement enemyWpoints = collision.GetComponent<Waypoint_Movement>();
            velocity = enemyWpoints.speed;
        }
    }

   

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyCount.Remove(collision.gameObject);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        { 
            predictRotate = new Vector3(enemyCount[0].transform.localPosition.x + gottenSpace, collision.transform.localPosition.y + gottenSpace, 0);
            rotate.RotateToNext(this.transform, predictRotate);
        }
    }

    private void Start()
    {
        predict = gameObject.GetComponent<Predict>();
        rotate = new RotateTowards();
        enemyCount = new List<GameObject>();
    }

    private void Update()
    {
        gottenSpace = predict.GetSpace;

        DeleteNullsInList();
    }
    
    private void DeleteNullsInList()
    {
        //lets just remove anything thats null
        if (enemyCount.Count > 0 && enemyCount[0] == null)
        {
            enemyCount.Remove(null);
        }
    }


    public float GetVelocityOfEnemy { get { return velocity; } }

    public Vector3 PositionOfEnemy
    {
        get
        {
            if (enemyCount[0] != null)
            { 
            return enemyCount[0].transform.position;
            }
            else
            {
                return enemyCount[1].transform.position;
            }
        }
    }

}
