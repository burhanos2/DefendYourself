using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowards {

    public void RotateToNext(Transform this_object, Vector3 target)
    {
        Vector3 dir = target - this_object.position;
        //needed a little tutorial for this calculation here but it basically converts the difference in position to degrees
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        this_object.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
