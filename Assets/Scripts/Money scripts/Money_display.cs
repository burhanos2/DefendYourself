using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_display : MonoBehaviour
{
    [SerializeField]
    private Text money;

    private void Update()
    {
        money.text = "Money: $" + Money_count.money;
    }
}
