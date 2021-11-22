using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _orbitSpeed;

    void Awake()
    {
        if(_target == null)
        {
            _target = GameObject.Find("Sun").transform;
        }
    }
    void Update()
    {
        transform.parent = _target;
        transform.RotateAround(_target.position, transform.up, _orbitSpeed * Time.deltaTime);
    }
}
