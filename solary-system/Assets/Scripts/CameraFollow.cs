using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _followSpeed;

    private Vector3 _offset;
    
    void Awake()
    {
        _offset = transform.position;
    }

    void LateUpdate()
    {
        // transform.parent = _target;
        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _followSpeed * Time.deltaTime);
        transform.LookAt(_target);
    }
}
