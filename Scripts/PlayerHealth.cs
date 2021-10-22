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

        if (_current < 0)
        {
            _current = 0;     
        }
        else
        {
            HealthChanged?.Invoke();
        }
    }

    public void OnButtonClickIncrease()
    {
        _current += 10f;

        if (_current > 100)
        {
            _current = 100;
        }
        else
        {
            HealthChanged?.Invoke();
        }
    }
}
