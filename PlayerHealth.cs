using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    private float _current = 0;

    public delegate void SendHealthInfo();

    public event SendHealthInfo Increased;
    public event SendHealthInfo Decreased;

    public float Current => _current;

    public void OnButtonClickDecrease()
    {
        _current -= 10f;
        Decreased();
    }

    public void OnButtonClickIncrease()
    {
        _current += 10f;
        Increased();      
    }
}
