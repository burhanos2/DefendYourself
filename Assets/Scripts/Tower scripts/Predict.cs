﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predict : MonoBehaviour {
    private Target target;
    private Bullet_Controller bullet;

    private float velocity,
                  space,
                  time,
                  _distance;

    private Vector3 dir;

    private Transform firePoint;

	void Start () {
        firePoint = GetComponentInChildren<Transform>();
        target = gameObject.GetComponent<Target>();
        bullet = gameObject.AddComponent<Bullet_Controller>();
	}

    private void Update()
    {
        DoVelSpaceTimeCalc();
	}


    /// <summary>
    /// Variable "space" becomes the amount the enemy will have moved after the bullet is done travelling.
    /// </summary>
    private void DoVelSpaceTimeCalc()
    {
        if (target.enemyCount.Count != 0)
        { 
           dir = target.PositionOfEnemy - firePoint.transform.position;
          _distance = Mathf.Atan2(dir.y, dir.x);

          velocity = target.GetVelocityOfEnemy;

          time = (_distance / bullet._bulletSpeed) * Time.deltaTime;

          space = velocity * time;
        }
    }

    public float GetSpace { get { return space; } }

}
