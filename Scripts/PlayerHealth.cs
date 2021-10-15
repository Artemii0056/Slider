using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    private float _current = 0;

    [SerializeField] private UnityEvent _sliderChanger;

    public event UnityAction SliderChanger
    {
        add => _sliderChanger.AddListener(value);
        remove => _sliderChanger.RemoveListener(value);
    }

    public float Current => _current;

    public void OnButtonClickDecrease()
    {
        _current -= 10f;
        _sliderChanger?.Invoke();
    }

    public void OnButtonClickIncrease()
    {
        _current += 10f;
        _sliderChanger?.Invoke();    
    }
}
