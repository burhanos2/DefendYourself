using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//example of setter
// hPoints.getHealth -= 20;

public class Hit_detect : MonoBehaviour {
    private Health_points hPoints;

    private short rewardMoney = 10;

    [SerializeField]
    private AudioSource hitSound, deathSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Bullet":
                hPoints.getHealth = hPoints.getHealth - 1;
                Destroy(collision.gameObject);
                hitSound.Play();
                break;
        }
    }

    
    void Start () {
        hPoints = gameObject.GetComponent<Health_points>();
        deathSound = GameObject.FindGameObjectWithTag("DeathSound").GetComponent<AudioSource>();
    }
	
	void Update () {
        if(hPoints.getHealth == 0)
        {
            //death
            Money_count.money += rewardMoney;
            deathSound.Play();
            DestroyImmediate(gameObject);
            
        }
	}
}
