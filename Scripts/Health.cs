using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Health : MonoBehaviour
{
    private float _current = 0;
    private float _increase = 10f; 
    private float _decrease = 10f; 
    private float _max = 100;
    private float _min = 0;

    public float Current => _current;

    public event UnityAction HealthChanged;

    public void OnButtonClickDecrease()
    {
        _current -= _decrease; 

        if (_current < _min)
        {
            _current = _min;     
        }

        HealthChanged?.Invoke();
    }

    public void OnButtonClickIncrease()
    {
        _current += _increase;

        if (_current > _max)
        {
            _current = _max;
        }

        HealthChanged?.Invoke();
    }
}
