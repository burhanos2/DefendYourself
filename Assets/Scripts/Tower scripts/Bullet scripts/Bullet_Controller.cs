using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    [HideInInspector]
    public float _bulletSpeed = 0.045f;
    private Vector3 dir;

    private void Start()
    {
        
    }

    // lets make this fixed update to keep the movement stable
    private void FixedUpdate()
    { 
        if (gameObject.tag == "Bullet")
        {
            //make it move into the rotated direction
            transform.position += transform.right;
        }
	}
}
