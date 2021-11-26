using System.Collections;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _followSpeed;
    [SerializeField] private float _delayTime;
    private Vector3 _offset;
    
    void Awake()
    {
        _offset = transform.position;
    }

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + _offset, _followSpeed * Time.deltaTime);
        transform.LookAt(_target);
    }

    public void ChangeTarget(Transform target)
    {
        float aux = _followSpeed;
        _followSpeed = 1f;
        _target = target;
        transform.parent = target;

        StartCoroutine(WaitForCamera(aux));
    }

    IEnumerator WaitForCamera(float value)
    {
        yield return new WaitForSeconds(_delayTime);

        _followSpeed = value;

    }
}
