using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_points : MonoBehaviour{
    private int health = 5;

    public int getHealth
    {   get { return health; }
        set { health = value; }
    }
    
}
