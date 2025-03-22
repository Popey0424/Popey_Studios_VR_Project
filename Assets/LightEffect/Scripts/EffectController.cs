using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;

public class EffectController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioLowPassFilter lowPassfilter;
    public AudioEchoFilter echofilter;
    public Slider lowPassSlider;
    public Slider EchoSlider;

    private void Start()
    {
        EchoSlider.value = 1;
        lowPassSlider.value = 1;
        EchoSlider.onValueChanged.AddListener(UpdateEcho);
        lowPassSlider.onValueChanged.AddListener(UpdateEffect);
    }

    private void UpdateEffect(float newValue)
    {
        lowPassfilter.cutoffFrequency = Mathf.Lerp(500f, 22000f, newValue);
    }

    private void UpdateEcho(float newValue)
    {
        echofilter.delay = Mathf.Lerp(0f, 500f, newValue);
        echofilter.decayRatio = Mathf.Lerp(0f, 1f, newValue);
        echofilter.dryMix = Mathf.Lerp(0f, 1f,newValue);
    }
}
