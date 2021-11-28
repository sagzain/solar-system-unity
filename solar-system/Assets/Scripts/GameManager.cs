using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CameraFollow _camera;
    [SerializeField] private Text _selection;
    [SerializeField] private List<Transform> _targets;
    
    private int _index = 0;

    void Start()
    {
        Time.timeScale = 0;
        _selection.text = _targets[_index].gameObject.name;
    }
    
    public void ChangeTime(float value)
    {
        Time.timeScale = value;
    }

    public void NextTarget()
    {
        _index++;
        ChangeTarget();
    }

    public void PreviousTarget()
    {
        _index--;
        ChangeTarget();
    }

    void ChangeTarget()
    {
        _index = Mathf.Abs(_index) % (_targets.Count-1);
        _selection.text = _targets[_index].gameObject.name;
        _camera.ChangeTarget(_targets[_index]);
    }
}
