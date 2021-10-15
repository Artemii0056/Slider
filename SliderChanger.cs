using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerHealth))]

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private PlayerHealth _health;
    private float _value; 

    private void Start()
    {
        _health = gameObject.GetComponent<PlayerHealth>();

        _health.Increased += Increase;
        _health.Decreased += Decrease;
    }

    private void Update() 
    {        
        float maxDelta = 10f;
        _slider.value = Mathf.MoveTowards(_slider.value, _value, maxDelta * Time.deltaTime);
    }

    public void Increase()
    {
        _value += 10;
    }

    public void Decrease()
    {
        _value -= 10;
    }
}
