using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerHealth))]

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private PlayerHealth _health;
    private float _value; 

    private void Update() 
    {        
        float maxDelta = 10f;
        _slider.value = Mathf.MoveTowards(_slider.value, _value, maxDelta * Time.deltaTime);
    }

    private void Change()
    {
        _value = _health.Current;
    }

    private void OnEnable()
    {
        _health = GetComponent<PlayerHealth>();
        _health.SliderChanger += Change;
    }

    private void OnDisable()
    {
        _health.SliderChanger -= Change;
    }
}
