using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Instantiate : MonoBehaviour
{
    [SerializeField]
    private float waitTime;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private Transform firePoint;

    private Target target;

    private void Start()
    {
        target = gameObject.GetComponentInParent<Target>();

        Invoke("CreateBullet", waitTime);
    }


    private void CreateBullet()
    {
        if (target.enemyCount.Count != 0)
        {
            Instantiate(bullet, firePoint.position, firePoint.rotation); 
        }

        Invoke("CreateBullet", waitTime);
    }
}
