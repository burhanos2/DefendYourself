using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_Movement : MonoBehaviour {

    [SerializeField]
    private float speed;
    private float _step;
    private float angle;

    private Waypoints points;

    private Transform thisTransform;

    private Vector3 dir;
    private Vector3 thisPos;
    private Vector3 _wayPointPos;

    private short i;
    // index of waypoints

    RotateTowards _rotate;

    void Start()
    {
        thisTransform = this.transform;
        _rotate = new RotateTowards();
        points = GameObject.FindGameObjectWithTag("Waypoints").GetComponent<Waypoints>();
    }

    void Update()
    {
        DoUpdate(); 
        
    }
    // this update is going to be used by alot of enemies, this way the update only has one task to loop

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
               transform.position = Vector2.MoveTowards
               (
               thisPos,
               _wayPointPos,
               _step
               );
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
                DestroyImmediate(this.gameObject);
            }
        }
    }

}
