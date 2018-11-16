using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public static int playerHealth = 3;

    [SerializeField]
    private Text health;

    private void Update()
    {
        health.text = "Your health: " + playerHealth;
    }


}
