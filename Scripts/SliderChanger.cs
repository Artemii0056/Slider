using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerHealth))]

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _player;

    private void OnEnable()
    {
        _player.HealthChanged += OnSliderChanger;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnSliderChanger;
    }

    private void OnSliderChanger()
    {
        StartCoroutine(Changer());
        StopCoroutine(Changer());
    }

    private IEnumerator Changer()
    {
        while (_slider.value != _player.Current)
        {
            float maxDelta = 10f;
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Current, maxDelta * Time.deltaTime);
            yield return null;
        }
    }
}
