using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Waypoint_EndPoint : MonoBehaviour {
    

	public void EndPoint(Object this_obj)
    {
        //this is preformed before gameobject reaches the end
        PlayerHealth.playerHealth -= 1;
        Destroy(this_obj);

        if(PlayerHealth.playerHealth <= 0)
        {
            SceneManager.LoadScene("Main menu");
        }
    }
}
