using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health_display : MonoBehaviour {
    private Health_points hPoints;
    [SerializeField]
    private Slider slider;
    
    void Start () {
        hPoints = gameObject.GetComponent<Health_points>();
        slider.minValue = 0;
        slider.maxValue = hPoints.getHealth;
    }
	
	void Update () {
        
        slider.value = hPoints.getHealth;
	}
}
