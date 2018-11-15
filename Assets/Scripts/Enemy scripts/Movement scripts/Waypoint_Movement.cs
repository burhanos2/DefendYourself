using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Movement : Waypoint_EndPoint {
   
    //floats
    
    public float speed;
    private float _step;

    //class instances
    private Waypoints points;
    private readonly RotateTowards _rotate = new RotateTowards();

    //transforms
    private Transform thisTransform;

    //vectors
    private Vector3 dir,
                    thisPos,
                    _wayPointPos;

    //integers
    private short i;   // index of waypoints


    void Start()
    {
        thisTransform = this.transform;
        points = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    void Update()
    {
        DoUpdate(); 
        
    }
    // this update is going to be used by a lot of enemies, this way the update only has one task to loop

    private void DoUpdate()
    {
        _wayPointPos = points._waypoints[i].position;
        _step = speed * Time.deltaTime;
        thisPos = transform.position;
        _rotate.RotateToNext(thisTransform, _wayPointPos);
        Move_Towards();
        PickNextPoint();
    }

    //functions under here
    private void Move_Towards()
        {
               transform.position = Vector2.MoveTowards(thisPos, _wayPointPos, _step);
        }

    private void PickNextPoint()
    {
        if (Vector2.Distance(thisPos, _wayPointPos) < 0.1f)
        {

            if (i < points._waypoints.Length - 1)
            {
                i++;
            }
            else
            {
                EndPoint(this.gameObject);
            }
        }
    }

}
