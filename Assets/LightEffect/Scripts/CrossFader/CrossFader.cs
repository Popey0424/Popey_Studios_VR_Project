using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CrossFader : MonoBehaviour
{
    [SerializeField] private Slider _crossFaderSlider;
    [SerializeField] private AudioSource _audioSourceDeck1;
    [SerializeField] private AudioSource _audioSourceDeck2;


    private void Start()
    {
        if(_crossFaderSlider != null)
        {
            _crossFaderSlider.onValueChanged.AddListener(UpdateCrossFade);
            UpdateCrossFade(_crossFaderSlider.value);
        }
    }

    private void UpdateCrossFade(float value)
    {
        _audioSourceDeck1.volume = 1f - value;
        _audioSourceDeck2.volume = value;
    }
}
