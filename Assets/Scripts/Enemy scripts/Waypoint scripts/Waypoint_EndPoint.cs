using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint_EndPoint : MonoBehaviour {

	public void EndPoint(Object this_obj)
    {
        //this is preformed before gameobject reaches the end
        Destroy(this_obj);
    }
}
