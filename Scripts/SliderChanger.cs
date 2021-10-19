using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerHealth))]

public class SliderChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private PlayerHealth _player;

    private bool isCoroutineWorking = false;

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
        if (isCoroutineWorking == false)
        {
            var changerJob = StartCoroutine(Changer());
        }
    }

    private IEnumerator Changer()
    {
        isCoroutineWorking = true;

        while (_slider.value != _player.Current)
        {
            float maxDelta = 10f;
            _slider.value = Mathf.MoveTowards(_slider.value, _player.Current, maxDelta * Time.deltaTime);
            yield return null;
        }

        isCoroutineWorking = false;
    }
}
