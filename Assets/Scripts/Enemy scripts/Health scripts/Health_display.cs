using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_display : MonoBehaviour {
    private Health_points hPoints;
    [SerializeField]
    private Slider slider;

    // Use this for initialization
    void Start () {
        hPoints = gameObject.GetComponent<Health_points>();
        slider.minValue = 0;
        slider.maxValue = hPoints.getHealth;
    }
	
	// Update is called once per frame
	void Update () {
        
        slider.value = hPoints.getHealth;
	}
}
