using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillChildren : MonoBehaviour {


    public void Kill_All_Children(Transform parent)
    {
        for (int i = 0; i < parent.childCount; i++)
        {
            Destroy(parent.GetChild(i).gameObject, 0.1f);
            Debug.Log("child killed");
        }
        
    }
}
