using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Instantiate : MonoBehaviour {
    [SerializeField]
    private float waitTime;

    [SerializeField]
    private GameObject enemy;
    
	void Start () {
        Invoke("CreateEnemy", waitTime);
    }

    private void CreateEnemy()
    {
            Instantiate(enemy, transform.position, transform.rotation);
        Invoke("CreateEnemy", waitTime);
    }
}
