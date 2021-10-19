using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class PlayerHealth : MonoBehaviour
{
    private float _current = 0;
    public float Current => _current;

    public event UnityAction HealthChanged;

    public void OnButtonClickDecrease()
    {
        _current -= 10f;
        HealthChanged?.Invoke();
    }

    public void OnButtonClickIncrease()
    {
        _current += 10f;
        HealthChanged?.Invoke();    
    }
}
