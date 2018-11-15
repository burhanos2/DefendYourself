using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addrendercamera : MonoBehaviour {
    private Camera _camera;
    private Canvas _canvas;

	private void Start () {
        _camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        _canvas = gameObject.GetComponent<Canvas>();
        _canvas.worldCamera = _camera;

	}
	
}
