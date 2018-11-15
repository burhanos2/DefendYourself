using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Delete : MonoBehaviour
{
    
    void Start()
    {
        var obj = gameObject.GetComponent<Bullet_Controller>();
        Destroy(this.gameObject, (0.5f/obj._bulletSpeed));
    }

}

