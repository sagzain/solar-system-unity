using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Time.timeScale = 0;
    }
    
    public void ChangeTime(float value)
    {
        Time.timeScale = value;
    }
}
