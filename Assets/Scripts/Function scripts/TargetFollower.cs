using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _Xoffset = 0, _Yoffset = 0, _Zoffset = 0;
  
    private Vector3 _offset;

    private void Start()
    {
        _offset = new Vector3(_Xoffset, _Yoffset, _Zoffset);
    }

    private void Update()
    {
        transform.position = new Vector3(_target.localPosition.x, _target.localPosition.y, _target.localPosition.z) + _offset;
    }
}

