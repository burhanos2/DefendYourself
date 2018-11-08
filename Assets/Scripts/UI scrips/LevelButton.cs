using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour {

    void Start()
    {

    }

    public void TaskOnClick(string nextSceneName)
    {
        SceneManager.LoadScene(nextSceneName);
    }
     
    // Update is called once per frame
    void Update () {
		
	}
}
